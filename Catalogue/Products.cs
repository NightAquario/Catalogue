namespace Catalogue.DTO;

public sealed class Products
{
    public int Id { get; set; }
    public string ProductCode { get; set; } = null!;
    public  string ProductName { get; set; } = null!;
    public decimal ProductPrice { get; set; }
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public  bool IsProductActive { get; set; }

    public static Products CreateFromString(string input)
    {
        string[] fields = input.Split('\t');

        return new()
        {
            ProductCode = fields[3],
            ProductName = fields[4],
            ProductPrice = decimal.Parse(fields[5]),
            IsProductActive = Convert.ToBoolean(byte.Parse(fields[6]))
        };
    }
}
