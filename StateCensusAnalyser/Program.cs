using StateCensusAnalyser.Using_Census;
using StateCensusAnalyser.Using_Code;

namespace StateCensusAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filepathstatecensus = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\IndianCensusAnalyser\StateCensusAnalyser\StateCensus.csv";
            string filepath = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\IndianCensusAnalyser\StateCensusAnalyser\Using Code\StateCode.csv";
            //StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            //int StateCensusRecords = analyzer.ReadStateCensusData(filepathstatecensus);
            //CSVStateCensus census = new CSVStateCensus();
            //int censusRecords = census.ReadStateCensusData(filepathstatecensus);
            //if (StateCensusRecords == censusRecords)
            //    Console.WriteLine("Number of records match");
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filepath);
            CSVStateCode stateCode = new CSVStateCode();
            int codeRecords = stateCode.ReadStateCodeData(filepath);
            if (StateCodeRecords == codeRecords)
                Console.WriteLine("Number of records match");
        }
    }
}