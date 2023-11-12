using System.ComponentModel;

namespace BerichtenBox.Models;

public class MessageViewModel
{
    [DisplayName("Aanvrager id")]
    [ReadOnly(true)]
    public string Subject { get; set; } = string.Empty;

    [DisplayName("Berichttype")]
    [ReadOnly(true)]
    public string MessageType { get; set; } = string.Empty;

    [DisplayName("Document link")]
    [ReadOnly(true)]
    public string Url { get; set; } = string.Empty;
}