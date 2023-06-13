# Console_App_CSV_Parser
Using Visual Studio and C#, create a console-based app that will create a dictionary object that returns in the console the counts of employees in each department. 
(For example: Department: Corporate, Count: 500)

1. Copied and pasted the given CSV file to the project folder and changed the `Copy to Output Directory property to Copy always`:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/d4214386-c0ea-444d-be7a-aad435521c1a)

This will copy this file to the output folder once I run the application. The application can read it from the output folder.

2. Created a model class `Employee.cs` to read the CSV file (15 fields/columns to read)
3. Inserted `CsvColumn` attributes since the first line in the CSV file are the field/column names
![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/66ebb745-dbee-41b2-91bc-f5c757baa460)






