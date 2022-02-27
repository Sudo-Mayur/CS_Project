using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            List<Employee> Employees = new List<Employee>
{
new Employee {EmpID=1, EmpName="Mayur", DeptName="HR", Designation= "Manager", Empsalary=20000},
new Employee {EmpID=2, EmpName="Mandar", DeptName="RND", Designation= "CEO", Empsalary=12000},
new Employee {EmpID=3, EmpName="Sam", DeptName="Sales", Designation= "Manager", Empsalary=30000},
new Employee {EmpID=4, EmpName="Manoj", DeptName="Marketing", Designation= "Intern", Empsalary=18000},
new Employee {EmpID=5, EmpName="ankit", DeptName="Operations", Designation= "Admin", Empsalary=25000},
new Employee {EmpID=6, EmpName="samir", DeptName="Purchase", Designation= "CTO", Empsalary=27000},
new Employee {EmpID=7, EmpName="yash", DeptName="Finance", Designation= "Manager", Empsalary=85000},
new Employee {EmpID=8, EmpName="Suyog", DeptName="Management", Designation= "Director", Empsalary=35000},
new Employee {EmpID=9, EmpName="Ram", DeptName="HR", Designation= "Intern", Empsalary=75000},
new Employee {EmpID=10, EmpName="Tejas", DeptName="Sales", Designation= "Manager", Empsalary=80000},
new Employee {EmpID=11, EmpName="Shubham", DeptName="Marketing", Designation= "Director", Empsalary=50000},
new Employee {EmpID=12, EmpName="Rakesh", DeptName="Purchase", Designation= "Manager", Empsalary=57000},
new Employee {EmpID=13, EmpName="Pavan", DeptName="Finance", Designation= "CEO", Empsalary=10000},
new Employee {EmpID=14, EmpName="karam", DeptName="HR", Designation= "Director", Empsalary=16000},
new Employee {EmpID=15, EmpName="Ani", DeptName="Sales", Designation= "Manager", Empsalary=11000},
new Employee {EmpID=16, EmpName="Ankita", DeptName="Finance", Designation= "Director", Empsalary=10000},
new Employee {EmpID=17, EmpName="Rutuja", DeptName="RND", Designation= "CEO", Empsalary=10000},
new Employee {EmpID=18, EmpName="Saif", DeptName="Management", Designation= "Manager", Empsalary=10000},
new Employee {EmpID=19, EmpName="Samar", DeptName="Purchase", Designation= "Director", Empsalary=10000},
new Employee {EmpID=20, EmpName="Shyam", DeptName="Operations", Designation= "Manager", Empsalary=65000},
new Employee {EmpID=21, EmpName="Sunil", DeptName="HR", Designation= "CTO", Empsalary=55000},
new Employee {EmpID=22, EmpName="Mahadev", DeptName="Sales", Designation= "Admin", Empsalary=13000},
new Employee {EmpID=23, EmpName="Rahul", DeptName="RND", Designation= "Director", Empsalary=65000},
new Employee {EmpID=24, EmpName="Laxman", DeptName="HR", Designation= "Manager", Empsalary=20000},
new Employee {EmpID=25, EmpName="Mandar", DeptName="RND", Designation= "CEO", Empsalary=12000},
new Employee {EmpID=26, EmpName="Sam", DeptName="Sales", Designation= "Manager", Empsalary=30000},
new Employee {EmpID=27, EmpName="Manoj", DeptName="Marketing", Designation= "Intern", Empsalary=18000},
new Employee {EmpID=28, EmpName="ankit", DeptName="Operations", Designation= "Admin", Empsalary=25000},
new Employee {EmpID=29, EmpName="samir", DeptName="Purchase", Designation= "CTO", Empsalary=27000},
new Employee {EmpID=30, EmpName="yash", DeptName="Finance", Designation= "Manager", Empsalary=85000},
new Employee {EmpID=31, EmpName="Suyog", DeptName="Management", Designation= "Director", Empsalary=35000},
new Employee {EmpID=32, EmpName="Ram", DeptName="HR", Designation= "Intern", Empsalary=75000},
new Employee {EmpID=33, EmpName="Tejas", DeptName="Sales", Designation= "Manager", Empsalary=80000},
new Employee {EmpID=34, EmpName="Shubham", DeptName="Marketing", Designation= "Director", Empsalary=50000},
new Employee {EmpID=35, EmpName="Rakesh", DeptName="Purchase", Designation= "Manager", Empsalary=57000},
new Employee {EmpID=36, EmpName="Pavan", DeptName="Finance", Designation= "CEO", Empsalary=10000},
new Employee {EmpID=37, EmpName="karam", DeptName="HR", Designation= "Director", Empsalary=16000},
new Employee {EmpID=38, EmpName="Tamanna", DeptName="Sales", Designation= "Manager", Empsalary=11000},
new Employee {EmpID=39, EmpName="Anita", DeptName="Finance", Designation= "Director", Empsalary=10000},
new Employee {EmpID=40, EmpName="Rutuja", DeptName="RND", Designation= "CEO", Empsalary=10000},
new Employee {EmpID=41, EmpName="Saif", DeptName="Management", Designation= "Manager", Empsalary=10000},
new Employee {EmpID=42, EmpName="Samar", DeptName="Purchase", Designation= "Director", Empsalary=10000},
new Employee {EmpID=43, EmpName="Shyam", DeptName="Operations", Designation= "Manager", Empsalary=65000},
new Employee {EmpID=44, EmpName="Mayuri", DeptName="HR", Designation= "CTO", Empsalary=55000},
new Employee {EmpID=45, EmpName="Mahadev", DeptName="Sales", Designation= "Admin", Empsalary=13000},
new Employee {EmpID=46, EmpName="Rahul", DeptName="RND", Designation= "Director", Empsalary=65000},
new Employee {EmpID=47, EmpName="Suyog", DeptName="Management", Designation= "Director", Empsalary=35000},
new Employee {EmpID=48, EmpName="Ram", DeptName="HR", Designation= "Intern", Empsalary=75000},
new Employee {EmpID=49, EmpName="Taimur", DeptName="Sales", Designation= "Manager", Empsalary=80000},
new Employee {EmpID=50, EmpName="Shubham", DeptName="Marketing", Designation= "Director", Empsalary=50000},

};

            //Print All Employees In Ascending Order of the EmpName
            Console.WriteLine("Name of Employees in ascending order:");
          
                var EmpQuery1 =
                from emp in Employees
                orderby emp.EmpName ascending
                select emp;

                foreach (var item in EmpQuery1)
                {
                    Console.WriteLine(item.EmpName);
                }
            
            Console.WriteLine("------------------------------------------------------------------------");


            //Print All EMployees Having Salary in Range 25000 to 75000
            Console.WriteLine("Name of Employees Having Salary range between 25k to 75k");
            var EmpQuery2 =
            from emp in Employees
            where emp.Empsalary >=25000 && emp.Empsalary <=75000
            select emp;
           
            foreach (var item in EmpQuery2)
            {
                Console.WriteLine(item.EmpName);
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print All Employees Group by the DeptName, and also display Employee Count for each DeptName
            Console.WriteLine("Print All Employees Group by the DeptName, and also display Employee Count for each DeptName");
            var EmpQuery3 =
                from emp in Employees
                group emp by emp.DeptName;
               
            foreach(var item in EmpQuery3)
            {
                Console.WriteLine($"{item.Key},{item.Count()}");
                foreach(var item2 in item)
                {
                    Console.WriteLine($" { item2.EmpName}");
                }
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print Employees by Designation Group
            Console.WriteLine("Print Employees by Designation Group");
            var EmpQuery4 =
                 from emp in Employees
                 group emp by emp.Designation;
            foreach (var item in EmpQuery4)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine($" { item2.EmpName} {item2.Empsalary}");
                }
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Find out Sum of Salary for Employess per DeptName
            Console.WriteLine("Find out Sum of Salary for Employess per DeptName");
            var EmpQuery7 = from emp in Employees
                            group emp by emp.DeptName;
            foreach (var item in EmpQuery7)
            {
                Console.WriteLine($"{item.Key}, {item.Sum(x => x.Empsalary)}");
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print Employee with Max Salary Per DeptName
            Console.WriteLine("Print Employee with Max Salary Per DeptName");
            var EmpQuery5 = from emp in Employees
                            group emp by emp.DeptName;
            foreach( var item in EmpQuery5)
            {
                Console.WriteLine($"{item.Key}, {item.Max(x=>x.Empsalary)}");
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print Employee with Min Salary Per DeptName
            Console.WriteLine("Print Employee with Min Salary Per DeptName");
            var EmpQuery6 = from emp in Employees
                            group emp by emp.DeptName;
            foreach (var item in EmpQuery5)
            {
                Console.WriteLine($"{item.Key}, {item.Min(x => x.Empsalary)}");
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print Average Salary Per DeptName
            Console.WriteLine("Print Average Salary Per DeptName");
            var EmpQuery8 = from emp in Employees
                            group emp by emp.DeptName;
            foreach (var item in EmpQuery8)
            {
                Console.WriteLine($"{item.Key}, {item.Average(x => x.Empsalary)}");
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Display All EMployees those are Managers, Directors only
            Console.WriteLine("Display All EMployees those are Managers, Directors only");
            var EmpQuery9 = from emp in Employees
                            where emp.Designation == "Manager" || emp.Designation=="Director"
                            select emp;
            foreach (var item in EmpQuery9)
            {
                Console.WriteLine(item.EmpName);
            }
            Console.WriteLine("------------------------------------------------------------------------");


            //Print Employee with Second Max Salary Per DeptName
            Console.WriteLine("Print Employee with Second Max Salary Per DeptName");
            var ref1 = from e in Employees
                            group e by e.DeptName into deptgroup
                            select new
                            {
                                DeptName = deptgroup.Key,
                                SecondmaxSalary = deptgroup.OrderByDescending(x => x.Empsalary).Select(x => x.Empsalary).Distinct().Take(2).Skip(2 - 1).FirstOrDefault()
                            }; ;
                foreach (var record in ref1)
                {
                    Console.WriteLine($"{record.DeptName}={record.SecondmaxSalary}");
                }
            

            //Console.WriteLine("Print Employee with Second MAx Salary Per DeptName");
            //var EmpQuery10 = from emp in Employees
            //                 group emp by emp.DeptName;
           
            //foreach (var item in EmpQuery10)
            //{
            //    var emp1 = Employees.OrderByDescending(x => x.Empsalary).Skip(1).First();
            //    Console.WriteLine($"{item.Key}, {emp1.EmpName},{emp1.Empsalary}");
            //}
            Console.WriteLine("------------------------------------------------------------------------");



            //Print Employee with Second Max Salary
            Console.WriteLine("Print Employee with Second Max Salary");
            var emp3 = Employees.OrderByDescending(x => x.Empsalary)
                .Skip(1).First();
            Console.WriteLine($"{emp3.EmpName},{emp3.Empsalary}");

            Console.WriteLine("------------------------------------------------------------------------");


            // Calculate Tax for Each Employee as followa
            //Salary from >= 20K to <= 40K is 0.05 %
            //Salary from > 40K to <= 60K is 0.1 %
            //Salary < 20K is 0
            //Salary > 60K is 0.15 %
            //Print All these Salaries DeptName Wise

            Console.WriteLine("List of employee with thair name and tax");
            var EmpQuery11 = from emp1 in Employees
                             where emp1.Empsalary>=20000 && emp1.Empsalary<=40000
                             select emp1;
            //var deptSal = Employees.GroupBy(e => e.DeptName);
            foreach (var item in EmpQuery11)
            {
                Console.WriteLine($"{item.EmpName} tax on salary is {item.Empsalary*0.0005} and department is {item.DeptName}");
            }
            Console.WriteLine("---------------------------------------------------------------------------");


            var EmpQuery12 = from emp1 in Employees
                             where emp1.Empsalary >= 40000 && emp1.Empsalary <= 60000
                             select emp1;
           
            foreach (var item in EmpQuery12)
            {
                Console.WriteLine($"{item.EmpName} tax on salary is {item.Empsalary * 0.001} and department is {item.DeptName}");
            }


            Console.WriteLine("---------------------------------------------------------------------------");
            var EmpQuery13 = from emp1 in Employees
                             where emp1.Empsalary < 20000
                             select emp1;
     
            foreach (var item in EmpQuery13)
            {
                Console.WriteLine($"{item.EmpName} tax on salary is 0 cause salary is less than 20000");
            }


            Console.WriteLine("---------------------------------------------------------------------------");
            var EmpQuery14 = from emp1 in Employees
                             where emp1.Empsalary > 60000
                             select emp1;
            foreach (var item in EmpQuery14)
            {
                Console.WriteLine($"{item.EmpName} tax on salary {item.Empsalary * 0.015} and department is {item.DeptName}");
            }



        }
    }

    
   
}

    
        
    

