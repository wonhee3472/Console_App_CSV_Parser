using System;
// Installed LINQtoCSV library to read a CSV file
using LINQtoCSV;

namespace CSVDemo
{
    [Serializable]
    public class Employee
    {
        [CsvColumn(Name = "Employee ID")]
        public string EmployeeID { get; set; }
        
        [CsvColumn(Name = "Full Name")]
        public string FullName { get; set; }

        [CsvColumn(Name = "Job Title")]
        public string JobTitle { get; set; }

        [CsvColumn(Name = "Department")]
        public string Department { get; set; }

        [CsvColumn(Name = "Business Unit")]
        public string BusinessUnit { get; set; }

        [CsvColumn(Name = "Gender")]
        public string Gender { get; set; }

        [CsvColumn(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [CsvColumn(Name = "Age")]
        public string Age { get; set; }

        [CsvColumn(Name = "Hire Date")]
        public string HireDate { get; set; }

        [CsvColumn(Name = "Annual Salary")]
        public string AnnualSalary { get; set; }

        [CsvColumn(Name = "Bonus %")]
        public string Bonus { get; set; }

        [CsvColumn(Name = "Country")]
        public string Country { get; set; }

        [CsvColumn(Name = "City")]
        public string City { get; set; }

        [CsvColumn(Name = "Exit Date")]
        public string ExitDate { get; set; }
        



    }
}
