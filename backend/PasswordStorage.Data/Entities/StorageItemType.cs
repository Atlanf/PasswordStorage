using System.ComponentModel.DataAnnotations;

namespace PasswordStorage.Data.Entities
{
    public class StorageItemType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
