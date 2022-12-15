using System.ComponentModel.DataAnnotations;

namespace PasswordStorage.Data.Entities
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }

        public bool? IsDeleted { get; set; }

        public void Initialize()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }
    }
}
