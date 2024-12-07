namespace Catalogue.DTO;

public class Categories
{
    public int Id { get; set; }
    public required string Code { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public required bool IsActive { get; set; }
    public ICollection<Products>? Products { get; set; }
}
