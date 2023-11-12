using BerichtenBox.Infra.Models;

namespace BerichtenBox.Infra;

public static class Extensions
{
    public static StoredMessage ToStoredMessage(this TslMessage message)
    {
        return new StoredMessage
        {
            MessageType = message.MessageType,
            SubjectId = message.SubjectId,
            Url = message.Url
        };
    }
}