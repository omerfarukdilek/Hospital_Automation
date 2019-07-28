using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class DepartmentManagement
    {
        DatabaseContext database;
        public DepartmentManagement()
        {
            database = new DatabaseContext();

        }

        public bool AddDepartment(Department d)
        {
            try
            {
                database.Departments.Add(d);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemoveDepartment(Department d)
        {
            if (d.DepartmentId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedDepartment = database.Departments.FirstOrDefault(x => x.DepartmentId == d.DepartmentId);
                if (selectedDepartment == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{d.DepartmentId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Departman Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Departments.Remove(selectedDepartment);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdateDepartment(Department d)
        {
            Department updatedDepartment = database.Departments.FirstOrDefault(x => x.DepartmentId == d.DepartmentId);

            database.Entry(updatedDepartment).CurrentValues.SetValues(updatedDepartment);
            database.Entry(updatedDepartment).State = EntityState.Modified;
        }

        public List<Department> ListDepartment()
        {
            return database.Departments.ToList();
        }
    }

}
