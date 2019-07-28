using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class PatientController
    {
        PatientManagement patientManagement;

        public PatientController()
        {
            patientManagement = new PatientManagement();
        }

        public bool AddPatient(Patient patient)
        {

            if (patient.FirstName.Length > 50)
            {
                return false;
            }

            if (patient.LastName.Length > 50)
            {
                return false;
            }

            if (patient.Phone.Length != 11)
            {
                return false;
            }


            return patientManagement.AddPatient(patient);

        }
    }

}
