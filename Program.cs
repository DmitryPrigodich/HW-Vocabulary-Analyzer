using System.Globalization;
using CsvHelper;

namespace HWA_Project;

public static class Program
{
    public static void Main()
    {
        Analyzer.AnalyzeCSV("hw1voc.csv", "hw1-report.txt");
    }
}