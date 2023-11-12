using BerichtenBox.Infra.Models;

namespace BerichtenBox.Infra.Services;

public class MessageStore : IMessageStore
{
    private readonly List<StoredMessage> _messages = new();

    private readonly object _lock = new();

    public void Add(TslMessage message)
    {
        lock (_lock)
        {
            _messages.Add(message.ToStoredMessage());
        }
    }

    public IEnumerable<StoredMessage> Messages
    {
        get
        {
            lock (_lock)
            {
                return _messages;
            }
        }
    }
}