using DataAccess.Management;
using Entities;

namespace BusinessLogic
{
    public class PolyclinicController
    {
        PolyclinicManagement polyclinicManagement;

        public PolyclinicController()
        {
            polyclinicManagement = new PolyclinicManagement();
        }

        public bool AddPolyclinic(Polyclinic polyclinic)
        {
            if (polyclinic.PolyclinicName.Length > 100)
            {
                return false;
            }

            return polyclinicManagement.AddPolyclinic(polyclinic);
        }
    }

}
