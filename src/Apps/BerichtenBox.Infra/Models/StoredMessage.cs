namespace BerichtenBox.Infra.Models;

public class StoredMessage : TslMessage
{
    public DateTime TimeStamp { get;  } = DateTime.UtcNow;
}