namespace PasswordStorage.Domain.DTO;

public class BaseDto
{
    public Guid Id { get; set; }
    
    public bool IsNew => Id == Guid.Empty;
    
    public void Initialize()
    {
        if (Id == Guid.Empty)
        {
            Id = Guid.NewGuid();
        }
    }
}