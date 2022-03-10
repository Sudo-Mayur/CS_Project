
using CS_Pattern_Matching;



List<object> objectist = new List<object>()
{
     new List<string>{ "Amitabh","Rushi","Sashi","Raj","Mayur"},
      new List<char>{ 'A', 'B', 'C', 'D','E'},
      new List<int> {90,80,70,60 },
      1.1,10.3,3.5,3.4,10.4,10.3,2.3,3.5,2.4,70.4,
       10,20,30,40,10,20,30,5,40,20,
       new List<Employee>() { new Employee() { EmpNo = 11, EmpName = "Tom", DeptName = "Sales", Salary=20000, Designation="Intern"},
       new Employee() { EmpNo = 12, EmpName = "Joan", DeptName = "HR",Salary=100000, Designation="Engineer" },
       new Employee() { EmpNo = 13, EmpName = "Fred", DeptName = "Accounting",Salary=25000, Designation="Operator" },
       new Employee() {EmpNo=2,EmpName ="Shreya",DeptName="CS",Salary=20000,Designation="Manager"},
       new Employee() {EmpNo =3,EmpName ="Jahanvi",DeptName="Account",Salary=30000, Designation="CEO"},
       new Employee(){EmpNo=4,EmpName ="Tejal", DeptName="HR",Salary=40000,Designation="Developer"},
       new Employee(){EmpNo=5,EmpName="Esha",DeptName="IT",Salary=50000,Designation ="Intern"},
       new Employee(){EmpNo=6,EmpName="Shrusti",DeptName="CS",Salary=60000,Designation="Manager"},
       new Employee(){EmpNo=7,EmpName="Amrita",DeptName="Account",Salary=70000,Designation="CEO" },
       new Employee(){EmpNo=8,EmpName="Sanjana",DeptName="HR",Salary=80000,Designation="Developer" },
       new Employee(){EmpNo=9,EmpName="Akansha",DeptName="IT",Salary=90000,Designation="Intern" },
       new Employee(){EmpNo=10,EmpName="Krutika",DeptName="IT",Salary=100000,Designation="CEO" },},
       new List<DateTime>{

       new DateTime(2012,1,1),
       new DateTime(2013,1,1),
       new DateTime(2014,1,1),
       new DateTime(2015,1,1),
       new DateTime(2016,1,1),
       new DateTime(2017,1,1),
       new DateTime(2018,1,1),
       new DateTime(2019,1,1),
       new DateTime(2020,1,1),
       new DateTime(2021,1,1),
       new DateTime(2022,1,1),
    }
};


Console.WriteLine();
ProcessCollection(objectist,out List<int> IntergerList,out List<string> stringList,out List<char>charList,out List<Employee> EmployeeList,out List<DateTime>DateTimeList);

Console.WriteLine();
foreach(var i in IntergerList)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine();

foreach(var i in stringList)
{
    Console.WriteLine(i);
}
Console.WriteLine();

foreach(var i in charList)
{
    Console.WriteLine(i);
}
Console.WriteLine();

foreach(Employee item in EmployeeList)
{
    Console.WriteLine($"{item.EmpNo} {item.EmpName} {item.DeptName} {item.Salary} {item.Designation}");
}
Console.WriteLine();

foreach(var item in DateTimeList)
{
    Console.WriteLine(item);
}
Console.ReadLine();
 

static void ProcessCollection( List<object> values,out List<int> IntergerList,out List<string> stringList,out List<char>charList,out List<Employee>EmployeeList,out List<DateTime>DateTimeList)
{
    IntergerList = new List<int>();
    stringList = new List<string>();
    charList = new List<char>();
    EmployeeList = new List<Employee>();
    DateTimeList= new List<DateTime>();
    
    Console.WriteLine("Pocessing a collection");


    //string concatStringList = string.Empty;
   
   
    foreach (object val in values)
    {
        switch (val)
        {
            case IEnumerable<int> intList:
                foreach (var item in intList)
                {
                    IntergerList.Add(item);

                }
                break;

            case IEnumerable<string> strList:
                foreach (var item in strList)
                {
                    stringList.Add(item);
                }
               
                break;

            case IEnumerable<char> charList1:
                foreach (var item in charList1)
                {
                   charList.Add(item);

                }
                break;

            case int v:
                Console.WriteLine($"Integers {v} ");
                break;
           
            case double d:
                Console.WriteLine($"Double {d}");
                break;

            case IEnumerable<Employee> EmpList:

                foreach (var item in EmpList)
                {
                    EmployeeList.Add(item);
                }
                break;
            case IEnumerable<DateTime> dateTime:

                foreach (var item in dateTime)
                {
                    DateTimeList.Add(item);
                }
                break;
                

        }
    }
}