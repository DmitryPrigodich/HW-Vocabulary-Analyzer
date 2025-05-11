namespace HWA_Project;

public static class Helpers
{
    public static IEnumerable<string> SplitAndTrim(string field) =>
        (field ?? "")
        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(s => s.Trim())
        .Where(s => !string.IsNullOrEmpty(s));

    public static void AddCounts(string field, Dictionary<string,int> counts)
    {
        foreach (var item in SplitAndTrim(field))
        {
            if (!counts.ContainsKey(item)) counts[item] = 0;
            counts[item]++;
        }
    }

    public static void WriteFrequency(StreamWriter writer, string title, Dictionary<string,int> counts)
    {
        writer.WriteLine($"\n=== {title} By Frequency ===");
        foreach (var kv in counts.OrderByDescending(x => x.Value))
            writer.WriteLine($"{kv.Key} : {kv.Value}");
    }
}