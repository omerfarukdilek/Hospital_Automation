using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class PharmacistLoginDetailController
    {
        PharmacistLoginDetailManagement pharmacistLoginDetailManagement;

        public PharmacistLoginDetailController()
        {
            pharmacistLoginDetailManagement = new PharmacistLoginDetailManagement();
        }

        public bool AddPharmacistLoginDetail(PharmacistLoginDetail pharmacistLoginDetail)
        {
            if (pharmacistLoginDetail.UserName.Length > 20)
            {
                return false;
            }

            if (pharmacistLoginDetail.Password.Length > 16)
            {
                return false;
            }

            return pharmacistLoginDetailManagement.AddPharmacistLoginDetail(pharmacistLoginDetail);
        }
    }

}
