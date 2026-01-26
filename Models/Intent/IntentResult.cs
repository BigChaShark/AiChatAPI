
public class IntentResult
{
    public string IntentType { get; set; } = "";
    public string Table { get; set; } = "";
    public List<string> Fields { get; set; } = new();
    public bool UseMemberId { get; set; }
    public string? MemberIdField { get; set; }

}

