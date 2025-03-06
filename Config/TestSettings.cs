public class TestSettings
{
    public string BaseUrl { get; set; }
    public string Browser { get; set; }
    public bool Headless { get; set; }

    public static TestSettings Load()
    {
        var json = File.ReadAllText("Config/appsettings.json");
        return JsonSerializer.Deserialize<TestSettings>(json);
    }
}