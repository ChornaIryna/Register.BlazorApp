namespace Register.Shared.Domain;
public record Country
{
    public int CountryId { get; set; }
    public string Name { get; set; } = string.Empty;
}
