using BerichtenBox.Infra.Models;

namespace BerichtenBox.Infra.Validation;

public class TslMessageValidator : ITslMessageValidator
{
    public bool Validate(TslMessage message)
    {
        if (string.IsNullOrEmpty(message.MessageType))
            throw new ArgumentException("MessageType is empty");

        if (string.IsNullOrEmpty(message.SubjectId))
            throw new ArgumentException("Subject is empty");

        if (string.IsNullOrEmpty(message.Url))
            throw new ArgumentException("Url is empty");

        return true;
    }
}