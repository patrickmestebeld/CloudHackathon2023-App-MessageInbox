using BerichtenBox.Infra.Models;

namespace BerichtenBox.Infra.Validation;

public interface ITslMessageValidator
{
    bool Validate(TslMessage message);
}