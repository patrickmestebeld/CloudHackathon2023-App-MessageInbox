namespace BerichtenBox.Infra.Models;

[Serializable]
public class TslMessage
{
    public string MessageType { get; set; } = string.Empty;

    public string SubjectId { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;
}