using DataAccess.Management;
using Entities;

namespace BusinessLogic
{
    public class PharmacistController
    {
        PharmacistManagement pharmacistManagement;

        public PharmacistController()
        {
            pharmacistManagement = new PharmacistManagement();
        }

        public bool AddPharmacist(Pharmacist pharmacist)
        {
            if (pharmacist.FirstName.Length > 50)
            {
                return false;
            }

            if (pharmacist.LastName.Length > 50)
            {
                return false;
            }

            return pharmacistManagement.AddPharmacist(pharmacist);
        }
    }

}
