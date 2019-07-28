using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class DepartmentMapping : EntityTypeConfiguration<Department>
    {
        public DepartmentMapping()
        {
            ToTable("Departments");
            Property(d => d.DepartmentName).IsRequired().HasColumnType("nvarchar").HasMaxLength(80);
        }
    }
}
