# Console_App_CSV_Parser

## Using Visual Studio and C#, create a console-based app that will create a dictionary object that returns in the console the counts of employees in each department

1. Copied and pasted the given CSV file to the project folder and changed the `Copy to Output Directory property to Copy always`:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/d4214386-c0ea-444d-be7a-aad435521c1a)


2. Created a class `Employee.cs` to read the CSV file (15 fields/columns to read) and inserted `CsvColumn` attributes since the first line in the CSV file are the field/column names:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/8bf83e70-e636-4c57-acca-142fc625f860)


3. Defined a method called `ReadCsvFile()` in `Program.cs`:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/bb39d74f-1765-495a-b374-5e71ccf62122)


4. Calling `ReadCsvFile()` inside the `Main` method and `Console.ReadKey()` to see the output on the console:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/8ac2761c-56e7-49dc-bde5-d01e50d2e042)


5. Output on the console:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/caa8473c-adf8-416c-843f-68d4838f9295)


## Include any thoughts and or examples on how you might test this

- To see if the counts of employees get incremented correctly, I tried setting the breakpoint at the line 52:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/8f091813-2825-42c1-8933-60445241e845)


- If I run the app with the breakpoint at the line 52, the code should've completed its iteration over the first `employee` object which is this employee:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/e51b4635-8111-45c3-9c06-cd13f858b8b8)


- And if I actually run the app, we can find that that's the case and the engineering department has the count of 1:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/8d7100a7-c4a4-4df4-91c5-294c2ea66766)


- Now, I'd like to see if the count of engineering department gets incremented once it encounters the next employee whose department is also engineering. The next engineering employee in line is `Harper Dominguez`. 

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/bfe6a67b-28e9-4b5c-a7a3-426e7b06694c)


- And if I keep running the app, I can see that the department of engineering has the count of 2 at the employee `Harper Dominguez`:

![image](https://github.com/wonhee3472/Console_App_CSV_Parser/assets/56327729/b0703914-7a1e-4733-b53f-0592c11e9dc4)


