using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class PatientLoginDetailController
    {
        PatientLoginDetailManagement patientLoginDetailManagement;

        public PatientLoginDetailController()
        {
            patientLoginDetailManagement = new PatientLoginDetailManagement();
        }


        public bool AddPatientLoginDetail(PatientLoginDetail patientLoginDetail)
        {
            if (patientLoginDetail.UserName.Length > 20)
            {
                return false;
            }

            return patientLoginDetailManagement.AddPatientLoginDetail(patientLoginDetail);
        }
    }

}
