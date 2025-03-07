using HW_Vocabulary_Analyzer.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace HW_Vocabulary_Analyzer.Steps;

[Binding]
public class VocAnalSteps
{
    [Given(@"^(.+) vocabulary (parts|vowels|consonants|structures) are analyzed$")]
    public async Task AnalyzeVocabularyStep(string game, string whatToAnalyze)
    {
        switch (whatToAnalyze)
        {
            case "parts":
                AnalyzeVocabularyParts();
                break;
            case "vowels": 
                AnalyzeVocabularyLetters();
                break;
            case "consonants":
                AnalyzeVocabularyLetters();
                break;
            case "structures":
                AnalyzeVocabularyStructures();
                break;
            default:
                break;
        }
    }

    private void AnalyzeVocabularyParts()
    {
        //PARTS ANALYSIS
        //get data from HW1_Vocabulary.csv
        //go row by row, gather all the parts from Parts column
        //print unique Parts list: part as a heading, and a list of words that have this part from Derivative column under that heading
        //print it in Reports/HW1_Word_Parts.txt
        //like this:
        // AL
        // Albegiido, Gaalsien, Hraal, Koraal... etc
    }

    private void AnalyzeVocabularyLetters()
    {
        //LETTER ANALYSIS
        //get data from HW1_Vocabulary.csv
        //go row by row, gather all the Vowels from Vowels column, separated by comma
        //type a list of unique vowels
        //count how many times vowel is met and write it as
        //%VOWEL%: X times
        
        //get data from HW1_Vocabulary.csv
        //go row by row, gather all the Consonants from Consonants column, separated by comma
        //type a list of unique vowels
        //count how many times vowel is met and write it as
        //%VOWEL%: X times
    }

    private void AnalyzeVocabularyStructures()
    {
        //STRUCTURE ANALYSIS
        //get data from HW1_Vocabulary.csv
        //go row by row, gather all the Structure from Structure column
        //print unique Structure list: part as a heading, and a list of words that have this Structure from Derivative column under that heading
        //print it in Reports/HW1_Word_Parts.txt
        //like this:
        // XY
        // Sha,Ra,Sa... etc
    }
}