using System.ComponentModel.DataAnnotations;

namespace PasswordStorage.Data.Models
{
    public class StorageItemType : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}
