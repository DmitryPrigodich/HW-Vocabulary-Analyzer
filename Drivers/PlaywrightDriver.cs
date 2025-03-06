using HW_Vocabulary_Analyzer.Config;
using Microsoft.Playwright;

namespace HW_Vocabulary_Analyzer.Drivers;

public class PlaywrightDriver
{
    public IPage Page { get; private set; }
    private IBrowser _browser;
    private IPlaywright _playwright;

    public async Task Init(TestSettings settings)
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright[settings.Browser].LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = settings.Headless
        });
        Page = await _browser.NewPageAsync();
    }

    public async Task Dispose()
    {
        await Page.CloseAsync();
        await _browser.CloseAsync();
        _playwright.Dispose();
    }
}