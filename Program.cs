using System.Globalization;
using CsvHelper;

namespace HWA_Project;

public static class Program
{
    public static void Main()
    {
        Analyzer.AnalyzeCSV("hw1-report.txt","hw1voc.csv");
        Analyzer.AnalyzeCSV("hwc-report.txt", "hwcvoc.csv");
        Analyzer.AnalyzeCSV("hw1-hwc-report.txt","hw1voc.csv", "hwcvoc.csv");
    }
}