namespace PasswordStorage.Data.Entities
{
    public class StorageItem : BaseEntity
    {
        public string Name { get; set; }
        public StorageItemType Type { get; set; }
    }
}
