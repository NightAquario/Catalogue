using Catalogue.DTO;

namespace FileReader;

public static class DataLoaderFromFile
{
    public static IEnumerable<Categories> Load(string filePath)
    {
        if (!File.Exists(filePath)) throw new FileNotFoundException();

        if (filePath == null) throw new ArgumentNullException(nameof(filePath));


        return new Categories[0];
    }
}