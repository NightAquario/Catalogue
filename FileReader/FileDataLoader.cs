using Catalogue.DTO;

namespace UnitManagement;

public static class FileDataLoader
{
    public static IEnumerable<Categories> GetCategories(string filePath)
    {
        if (filePath == null) throw new ArgumentNullException(nameof(filePath));
        if (!File.Exists(filePath)) throw new FileNotFoundException(filePath);

        string[] data = File.ReadAllLines(filePath);
        //ValidateData(data);

        HashSet<Categories> categories = new();
        FillCatalogue(data, categories);

        Console.WriteLine();
        return categories;
    }

    private static void FillCatalogue(string[] data, HashSet<Categories> categories)
    {
        foreach (var line in data)
        {
            Categories category =
                GetCategoryByCode(Categories.GetCategoryCode(line), Categories.GetCategoryName(line), categories) ??
                Categories.CreateFromString(line);


            category.Products.Add(Products.CreateFromString(line));
            categories.Add(category);
        }


        foreach (var category in categories)
        {
            Console.WriteLine($"{category.CategoryName} - {category.GetHashCode()}");
        }
    }

    private static Categories? GetCategoryByCode(string code, string name, IEnumerable<Categories> categories)
    {
        foreach (var category in categories)
        {
            if (category.CategoryCode == code && !category.CategoryName.Equals(name))
            {
                category.CategoryName = name;
                return category;
            }
            if (category.CategoryCode == code && category.CategoryName.Equals(name))
            {
                return category;
            }
        }

        return null;
    }

}
