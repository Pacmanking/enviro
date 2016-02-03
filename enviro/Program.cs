using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System_Info
{
    class MyClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to username: {0} ", Environment.UserName);
            Console.WriteLine("Machine Name: {0}", Environment.MachineName.ToString());
            Console.WriteLine("OS version: {0} ", Environment.OSVersion.ToString());
            Console.WriteLine("Proccesors: {0} ", Environment.ProcessorCount);
            Console.WriteLine("Network Domain: {0}", Environment.UserDomainName.ToString());

            Console.WriteLine("Press enter to leave");

            Console.ReadLine();
        }
    }
}
