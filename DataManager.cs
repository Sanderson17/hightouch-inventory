using System;
using System.Globalization;
using System.IO;

namespace HightouchInventory
{
    public class DataManager
    {
        public static void Main(string[] args)

        {
            using (var reader = new StreamReader("/Users/sarahkleinanderson/Documents/KleintiquesInventoryManager/KleintiquesInventoryManager/KleintiquesInventory.csv"))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Product>();
            }

            Console.WriteLine("Please specify a report to run (Total Units on Hand, Units by Category, Total Potential Profit):");
            var selectedReport = Console.ReadLine();

        }

    }
}
