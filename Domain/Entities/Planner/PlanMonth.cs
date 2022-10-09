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
    public class PlanMonth : EntityBase, IAuditableEntity
    {
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDay> PlanDays { get; set; }
        public Ward Ward { get; set; }
        public bool ActivePlanMonth { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
