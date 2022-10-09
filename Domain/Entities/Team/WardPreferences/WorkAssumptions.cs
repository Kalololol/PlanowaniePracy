using Domain.Common;
using Domain.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Team.WardPreferences
{
    public class WorkAssumptions : EntityBase, IAuditableEntity
    {
        public int WardId { get; set; }
        public int MinimumNumberOfEmployees { get; set; }
        public int MaximumNumberOfEmployees { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
