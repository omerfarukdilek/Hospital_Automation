using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class DoctorController
    {
        DoctorManagement doctorManagement;

        public DoctorController()
        {
            doctorManagement = new DoctorManagement();
        }

        public bool AddDoctor(Doctor doctor)
        {
            if (doctor.FirstName.Length > 50)
            {
                return false;
            }

            if (doctor.LastName.Length > 50)
            {
                return false;
            }



            return doctorManagement.AddDoctor(doctor);
        }
    }

}
