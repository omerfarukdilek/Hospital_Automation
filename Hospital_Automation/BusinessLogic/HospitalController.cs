using DataAccess.Management;
using Entities;

namespace BusinessLogic
{
    public class HospitalController
    {
        HospitalManagement hospitalManagement;

        public HospitalController()
        {
            hospitalManagement = new HospitalManagement();
        }

        public bool AddHospital(Hospital hospital)
        {
            if (hospital.HospitalName.Length > 100)
            {
                return false;
            }

            return hospitalManagement.AddHospital(hospital);
        }
    }

}
