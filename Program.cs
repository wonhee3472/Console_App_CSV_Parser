// Installed LINQtoCSV library to read a CSV file
using LINQtoCSV;
using System;
using System.Collections.Generic;

namespace CSVDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCsvFile();
            Console.ReadKey();
        }

        private static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();
            var employees = csvContext.Read<Employee>("employees.csv", csvFileDescription);

            var departmentCounts = new Dictionary<string, int>();

            foreach(var employee in employees)
            {
                if (departmentCounts.ContainsKey(employee.Department))
                {
                    departmentCounts[employee.Department]++;
                }
                else
                {
                    departmentCounts[employee.Department] = 1;
                }
            }

            foreach (var department in departmentCounts)
            {
                Console.WriteLine($"Department: {department.Key}, Count: {department.Value}");
            }
        }
    }
}
