[Binding]
public class PlaywrightHooks
{
    private readonly ScenarioContext _context;
    private PlaywrightDriver _driver;

    public PlaywrightHooks(ScenarioContext context)
    {
        _context = context;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        var settings = TestSettings.Load();
        _driver = new PlaywrightDriver();
        await _driver.Init(settings);
        _context["Page"] = _driver.Page;
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        await _driver.Dispose();
    }
}