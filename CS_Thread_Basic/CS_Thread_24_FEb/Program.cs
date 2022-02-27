using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Thread_24_FEb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreData data = new StoreData();
            //data.WriteDataToFile();
            //data.WriteDataToDB();

            Thread T1 = new Thread(() => data.WriteDataToFile());
            Thread T2 = new Thread(() => data.WriteDataToDB());
            T1.Start();
            T2.Start();

            Console.ReadLine();
        }
    }
}
