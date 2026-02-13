namespace Dong.Models;

public class CalculationResult
{
    public string TotalCost { get; set; } = string.Empty;

    public string Average { get; set; } = string.Empty;

    public List<Breakdown> Breakdowns { get; set; } = [];

    public List<Payment> Payments { get; set; } = [];
}

public class Breakdown
{
    public string Name { get; set; } = string.Empty;

    public string Paid { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}

public class Payment
{
    public string Who { get; set; } = string.Empty;

    public string Whom { get; set; } = string.Empty;

    public string Amount { get; set; } = string.Empty;
}