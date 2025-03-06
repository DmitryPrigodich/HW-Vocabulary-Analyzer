using System.Globalization;
using CsvHelper;

namespace HW_Vocabulary_Analyzer.Utils;

public static class CsvHelper
{
    public static IEnumerable<T> ReadCsv<T>(string path)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<T>().ToList();
    }
}