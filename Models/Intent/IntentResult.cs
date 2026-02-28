
public class IntentResult
{
    public string IntentType { get; set; } = "";
    public string Table { get; set; } = "";
    public List<string> Fields { get; set; } = new();
    public List<FilterCondition>? Filters { get; set; }

    public string? CompareField { get; set; }   

    public string? ClarifyQuestion { get; set; }

}
public class FilterCondition
{
    public string Field { get; set; } = "";
    public string Operator { get; set; } = "="; // =, >, <, >=, <=, LIKE
    public object? Value { get; set; }
}

