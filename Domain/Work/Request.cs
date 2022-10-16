using Domain.Common;
using Domain.Entities.Entity;
using Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Work
{
    public class Request : EntityBase, IAuditableEntity
    {
        public DateTime DayRequest { get; set; }
        [Required]
        public Shift Change { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
