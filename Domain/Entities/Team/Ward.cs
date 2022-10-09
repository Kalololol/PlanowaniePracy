using Domain.Common;
using Domain.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Team
{
    public class Ward : EntityBase, IAuditableEntity
    {
        public string WardName { get; set; }
        public ICollection<Employee> Employees { get; set; } 
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
