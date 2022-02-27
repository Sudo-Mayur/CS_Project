using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Assignment_7
{
    internal class DirectoryOperations
    {
        public void CreateDirectoiry(string FileName)
        {
            if (!Directory.Exists(FileName))
            {
                Directory.CreateDirectory(FileName);
            }
            else
            {
                Console.WriteLine($"Directory {FileName} is already present");
            }
        }
    }
}
