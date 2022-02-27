using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employee_Salary_Slip
{
    internal class FileOperations
    {
        DateTime dateTime = DateTime.Now;
        public void fileCreate(Employee emp, double HRA, double TA, double DA, double gross,double anualGrossSalary, double tax, int monthlyNetSalary)
        {
            string path = @"C:\Users\Coditas\Desktop\Dotnet Training Assignments and mini projects\Employee_Salary_Slip_6";
            string filePath = $"{path}\\Salary-for-{dateTime.ToString("Y")} {emp.EmpNo}";
            //if (File.Exists(filePath))
            //{

            //    Console.WriteLine($"Specified File {filePath} is Already exists");
            //}
            //else
            //{
            //Create a File

            //writeData(filePath, emp, HRA, TA, DA, gross, tax, netSalary);

            FileStream fs = File.Create(filePath);
            byte[] content = new UTF8Encoding(true).GetBytes(
                           $"-------------------------Salary Slip--------------------------\n" +
                           $"| EmpNo:    {emp.EmpNo}                 EmpName: {emp.EmpName}                |\n" +
                           $"| DeptName: {emp.DeptName}              Designation: {emp.Designation}            |\n" +
                           $"|____________________________________________________________|\n" +
                           $"|Income (Rs.)                  | Deduction (Rs.)             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|Basic Salary: {emp.Salary}            |                             |\n" +
                           $"|HRA: {HRA}                      |                             |\n" +
                           $"|TA: {TA}                      |                             |\n" +
                           $"|DA: {DA}                      |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|Gross: {gross}                 |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|AnualGross:{anualGrossSalary}            | Tax: {tax}                  |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|NetSalary: {monthlyNetSalary}              |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|NetSalary in Words:                                         |\n" +
                           $"--------------------------------------------------------------");


            fs.Write(content, 0, content.Length);
            fs.Close();
        }



        public void writeData(string filePath, Employee emp, double HRA, double TA, double DA, double gross, double anualGrossSalary, double tax, int monthlyNetSalary)
        {
            string content = $"-------------------------Salary Slip--------------------------\n" +
                               $"| EmpNo: {emp.EmpNo}            EmpName: {emp.EmpName}       |\n" +
                               $"| DeptName: {emp.DeptName}   Designation: {emp.Designation}  |\n" +
                               $"|____________________________________________________________|\n" +
                               $"|Income (Rs.)                  | Deduction (Rs.)             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Basic Salary: {emp.Salary}    |                             |\n" +
                               $"|HRA: {HRA}                    |                             |\n" +
                               $"|TA: {TA}                      |                             |\n" +
                               $"|DA: {DA}                      |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Gross: {gross}                |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|AnualGross:{anualGrossSalary} | Tax: {tax}                  |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary: {monthlyNetSalary} |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary in Words:                                         |\n" +
                               $"--------------------------------------------------------------";

            File.Create(filePath);
            File.WriteAllText(filePath, content);
            File.Delete(filePath);



        }
    }
}