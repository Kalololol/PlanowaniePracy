using Domain.Common;
using Domain.Entities.Entity;
using Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Planner
{
    public class PlanDay : EntityBase, IAuditableEntity
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
