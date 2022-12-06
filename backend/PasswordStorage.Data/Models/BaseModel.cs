using System.ComponentModel.DataAnnotations;

namespace PasswordStorage.Data.Models
{
    public class BaseModel
    {
        [Required]
        public Guid Id { get; set; }

        public void Initialize()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }
    }
}
