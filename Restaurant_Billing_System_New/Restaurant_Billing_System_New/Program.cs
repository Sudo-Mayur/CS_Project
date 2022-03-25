using Restaurant_Billing_System_New.Models;
using Restaurant_Billing_System_New.DataAccess;
using System.Text.RegularExpressions;
//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models


restaurantContext ctx = new restaurantContext();
IDataAccessCustomorInfo<CustomorInfo, int> dataAccessCustomorInfo = new CustomorInfoAccess();
IDataAccessDishInfo<DishInfo, int> dataAccessDishInfo = new DishInfoAccess();
IDataAccessBill<Bill, int> dataAccessBill = new BillAccess();
IDataAccessDish<Dish, int> dataAccessDish = new DishAccess();
BillAccess newbill = new BillAccess();


int a = 0;
do
{
    Console.WriteLine();
    Console.WriteLine("***********WELCOME TO MAYUR RESTAURANT**********\n"+
                      "1.Creat Bill\n" +
                      "2.Show Bill on CustmerID\n" +
                      "3.SHow Bill on Bill Number\n" +
                      "4.Show Bill Table History\n" +
                      "5.DailyCollection on the basis of Date\n"+
                      "6.Clear Screen\n" +
                      "7.Exit\n");

    Console.WriteLine("Enter Your Choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Create New Bill");

            CustomorInfo custinfo = new CustomorInfo();
            Bill bill = new Bill();

            Console.WriteLine("Enter Name");
            custinfo.CustName = IsCorrectName();

            Console.WriteLine("Enter MobileNo");
            custinfo.MobileNo = IsCorrectMobileNum();

            var CreatData = await dataAccessCustomorInfo.CreatAsync(custinfo);

            Console.WriteLine("***************Dish Table****************");
            var DishTable = await dataAccessDish.GetAsync();
            Console.WriteLine("DishNo DishName        Rate");
            foreach (var item in DishTable)
            {
                Console.WriteLine($"{item.DishNo}\t {item.DishName}\t       {item.Rate}");
            }

            char ans;
            do
            {
                //DishInfo Dishinfo = new DishInfo();
                //Dishinfo.CustomorId = custinfo.CustomorId;
                //int x = 0;
                //do
                //{
                //    Console.WriteLine("Enter DishNo");
                //    int dish = Convert.ToInt32(Console.ReadLine());
                //    //dish = Dishinfo.DishNo;
                //    var dishNo = await dataAccessDishInfo.GetbyId(dish);
                //    if (dishNo == null)
                //    {
                //        Console.WriteLine("Please Enter Correct Dish Number Which is Available in Dish Table");
                //        x = 0;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Enter Quantity");
                //        Dishinfo.Quantity = IsPositiveNumber();
                //        Dishinfo.DishName = dishNo.DishName;
                //        Dishinfo.Rate = dishNo.Rate;
                //        Dishinfo.Amount = Dishinfo.Quantity * dishNo.Rate;
                //        x++;

                //    }

                //} while (x == 0);

                DishInfo Dishinfo = new DishInfo();
                Dishinfo.CustomorId = custinfo.CustomorId;

                int r = 0;
                do
                {
                    Console.WriteLine("Enter DishNo");
                    Dishinfo.DishNo = IsPositiveNumber();

                    if (Dishinfo.DishNo >= 1 && Dishinfo.DishNo <= 16)
                    {
                        Console.WriteLine("Enter Quantity");
                        Dishinfo.Quantity = IsPositiveNumber();

                        switch (Dishinfo.DishNo)
                        {
                            case 1:
                                Dishinfo.DishName = "Roti";
                                Dishinfo.Rate = 20;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 2:
                                Dishinfo.DishName = "Rice";
                                Dishinfo.Rate = 60;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 3:
                                Dishinfo.DishName = "Chapati";
                                Dishinfo.Rate = 10;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 4:
                                Dishinfo.DishName = "ChickenThali";
                                Dishinfo.Rate = 150;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 5:
                                Dishinfo.DishName = "ChickenTikka";
                                Dishinfo.Rate = 170;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 6:
                                Dishinfo.DishName = "ChickenChilli";
                                Dishinfo.Rate = 130;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;
                            case 7:
                                Dishinfo.DishName = "FishThali";
                                Dishinfo.Rate = 200;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 8:
                                Dishinfo.DishName = "VegThali";
                                Dishinfo.Rate = 100;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 9:
                                Dishinfo.DishName = "ShahiPanner";
                                Dishinfo.Rate = 120;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 10:
                                Dishinfo.DishName = "PaneerTikka";
                                Dishinfo.Rate = 150;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 11:
                                Dishinfo.DishName = "PannerPalak";
                                Dishinfo.Rate = 130;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 12:
                                Dishinfo.DishName = "FrideRice";
                                Dishinfo.Rate = 130;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;
                            case 13:
                                Dishinfo.DishName = "ChickenBiryani";
                                Dishinfo.Rate = 170;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 14:
                                Dishinfo.DishName = "ChickenLolliPop";
                                Dishinfo.Rate = 130;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 15:
                                Dishinfo.DishName = "VegBiryani";
                                Dishinfo.Rate = 120;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 16:
                                Dishinfo.DishName = "ChickenHandi";
                                Dishinfo.Rate = 350;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;

                            case 17:
                                Dishinfo.DishName = "Veg Maratha";
                                Dishinfo.Rate = 130;
                                Dishinfo.Amount = Dishinfo.Quantity * Dishinfo.Rate;
                                break;
                        }
                        r = 0;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Correct Dish Number Which is Available in Dish Table");
                        r++;
                    }
                } while (r != 0);


                var CreatData1 = await dataAccessDishInfo.CreatAsync(Dishinfo);
             Console.WriteLine("DO  you want to add Another Dish then Enter Y or y and to Stop adding Dish enter any key");
             ans = Convert.ToChar(Console.ReadLine());

            } while (ans == 'Y' || ans == 'y');

            bill.Date = Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"));   
            bill.CustomorId = custinfo.CustomorId;

            bill.CustName = custinfo.CustName;
            bill.MobileNo = custinfo.MobileNo;

            int tableNo = 0;
            do
            {
                Console.WriteLine("Enter Table Number Inbetween (1 to 10)");
                bill.TableNo = IsPositiveNumber();
                if (bill.TableNo >= 1 && bill.TableNo <= 10)
                {
                    bill.TableNo = bill.TableNo;
                    tableNo = 0;
                }
                else
                {
                    Console.WriteLine("Please enter table number between 1 to 10");
                    tableNo++;
                }
            } while (tableNo != 0);


            bill.SubTotal = ctx.DishInfos.Where(x => x.CustomorId == custinfo.CustomorId).Sum(x => x.Amount);

            bill.Tax = 5;
            bill.TotalBill = bill.SubTotal + (bill.SubTotal * 5 / 100);

            int M = 0;
            do
            {
                Console.WriteLine("Enter Payment Mode 1.cash 2.UPI 3.Card");
                int Mode = IsPositiveNumber();


                if (Mode == 1 || Mode == 2 || Mode == 3)
                {
                    switch (Mode)
                    {
                        case 1:
                            bill.PaymentMode = "Cash";
                            break;
                        case 2:
                            bill.PaymentMode = "UPI";
                            break;
                        case 3:
                            bill.PaymentMode = "Debit Card";
                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                    M = 0;

                }
                else
                {
                    Console.WriteLine("Please enter right choice");
                    M++;
                }
            } while (M > 0);



            var CreatData2 = await dataAccessBill.CreatAsync(bill);
            newbill.ShowTableDishInfo(custinfo.CustomorId);
            break;


        case 2:
            Console.WriteLine("enter CustomorID");
            int ID1 = IsPositiveNumber();
            var billnonew = await dataAccessCustomorInfo.GetbyId(ID1);
            if (billnonew != null)
            {
                newbill.ShowTableDishInfo(ID1);
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            break;

        case 3:
            Console.WriteLine("Enter Bill Number");
            int BillNo = IsPositiveNumber();
            var billtable = await dataAccessBill.GetbyId(BillNo);


            if (billtable != null)
            {
                Console.WriteLine("****************************************MAYUR RESTAURANT***************************************************");
                Console.WriteLine("Date                BillNo     CustomorId CustName  MobileNo    TableNo   SubTotal  Tax  TotalBill  PaymentMode");
                Console.WriteLine($"{billtable.Date}\t {billtable.BillNo}\t {billtable.CustomorId}\t{billtable.CustName}\t {billtable.MobileNo}\t {billtable.TableNo}\t {billtable.SubTotal}\t\t{billtable.Tax}\t{billtable.TotalBill}\t{billtable.PaymentMode}");
            }
            else
            {
                Console.WriteLine("Record Not Found...........");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            break;

        case 4:
            Console.WriteLine("*************************MAYUR RESTAURANT***********************************");
            Console.WriteLine("Date                BillNo     CustomorId CustName  MobileNo    TableNo   SubTotal  Tax  TotalBill  PaymentMode");
            var Bill = await dataAccessBill.GetAsync();
            foreach (var item in Bill)
            {
                Console.WriteLine($"{item.Date}\t {item.BillNo}\t {item.CustomorId}\t{item.CustName}\t {item.MobileNo}\t {item.TableNo}\t {item.SubTotal}\t\t{item.Tax}\t{item.TotalBill}\t{item.PaymentMode}");
            }
            break;

        case 5:
            newbill.DailyCollection();
            break;
           
        case 6:
            Console.Clear();
            break;
           
        case 7:
            a++;
            break;

        default:
            Console.WriteLine("wrong Choice");
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
    string Name = Console.ReadLine();
    Regex re = new Regex("^[a-zA-Z ]+$");
    int g = 0;
    do
    {
        if (re.IsMatch(Name))
        {
            g = 0;
        }
        else
        {
            Console.WriteLine("Please enter correct name");
            Name = Console.ReadLine();
            g++;
        }
    } while (g > 0);
    return Name;
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



