namespace PasswordStorage.Data.Models
{
    public class StorageItem : BaseModel
    {
        public string Name { get; set; }
        public StorageItemType Type { get; set; }
    }
}
