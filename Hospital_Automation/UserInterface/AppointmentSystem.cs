using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Management;
using Entities;

namespace UserInterface
{
    public partial class AppointmentSystem : Form
    {
        #region Instance
        PatientManagement patientManagement;
        HospitalManagement hospitalManagement;
        HospitalDetailManagement hospitalDetailManagement;
        PolyclinicManagement polyclinicManagement;
        DepartmentManagement departmentManagement;
        DoctorManagement doctorManagement;
        AppointmentManagement appointmentManagement;
        DoctorWorkingHour DoctorWorkingHour;
        DoctorWorkingHourManagement hourManagement;
        DatabaseContext database;
        #endregion

        public int UserID { get; set; }

        public AppointmentSystem()
        {
            InitializeComponent();
            hospitalManagement = new HospitalManagement();
            hospitalDetailManagement = new HospitalDetailManagement();
            polyclinicManagement = new PolyclinicManagement();
            departmentManagement = new DepartmentManagement();
            doctorManagement = new DoctorManagement();
            patientManagement = new PatientManagement();
            database = new DatabaseContext();
            appointmentManagement = new AppointmentManagement();
            hourManagement = new DoctorWorkingHourManagement();


        }



        private void AppointmentSystem_Load(object sender, EventArgs e)
        {
            var patientFullName = patientManagement.GetPatient(UserID);
            lblPatientName.Text = patientFullName.FirstName + " " + patientFullName.LastName;

            cmbHospital.SelectedIndexChanged -= new EventHandler(cmbHospital_SelectedIndexChanged);

            cmbHospital.DataSource = hospitalManagement.ListHospital();
            cmbHospital.DisplayMember = "HospitalName";
            cmbHospital.ValueMember = "HospitalId";
            cmbHospital.SelectedIndex = -1;
            cmbHospital.SelectedIndexChanged += new EventHandler(cmbHospital_SelectedIndexChanged);


            cmbPolyclinic.SelectedIndexChanged -= new EventHandler(cmbPolyclinic_SelectedIndexChanged);
            var polyclinics = polyclinicManagement.ListPolyclinic();

            cmbPolyclinic.DataSource = polyclinics.ToList();
            cmbPolyclinic.DisplayMember = "PolyclinicName";
            cmbPolyclinic.ValueMember = "PolyclinicId";
            cmbPolyclinic.SelectedIndex = -1;
            cmbPolyclinic.SelectedIndexChanged += new EventHandler(cmbPolyclinic_SelectedIndexChanged);

            cmbClinicLocation.SelectedIndexChanged -= new EventHandler(cmbClinicLocation_SelectedIndexChanged);
            var departments = departmentManagement.ListDepartment();

            cmbClinicLocation.DataSource = departments.ToList();
            cmbClinicLocation.DisplayMember = "DepartmentName";
            cmbClinicLocation.ValueMember = "DepartmentId";
            cmbClinicLocation.SelectedIndex = -1;
            cmbClinicLocation.SelectedIndexChanged += new EventHandler(cmbClinicLocation_SelectedIndexChanged);

            cmbChooseDoctor.SelectedIndexChanged -= new EventHandler(cmbChooseDoctor_SelectedIndexChanged);
            var doctors = doctorManagement.ListDoctor();

            cmbChooseDoctor.DataSource = doctors.ToList();
            cmbChooseDoctor.DisplayMember = "FirstName+' '+LastName";
            cmbChooseDoctor.ValueMember = "DoctorId";
            cmbChooseDoctor.SelectedIndex = -1;
            cmbChooseDoctor.SelectedIndexChanged += new EventHandler(cmbChooseDoctor_SelectedIndexChanged);
        }

        

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHospital.SelectedIndex >= 0)
            {
                var hastaneId = cmbHospital.SelectedValue;

                int selectedHospitalId = Convert.ToInt32(hastaneId);
                var hospitalDetails = hospitalDetailManagement.ListHospitalDetail();

                var result = hospitalDetails
                         .Where(h => h.HospitalId == selectedHospitalId)
                         .Select(h => h.Polyclinic).ToList();

                var resultList = (from h in database.HospitalDetails
                  .Where(d => d.HospitalId == selectedHospitalId)
                              select new
                              {
                                  Doktor_No = h.DoctorId,
                                  HastaneAdı = h.Hospital.HospitalName,
                                  PoliklinikAdı = h.Polyclinic.PolyclinicName,
                                  DepartmanAdı = h.Department.DepartmentName,
                                  DoktorAdıSoyadı = h.Doctor.FirstName + " " + h.Doctor.LastName,
                              }).ToList();
 

                if (result.Count > 0)
                {
                    cmbPolyclinic.DataSource = result;

                    cmbPolyclinic.DisplayMember = "PolyclinicName";
                    cmbPolyclinic.ValueMember = "PolyclinicId";
                    dtGridViewAvailableDoctorsandHospitals.DataSource = resultList;
                }
                else
                {
                    cmbPolyclinic.DataSource = null;
                }
            }
            else
            {
                cmbHospital.DataSource = null;
            }


        }

        private void cmbClinicLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClinicLocation.SelectedIndex >= 0)
            {
                var departmentId = cmbClinicLocation.SelectedValue;

                int selectedDepartmentId = Convert.ToInt32(departmentId);

                var result = (from d in database.HospitalDetails
                    .Where(d => d.DepartmentId == selectedDepartmentId)
                              select new
                              {
                                  Doktor_No = d.DoctorId,
                                  HastaneAdı = d.Hospital.HospitalName,
                                  PoliklinikAdı = d.Polyclinic.PolyclinicName,
                                  DepartmanAdı = d.Department.DepartmentName,
                                  DoktorAdıSoyadı = d.Doctor.FirstName + " " + d.Doctor.LastName,
                              }).ToList();

                dtGridViewAvailableDoctorsandHospitals.DataSource = result;


            }
            else
            {
                cmbClinicLocation.DataSource = null;
            }
        }

      

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbPolyclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHospital.SelectedIndex >= 0)
            {
                var selectedPolyclinicId = Convert.ToInt32(cmbPolyclinic.SelectedValue);

                var result = (from d in database.HospitalDetails
                    .Where(d => d.PolyclinicId == selectedPolyclinicId)
                              select new
                              {
                                  Doktor_No = d.DoctorId,
                                  HastaneAdı = d.Hospital.HospitalName,
                                  PoliklinikAdı = d.Polyclinic.PolyclinicName,
                                  DepartmanAdı = d.Department.DepartmentName,
                                  DoktorAdıSoyadı = d.Doctor.FirstName + " " + d.Doctor.LastName,
                              }).ToList();
                dtGridViewAvailableDoctorsandHospitals.DataSource = result;
            }
            else
            {
                cmbHospital.DataSource = null;
            }
        }

        private void cmbChooseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChooseDoctor.SelectedIndex >= 0)
            {
                var selectedDoctorId = Convert.ToInt32(cmbChooseDoctor.SelectedValue);

                var result = (from d in database.HospitalDetails
                    .Where(d => d.DoctorId == selectedDoctorId)
                              select new
                              {
                                  Doktor_No = d.DoctorId,
                                  HastaneAdı = d.Hospital.HospitalName,
                                  PoliklinikAdı = d.Polyclinic.PolyclinicName,
                                  DepartmanAdı = d.Department.DepartmentName,
                                  DoktorAdıSoyadı = d.Doctor.FirstName + " " + d.Doctor.LastName,
                              }).ToList();
                dtGridViewAvailableDoctorsandHospitals.DataSource = result;
            }
            else
            {
                cmbChooseDoctor.DataSource = null;
            }

        }


        

        int selectedDoctor;

        private void dtGridViewAvailableDoctorsandHospitals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDoctor = Convert.ToInt32(dtGridViewSelectedDoctorDate.CurrentRow.Cells[0].Value);
            GetAppointment(selectedDoctor);

        }

        private void btnSearchHospitalAppointment_Click(object sender, EventArgs e)
        {
            //int selectedDoctor = Convert.ToInt32(cmbChooseDoctor.SelectedValue);
            GetAppointment(selectedDoctor);
        }
        private void GetAppointment(int selectedDoctor)
        {

           
            var result= (from h in database.DoctorWorkingHours
                        .Where (h=>h.DoctorId == selectedDoctor && h.Status == true && h.Date == dpDate.Value)
                        select new
                           {
                             Saat_No = h.DoctorWorkingHourId,
                             Saat = h.Hour
                           }).ToList();
            dtGridViewSelectedDoctorDate.DataSource = result;
        }

        private void dtGridViewSelectedDoctorDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HospitalDetail detail = new HospitalDetail
            {
                HospitalId = Convert.ToInt32(cmbHospital.SelectedValue),
                PolyclinicId = Convert.ToInt32(cmbPolyclinic.SelectedValue),
                DepartmentId = Convert.ToInt32(cmbClinicLocation.SelectedValue),
                DoctorId = Convert.ToInt32(cmbChooseDoctor.SelectedValue),

            };
            int hospitalDetailId = hospitalDetailManagement.SearchHospitalDetails(detail);


            Appointment appointment = new Appointment
            {
                HospitalDetailId = hospitalDetailId,
                PatientId = UserID,
                DoctorWorkingHourId = Convert.ToInt32(dtGridViewSelectedDoctorDate.CurrentRow.Cells[0].Value),
                DateOfAppointment = DateTime.Now

            };
            appointmentManagement.AddAppointment(appointment);

            DoctorWorkingHour workingHour = new DoctorWorkingHour
            {
                DoctorWorkingHourId = Convert.ToInt32(dtGridViewSelectedDoctorDate.CurrentRow.Cells[0].Value),
                Status = false

            };
            hourManagement.UpdateWorkingHour(workingHour);

        }

        private void btnDeleteAppointment_Click_1(object sender, EventArgs e)
        {
            cmbHospital.SelectedIndex = -1;
            cmbPolyclinic.SelectedIndex = -1;
            cmbClinicLocation.SelectedIndex = -1;
            cmbChooseDoctor.SelectedIndex = -1;

            dtGridViewAvailableDoctorsandHospitals.DataSource = null;
            dtGridViewSelectedDoctorDate.DataSource = null;
        }
    }
}
