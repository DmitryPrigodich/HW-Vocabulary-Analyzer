using HW_Vocabulary_Analyzer.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace HW_Vocabulary_Analyzer.Steps;

[Binding]
public class VocAnalSteps
{
    private readonly TestLoginPage _loginPage;

    public VocAnalSteps(ScenarioContext context)
    {
        var page = (IPage)context["Page"];
        _loginPage = new TestLoginPage (page);
    }
    
    [Given(@"HW""(.*)"" vocabulary is analyzed")]
    public async Task LoginWithCsv(string gamePart)
    {
        var vocabulary = Utils.CsvHelper.ReadCsv<UserData>("Data/HW1_Vocabulary.csv");
        var admin = vocabulary.First(u => u.Parts == "Parts");
        await _loginPage.Login(user.Username, user.Password);
    }
}