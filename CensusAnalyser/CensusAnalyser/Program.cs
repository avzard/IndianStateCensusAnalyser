using System;

namespace CensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\admin\OneDrive\Desktop\Indian State Census Analyser\IndianStateCensusAnalyser\CensusAnalyser\StateCensusData.csv";
            int nummberOfRecords = StateCensusAnalyser.ReadStateCensus(filePath, ",");
            Console.WriteLine($"Records are {nummberOfRecords}");
        }
    }
}