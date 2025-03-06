[Binding]
public class LoginSteps
{
    private readonly ScenarioContext _context;
    private readonly LoginPage _loginPage;

    public LoginSteps(ScenarioContext context)
    {
        _context = context;
        var page = (IPage)_context["Page"];
        _loginPage = new LoginPage(page);
    }

    [And(@"user opens login page")]
    public async Task OpenLoginPage() => await _loginPage.Open();

    [And(@"user logs in with credentials from ""(.*)""")]
    public async Task LoginWithCsv(string filePath)
    {
        var users = CsvHelper.ReadCsv<UserData>(filePath);
        var user = users.First();
        await _loginPage.Login(user.Username, user.Password);
    }

    [And(@"Another user logs in with credentials from ""(.*)""")]
    public async Task LoginWithCsv(string relativePath)
    {
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
        var users = CsvHelper.ReadCsv<UserData>(filePath);

        var user = users.First();
        //var admin = users.First(u => u.Role == "Admin");

        await _loginPage.Open();
        await _loginPage.Login(user.Username, user.Password);

        Console.WriteLine($"User '{user.Username}' with role '{user.Role}' is trying to log in.");
    }
}