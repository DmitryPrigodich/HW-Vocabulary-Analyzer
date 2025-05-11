using System.Globalization;
using CsvHelper;

namespace HWA_Project;

public class Analyzer
{
    static readonly HashSet<char> VowelsSet = new HashSet<char>("aeiouAEIOUx".ToCharArray());

    public static void AnalyzeCSV(string reportName, params string[] csvNames)
    {
        //CHECK PATHS
        var binDir = AppContext.BaseDirectory;
        var projectRoot = Path.GetFullPath(Path.Combine(binDir, "..", "..", ".."));
        var outputPath = Path.Combine(projectRoot, "Reports", reportName);
        
        //PREPARE DICTIONARIES
        var vowelsCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var consonantsCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var structureCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        var rootsToWords = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        var suffixesToWords = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        var structureToWords = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        foreach (var csvName in csvNames)
        {
            var dataPath = Path.Combine(projectRoot, "Data", csvName);
            if (!File.Exists(dataPath))
            {
                Console.Error.WriteLine($"Файл не найден: {dataPath}");
                return;
            }
            
            //READ CSV DATA
            using var reader = new StreamReader(dataPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<WordRecord>();
        
            //REARRANGE DATA
            foreach (var rec in records)
            {
                Helpers.AddCounts(rec.Vowels, vowelsCount);
                Helpers.AddCounts(rec.Consonants, consonantsCount);
                Helpers.AddCounts(rec.Structure, structureCount);

                foreach (var part in Helpers.SplitAndTrim(rec.Parts))
                {
                    if (string.IsNullOrEmpty(part)) continue;
                    char first = part[0];
                    var dict = VowelsSet.Contains(first)
                        ? suffixesToWords
                        : rootsToWords;

                    if (!dict.TryGetValue(part, out var list))
                        dict[part] = list = new List<string>();
                    list.Add(rec.Word);
                }

                foreach (var struc in Helpers.SplitAndTrim(rec.Structure))
                {
                    if (!structureToWords.TryGetValue(struc, out var list))
                        structureToWords[struc] = list = new List<string>();
                    list.Add(rec.Word);
                }
            }
        }
        
        //WRITE DOWN RESULTS
        using var writer = new StreamWriter(outputPath, false);

        Helpers.WriteFrequency(writer, "VOWELS", vowelsCount);
        Helpers.WriteFrequency(writer, "CONSONANTS", consonantsCount);
        
        writer.WriteLine("\n=== WORD STRUCTURES ===");
        foreach (var kv in structureToWords.OrderByDescending(x => x.Value.Count))
        {
            var words = kv.Value.Distinct().ToList();
            writer.WriteLine($"[{kv.Key.ToUpper()}] ({words.Count})");
            writer.WriteLine("\t" + string.Join(", ", words));
        }

        writer.WriteLine("\n=== ROOTS ===");
        foreach (var kv in rootsToWords.OrderByDescending(x => x.Value.Count))
        {
            var words = kv.Value.Distinct().ToList();
            writer.WriteLine($"[{kv.Key.ToUpper()}] ({words.Count})");
            writer.WriteLine("\t" + string.Join(", ", words));
        }
        
        writer.WriteLine("\n=== SUFFIXES ===");
        foreach (var kv in suffixesToWords.OrderByDescending(x => x.Value.Count))
        {
            var words = kv.Value.Distinct().ToList();
            writer.WriteLine($"[{kv.Key.ToUpper()}] ({words.Count})");
            writer.WriteLine("\t" + string.Join(", ", words));
        }

        Console.WriteLine($"Results saved to: {outputPath}");
    }
}