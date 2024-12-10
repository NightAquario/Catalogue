using UnitManagement;

namespace Program;

internal class Program
{
    static void Main(string[] args)
    {
        string filePath = @"D:\TestCatalogue\Products.txt";

        var catalogue = FileDataLoader.GetCategories(filePath);

        foreach (var category in catalogue)
        {
            Console.WriteLine(category.CategoryName + " " + category.CategoryCode + " " + category.IsCategoryActive);
            Console.WriteLine();

            foreach (var item in category.Products)
            {
                Console.WriteLine(item.ProductPrice + " " + item.ProductName + " " + item.IsProductActive);
            }
            Console.WriteLine();
        }
    }
}
