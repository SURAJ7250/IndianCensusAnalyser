using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser.Using_Code
{
    public class CSVStateCode
    {
        public int ReadStateCodeData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCodeDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.serialNumber);
                    Console.WriteLine(data.stateName);
                    Console.WriteLine(data.tin);
                    Console.WriteLine(data.stateCode);
                }
                return records.Count() - 1;
            }
        }
    }
}
