public class TestLoginPage
{
    private readonly IPage _page;

    public TestLoginPage(IPage page)
    {
        _page = page;
    }

    public async Task Open() => await _page.GotoAsync("https://example.com/login");

    public async Task Login(string username, string password)
    {
        await _page.Locator("#username").FillAsync(username);
        await _page.Locator("#password").FillAsync(password);
        await _page.Locator("#loginButton").ClickAsync();
    }
}