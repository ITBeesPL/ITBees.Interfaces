namespace ITBees.Interfaces.ExternalSalesPlatformIntegration.Models;

public class NewLeadIm
{
    public string? Email { get; set; }
    public string? NIP { get; set; }
    public string? CompanyName { get; set; }
    public string? Name { get; set; }
    public string? SourceUrl { get; set; }
    public string? Campaign { get; set; }
    public string? Phone { get; set; }
    public string? Label { get; set; }
    public string? LabelColor { get; set; }
    public string? Note { get; set; }
    public decimal? PossibleValue { get; set; }
    public string? PossibleValueCurrency { get; set; }
}