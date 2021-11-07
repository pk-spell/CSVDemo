using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper.Configuration;
using System.Reflection;
using System.Data;

namespace CSVReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var streamReader = new StreamReader(@"C:\Users\Marscel Stakor\OneDrive - PIT Academy GmbH\Dokumente\rockets-sc.csv"))
            //{
            //    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            //    {
            //        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            //        {
            //            Delimiter = ";",
            //           // HasHeaderRecord = true
            //            //HeaderValidated = null
            //        };
            //        //csvReader.Context.RegisterClassMap<RocketDataClassMap>();
            //        var records = csvReader.GetRecords<RocketData>().ToList();

            var csvPath = Path.GetFullPath(@"C:\Users\Marscel Stakor\OneDrive - PIT Academy GmbH\Dokumente\rockets-132807731876829325-noheader.csv");
            using(var streamReader = new StreamReader(csvPath))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    HasHeaderRecord = true,
                    MissingFieldFound = null,
                    //HeaderValidated = null
                };
                
                using(var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    csvReader.Context.RegisterClassMap<RocketDataClassMap>();
                    var records = csvReader.GetRecords<RocketData>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine("Rocketdata: " + records.IndexOf(record) + "\n");
                        Console.WriteLine("Rocketname: " + record.RocketName);
                        Console.WriteLine("Organisation: " + record.Organisation);
                        Console.WriteLine("Payload capacity: " + record.PayloadCapacity);
                        Console.WriteLine("First launch date: " + record.FirstLaunchDate);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("\n\n\nDatei wurde erfolgreich eingelesen und dargestellt!");
                    Console.ReadKey();
                }
            }

            public class ListToDataTable
        {
            public ListToDataTable ToDataTable()
            {
                ListToDataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for(int i=0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
        }


                    //foreach (var record in records)
                    //{
                    //    Console.WriteLine("Rocketdata: " + records.IndexOf(record) + "\n");
                    //    Console.WriteLine("Rocketname: " + record.RocketName);
                    //    Console.WriteLine("Organisation: " + record.Organisation);
                    //    Console.WriteLine("Payload capacity: " + record.PayloadCapacity);
                    //    Console.WriteLine("First launch date: " + record.FirstLaunchDate);
                    //    Console.WriteLine("\n");
                    //}
                    //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    //Console.WriteLine("\n\n\nDatei wurde erfolgreich eingelesen und dargestellt!");
                    //Console.ReadKey();
            //    }
            //}
        }
    }
}
