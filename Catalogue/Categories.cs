namespace Catalogue.DTO;

public class Categories
{
    public int Id { get; set; }
    public string CategoryCode { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public bool IsCategoryActive { get; set; }
    public ICollection<Products> Products { get; set; } = new List<Products>();

    public static Categories CreateFromString(string input)
    {
        string[] fields = input.Split('\t');

        return new()
        {
            CategoryCode = fields[0],
            CategoryName = fields[1],
            IsCategoryActive = Convert.ToBoolean(byte.Parse(fields[2]))
        };
    }
    public static string GetCategoryName(string input)
    {
        return input.Split('\t')[1];
    }
    public static string GetCategoryCode(string input)
    {
        return input.Split('\t')[0];
    }
}