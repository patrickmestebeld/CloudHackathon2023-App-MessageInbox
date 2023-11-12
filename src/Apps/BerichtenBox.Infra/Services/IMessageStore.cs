using BerichtenBox.Infra.Models;

namespace BerichtenBox.Infra.Services;

public interface IMessageStore
{
    void Add(TslMessage message);

    IEnumerable<StoredMessage> Messages { get; }
}