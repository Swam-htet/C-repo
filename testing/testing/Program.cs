using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent one = new Parent("Parent One", 50);

            Console.WriteLine("This is parente name {0} and this is parent age{1}",one.name,one.age);

            

            Console.ReadLine();
        }
    }
}
