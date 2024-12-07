namespace Catalogue.DTO;

public sealed class Products
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public  string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public  bool IsActive { get; set; }

}
