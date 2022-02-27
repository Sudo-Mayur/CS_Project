using System;

namespace Directory_Assignment_7
{
    internal class Program
    {
        static DirectoryOperations dirOp;
        static void Main(string[] args)
        {
            dirOp = new DirectoryOperations();
            dirOp.CreateDirectoiry("Program");
        }
    }
}
