using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class HospitalDetailManagement
    {
        DatabaseContext database;
        public HospitalDetailManagement()
        {
            database = new DatabaseContext();

        }

        public bool AddHospitalDetail(HospitalDetail hd)
        {
            try
            {
                database.HospitalDetails.Add(hd);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemoveHospitalDetail(HospitalDetail hd)
        {
            if (hd.DetailId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedHospitalDetail = database.HospitalDetails.FirstOrDefault(x => x.DetailId == hd.DetailId);
                if (selectedHospitalDetail == null)
                {

                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{hd.DetailId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Hastane Detayı Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.HospitalDetails.Remove(selectedHospitalDetail);
                        database.SaveChanges();
                    }
                }
            }

        }


        public void UpdateHospitalDetail(HospitalDetail hd)
        {
            HospitalDetail updatedHospitalDetail = database.HospitalDetails.FirstOrDefault(x => x.DetailId == hd.DetailId);

            database.Entry(updatedHospitalDetail).CurrentValues.SetValues(updatedHospitalDetail);
            database.Entry(updatedHospitalDetail).State = EntityState.Modified;
        }

        public List<HospitalDetail> ListHospitalDetail()
        {
            return database.HospitalDetails.ToList();
        }
        public int SearchHospitalDetails(HospitalDetail d)
        {
            var result=database.HospitalDetails.SingleOrDefault(h=> h.HospitalId==d.HospitalId && h.PolyclinicId==d.PolyclinicId && h.DepartmentId==d.DepartmentId && h.DoctorId==d.DoctorId);
            return result.DetailId;
        }
    }

}
