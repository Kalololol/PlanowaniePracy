using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Entity
{
    public class EntityBase
    {
        [Required]
        public int Id { get; set; }
    }
}
