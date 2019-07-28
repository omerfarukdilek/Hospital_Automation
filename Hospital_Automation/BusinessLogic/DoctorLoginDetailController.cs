using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class DoctorLoginDetailController
    {
        DoctorLoginDetailManagement doctorLoginDetailManagement;

        public DoctorLoginDetailController()
        {
            doctorLoginDetailManagement = new DoctorLoginDetailManagement();
        }

        public bool AddDoctorLoginDetail(DoctorLoginDetail doctorLoginDetail)
        {
            if (doctorLoginDetail.UserName.Length > 20)
            {
                return false;
            }

            if (doctorLoginDetail.Password.Length > 16)
            {
                return false;
            }

            return doctorLoginDetailManagement.AddDoctorLoginDetail(doctorLoginDetail);
        }
    }

}
