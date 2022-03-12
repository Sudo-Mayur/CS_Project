using System.Text.Json;
using Clinic_Managment_System.Models;
using Clinic_Managment_System.DataAccess;



IDataAccess<PatientInfo, int> dataAccess = new PatientDataAccess();
IDataAccess1<PatientInfo1, int> dataAccess1 = new PatientNextAp();

int a = 0;

do
{
    Console.WriteLine("Enter Operation that You want to perform \n"
                          + "1.Get Patient Information\n" +
                          "2.Add new Patient information\n"+
                          "3.Find patient by PatientNo\n"+
                          "4.Exit\n"+
                          "5.Clear Screen");
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            var NewPatient = await dataAccess.GetAsync();
            Console.WriteLine($"List of Patient:{JsonSerializer.Serialize(NewPatient)}");
            foreach (var item in NewPatient)
            {
                Console.WriteLine($"{item.PatientRegNo} {item.PatName}  {item.PatAddress} {item.MobileNo} {item.Age} {item.Wieght} {item.PatBp} {item.Cholestrol}  {item.Sugur} {item.Medicines} {item.FirstApdate} {item.FirstApfees}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 2:
            Console.WriteLine("Add new Record");
            var patient = new PatientInfo();

            Console.WriteLine("enter Patient name");
            patient.PatName = Console.ReadLine();

            Console.WriteLine("enter Address");
            patient.PatAddress = Console.ReadLine();

            Console.WriteLine("enter MobileNo");
            patient.MobileNo = Console.ReadLine();

            Console.WriteLine("enter Age");
            patient.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Wieght");
            patient.Wieght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter PatBp");
            patient.PatBp = Console.ReadLine();

            Console.WriteLine("enter Cholestrol");
            patient.Cholestrol = Console.ReadLine();

            Console.WriteLine("enter Sugur");
            patient.Sugur = Console.ReadLine();

            Console.WriteLine("enter Medicines");
            patient.Medicines = Console.ReadLine();

            Console.WriteLine("enter FirstApdate");
            patient.FirstApdate = Console.ReadLine();

            Console.WriteLine("enter FirstApfees");
            patient.FirstApfees = Convert.ToInt32(Console.ReadLine());

            var CreatData = await dataAccess.CreatAsync(patient);
            break;

        case 3:
            Console.WriteLine("Enter PatientNo");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int num1);
            while (!IsNum1)
            {
                Console.WriteLine("Enter Valid Number");
                IsNum1 = int.TryParse(Console.ReadLine(), out num1);
            }
            var Pat = await dataAccess.GetbyId(num1);
            if (Pat != null)
            {
                Console.WriteLine($"{Pat.PatientRegNo} {Pat.PatName}  {Pat.PatAddress} {Pat.MobileNo} {Pat.Age} {Pat.Wieght} {Pat.PatBp} {Pat.Cholestrol}  {Pat.Sugur} {Pat.Medicines} {Pat.FirstApdate} {Pat.FirstApfees}");
            }
            else
            {
                Console.WriteLine("Patient Not Found");
            }
            break;


        case 4:
            a++;
            break;

        case 5:
            Console.Clear();
            break;
    }
} while (a == 0);

Console.ReadLine();

//PatientRegNo
//{ get; set; }
//public string PatName { get; set; } = null!;
//public string PatAddress { get; set; } = null!;
//public string? MobileNo { get; set; }
//public int? Age { get; set; }
//public int Wieght { get; set; }
//public string? PatBp { get; set; }
//public string? Cholestrol { get; set;}
//public string? Sugur { get; set; }
//public string Medicines { get; set; } = null!;
//public string FirstApdate { get; set; } = null!;
//public int FirstApfees { get; set;}

