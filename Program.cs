// Installed LINQtoCSV library to read a CSV file
using LINQtoCSV;
using System;
using System.Collections.Generic;

namespace CSVDemo
{
    internal class Program
    {
        // 'Main' method to call the 'ReadCsvFile'
        // Console.ReadKey() to see the output on the console
        static void Main(string[] args)
        {
            ReadCsvFile();
            Console.ReadKey();
        }

        // declaring a method to read a CSV file
        private static void ReadCsvFile()
        {
            // couple properties when the CSV file is being read
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ','
            };

            // creating a new instance 'csvContext' of the 'CsvContext' class
            var csvContext = new CsvContext();

            // using the 'Read' method to read the 'employees.csv' file and map it to the 'Employee' class
            var employees = csvContext.Read<Employee>("employees.csv", csvFileDescription);

            // declaring a new dictionary object
            // department will be keys and count of employees will be values
            var departmentCounts = new Dictionary<string, int>();

            // a loop iterating over each 'employee'
            // if 'departmentCounts' doesn't contain a key (in this case, the name of the department),
            // then its value is 1 (adding 1 as the first count)
            // next time the loop encounters the same department name, the count increments by 1
            foreach (var employee in employees)
            {
                if (!departmentCounts.ContainsKey(employee.Department))
                {
                    departmentCounts[employee.Department] = 1;
                }
                else
                {
                    departmentCounts[employee.Department]++;
                }
            }

            // After the first loop is finished, another loop starts:
            // it iterates over each 'department' and prints out its key and value
            // The result looks something like: "Department: Engineering, Count: 500"
            foreach (var department in departmentCounts)
            {
                Console.WriteLine($"Department: {department.Key}, Count: {department.Value}");
            }
        }
    }
}
