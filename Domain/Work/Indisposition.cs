using Domain.Common;
using Domain.Entities.Entity;
using Domain.Entities.Team;
using System.ComponentModel.DataAnnotations;

namespace Domain.Work
{
    public class Indisposition : EntityBase, IAuditableEntity
    {
        public DateTime DayIndisposition { get; set; }
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
