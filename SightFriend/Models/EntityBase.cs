using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public virtual Guid Id { get; set; }
        [DataType(DataType.Time)]
        public virtual DateTime DateAdded { get; set; }
    }
}
