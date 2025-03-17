using HW_Vocabulary_Analyzer.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace HW_Vocabulary_Analyzer.Steps;

[Binding]
public class LoginSteps
{
    // private readonly TestLoginPage _loginPage;
    //
    // public LoginSteps(ScenarioContext context)
    // {
    //     var page = (IPage)context["Page"];
    //     _loginPage = new TestLoginPage (page);
    // }
    //
    // [Given(@"user opens login page")]
    // public async Task OpenLoginPage() => await _loginPage.Open();
    //
    // [Given(@"user logs in with credentials from ""(.*)""")]
    // public async Task LoginWithCsv(string filePath)
    // {
    //     var users = Utils.CsvHelper.ReadCsv<UserData>(filePath);
    //     var user = users.First();
    //     await _loginPage.Login(user.Username, user.Password);
    // }
    //
    // [Given(@"Another user logs in with credentials from ""(.*)""")]
    // public async Task LoginWithCsv2(string relativePath)
    // {
    //     var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
    //     var users = Utils.CsvHelper.ReadCsv<UserData>(filePath);
    //
    //     var user = users.First();
    //     //var admin = users.First(u => u.Role == "Admin");
    //
    //     await _loginPage.Open();
    //     await _loginPage.Login(user.Username, user.Password);
    //
    //     Console.WriteLine($"User '{user.Username}' with role '{user.Role}' is trying to log in.");
    // }
}