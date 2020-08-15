// SE145 / Lab4 / Part 1 / Walid AMAR / Week 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE245_LAB4_wamar_Part1
{
    class Program
    {
        // Pause function
        static void Pause()
        {
            Console.WriteLine(" Press any key to exit. ");
            Console.ReadKey();
        }
        //Main Loop
        static void Main(string[] args)
        {
            string FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email;

            // User's input
            Console.Write("     Hello !");
            Console.Write("\n \n     Please enter the following informations :");
            Console.Write("\n \n First Name : ");
            FName = Console.ReadLine();
            Console.Write(" Middle Name : ");
            MName = Console.ReadLine();
            Console.Write(" Last Name : ");
            LName = Console.ReadLine();
            Console.Write(" Street 1 : ");
            Street1 = Console.ReadLine();
            Console.Write(" Street 2 : ");
            Street2 = Console.ReadLine();
            Console.Write(" City : ");
            City = Console.ReadLine();
            Console.Write(" State : ");
            State = Console.ReadLine();
            Console.Write(" Zip : ");
            Zip = Console.ReadLine();
            Console.Write(" Phone Number : ");
            Phone = Console.ReadLine();
            Console.Write(" Email : ");
            Email = Console.ReadLine();

            //Output
            Console.WriteLine("\n \n Here is your person's information : ");
            Console.WriteLine(" First Name : " + FName);
            Console.WriteLine(" Middle Name : " + MName);
            Console.WriteLine(" Last Name : " + LName);
            Console.WriteLine(" Street 1 : " + Street1);
            Console.WriteLine(" Street 2 : " + Street2);
            Console.WriteLine(" City : " + City);
            Console.WriteLine(" State : " + State);
            Console.WriteLine(" Zip : " + Zip);
            Console.WriteLine(" Phone : " + Phone);
            Console.WriteLine(" Email : " + Email);
            Pause();

        }
    }
}
