using System.Globalization;
using CsvHelper;

namespace HWA_Project;

public static class Program
{
    public static void Main()
    {
        Analyzer.AnalyzeCSV("hw1-report.txt","hw1voc.csv");
        Analyzer.AnalyzeCSV("hwc-report.txt", "hwcvoc.csv");
        Analyzer.AnalyzeCSV("hw2-report.txt", "hw2voc.csv");
        Analyzer.AnalyzeCSV("hwr-report.txt", "hwrvoc.csv");
        Analyzer.AnalyzeCSV("hwdok-report.txt", "hwdokvoc.csv");
        Analyzer.AnalyzeCSV("hw3-report.txt", "hw3voc.csv");
        Analyzer.AnalyzeCSV("hw1-hwc-report.txt","hw1voc.csv", "hwcvoc.csv");
        Analyzer.AnalyzeCSV("hw1-hwc-hw2-report.txt","hw1voc.csv", "hwcvoc.csv", "hw2voc.csv");
        Analyzer.AnalyzeCSV("hwdok-hw3-report.txt","hwdokvoc.csv", "hw3voc.csv");
        Analyzer.AnalyzeCSV("all-hw-report.txt","hw1voc.csv", "hwcvoc.csv", "hw2voc.csv", "hwdokvoc.csv", "hwrvoc.csv", "hw3voc.csv");
        
    }
}