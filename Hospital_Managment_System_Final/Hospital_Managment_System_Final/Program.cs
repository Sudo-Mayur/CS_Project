using Hospital_Managment_System_Final.Models;
using Hospital_Managment_System_Final.DataAccess;
using System.Text.Json;
using System.Text.RegularExpressions;

IDataAccess<PatientInfo, int> dataAccess = new PatientDataAccess();
IDataAccess1<DailyCollection, int> dataAccess1 = new DailyCollection1();

DailyCollection1 D = new DailyCollection1();

int a = 0;
do
{
    Console.WriteLine("********************WELCOME TO CLINIC MANAGEMENT SYSTEM********************\n" +
                          "Enter Operation that You want to perform \n" +
                          "1.Get All Patient Records \n" +
                          "2.Add new Patient information\n" +
                          "3.Find patient Record by PatientNo\n"+
                          "4.Update patient Record\n" +
                          "5.Delete patient Record \n"+
                          "6.DailyCollection DateWise\n" +
                          "7.View All Collection Records\n" +
                          "8.Clear Screen\n"+
                          "9.Exit");
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            var NewPatient = await dataAccess.GetAsync();
            Console.WriteLine("RecordNo PatientNo Name Address MobileNo Age Wieght PatBp CholeHdl CholeLdl Sugurfast SugurPotFast Medicines date Fees");
            foreach (var item in NewPatient)
            {
                Console.WriteLine($"{item.RecordNo} {item.PatientRegNo}  {item.PatName} {item.PatAddress} {item.MobileNo} {item.Age} {item.Wieght} {item.PatBp}  {item.CholestrolHdl} {item.CholestrolLdl} {item.Sugurfast} {item.SugurPotFast} {item.Medicines} {item.Apdate} {item.Fees}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 2:
            Console.WriteLine("Add new Record");
            var patient = new PatientInfo();
            var record = new DailyCollection();

            Console.WriteLine("enter PatientRegNo");
            patient.PatientRegNo = IsPositiveNumber();
            record.PatientRegNo = patient.PatientRegNo;

            Console.WriteLine("enter PatName");
            patient.PatName = IsCorrectName();

            Console.WriteLine("enter PatAddress");
            patient.PatAddress = Console.ReadLine();

            Console.WriteLine("enter MobileNo");
            patient.MobileNo = IsCorrectMobileNum();

            Console.WriteLine("enter Age");
            patient.Age = IsPositiveNumber();

            Console.WriteLine("enter Wieght");
            patient.Wieght = IsPositiveNumber();

            Console.WriteLine("enter PatBp");
            patient.PatBp = IsPositiveNumber();

            Console.WriteLine("enter CholestrolHdl");
            patient.CholestrolHdl = IsPositiveNumber();

            Console.WriteLine("enter CholestrolLdl");
            patient.CholestrolLdl = IsPositiveNumber();

            Console.WriteLine("enter Sugurfast");
            patient.Sugurfast = IsPositiveNumber();

            Console.WriteLine("enter SugurPotFast");
            patient.SugurPotFast = IsPositiveNumber();

            Console.WriteLine("enter Medicines");
            patient.Medicines = Console.ReadLine();

            Console.WriteLine("enter Apdate Like 2022-03-11 in this format");
            patient.Apdate = Convert.ToDateTime(Console.ReadLine());
            record.Apdate = patient.Apdate;
            //2022-02-02

            Console.WriteLine("enter Apfees");
            patient.Fees = IsPositiveNumber();
            record.Fees = patient.Fees;

            var CreatData = await dataAccess.CreatAsync(patient);
            var Creatdata1 = await dataAccess1.CreatAsync(record);
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
                Console.WriteLine($"{Pat.RecordNo} {Pat.PatientRegNo}  {Pat.PatName} {Pat.PatAddress} {Pat.MobileNo} {Pat.Age} {Pat.Wieght} {Pat.PatBp}  {Pat.CholestrolHdl} {Pat.CholestrolLdl} {Pat.Sugurfast} {Pat.SugurPotFast} {Pat.Medicines} {Pat.Apdate} {Pat.Fees}");
            }
            else
            {
                Console.WriteLine("Patient Not Found");
            }
            break;

        case 4:
            Console.WriteLine("Update Record");
            var patient1 = new PatientInfo();
            var Record1 = new DailyCollection();

            Console.WriteLine("Enter RecordNo");
            Record1.RecordNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter PatientRegNo");
            patient1.PatientRegNo = IsPositiveNumber();
            Record1.PatientRegNo = patient1.PatientRegNo;

            Console.WriteLine("enter PatName");
            patient1.PatName = IsCorrectName();

            Console.WriteLine("enter PatAddress");
            patient1.PatAddress = Console.ReadLine();

            Console.WriteLine("enter MobileNo");
            patient1.MobileNo = IsCorrectMobileNum();

            Console.WriteLine("enter Age");
            patient1.Age = IsPositiveNumber();

            Console.WriteLine("enter Wieght");
            patient1.Wieght = IsPositiveNumber();

            Console.WriteLine("enter PatBp");
            patient1.PatBp = IsPositiveNumber();

            Console.WriteLine("enter CholestrolHdl");
            patient1.CholestrolHdl = IsPositiveNumber();

            Console.WriteLine("enter CholestrolLdl");
            patient1.CholestrolLdl = IsPositiveNumber();

            Console.WriteLine("enter Sugurfast");
            patient1.Sugurfast = IsPositiveNumber();

            Console.WriteLine("enter SugurPotFast");
            patient1.SugurPotFast = IsPositiveNumber();

            Console.WriteLine("enter Medicines");
            patient1.Medicines = Console.ReadLine();

            Console.WriteLine("enter Apdate  Like 2022-03-11 in this format");
            patient1.Apdate = Convert.ToDateTime(Console.ReadLine());
            Record1.Apdate = patient1.Apdate;

            Console.WriteLine("enter fees");
            int fee = Convert.ToInt32(Console.ReadLine());
            patient1.Fees = fee - fee * 0.15;
            Record1.Fees = patient1.Fees;

            var UpdatePatInfo = await dataAccess.UpdateAsync((int)patient1.PatientRegNo, patient1);
            var UpdatePatInfo1 = await dataAccess1.UpdateAsync((int)Record1.RecordNo, Record1);
            break;

        case 5:
            Console.WriteLine("enter RecordNo for delete");
            int deleteRecord = Convert.ToInt32(Console.ReadLine());
            var DeleteRecord = await dataAccess1.DeleteAsync(deleteRecord);
            var DeletePat = await dataAccess.DeleteAsync(deleteRecord);          
            break;

        case 6:
            D.dailyCollection();
            break;

        case 7:
            var AllRecords = await dataAccess1.GetAsync();
            foreach (var item in AllRecords)
            {
                Console.WriteLine($"{item.RecordNo} {item.PatientRegNo}  {item.Apdate} {item.Fees}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 8:
            Console.Clear();
            break;

        case 9:
            a++;
            break;
           
        default:
            Console.WriteLine("Wrong Choice");
            break;
    }
} while (a == 0);



//Validations
static int IsPositiveNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int d = 0;
    do
    {
        try
        {
            if (number >= 0)
            {
                d = 0;
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
                number = Convert.ToInt32(Console.ReadLine());
                d++;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (d > 0);
    return number;
}


static double IsPositiveDouble()
{
    double number = Convert.ToDouble(Console.ReadLine());
    int d = 0;
    do
    {
        try
        {
            if (number >= 0)
            {
                d = 0;
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
                number = Convert.ToDouble(Console.ReadLine());
                d++;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (d > 0);
    return number;
}

static string IsCorrectName()
{
    string PatientName = Console.ReadLine();
    Regex re = new Regex("[A-Z][A-Za-z ]+[A-Za-z]$");
    int g = 0;
    do
    {
        if (re.IsMatch(PatientName))
        {
            g = 0;
        }
        else
        {
            Console.WriteLine("Please enter correct name");
            PatientName = Console.ReadLine();
            g++;
        }
    } while (g > 0);
    return PatientName;
}

static string IsCorrectMobileNum()
{
    string Mob = Console.ReadLine();
    Regex re = new Regex(@"^[0-9]{10}$");
    int g = 0;
    do
    {
        if (re.IsMatch(Mob))
        {
            g = 0;
        }
        else
        {
            Console.WriteLine("Please enter correct Mobile Number");
            Mob = Console.ReadLine();
            g++;
        }
    } while (g > 0);
    return Mob;
}


