namespace Catalogue.DTO;

public class Categories
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Products>? Products { get; set; }
}