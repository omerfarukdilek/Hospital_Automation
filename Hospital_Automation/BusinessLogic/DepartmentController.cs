using DataAccess.Management;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DepartmentController
    {
        DepartmentManagement departmentManagement;

        public DepartmentController()
        {
            departmentManagement = new DepartmentManagement();
        }

        public bool AddDepartment(Department department)
        {
            if (department.DepartmentName.Length > 100)
            {
                return false;
            }

            return departmentManagement.AddDepartment(department);
        }
    }

}
