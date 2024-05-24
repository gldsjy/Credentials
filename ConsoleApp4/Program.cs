using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] email = {"user1@gmail.com",
                              "user2@gmail.com",
                              "user3@gmail.com",
                              "user4@gmail.com",
                              "user5@gmail.com" };

            string[] username = {"user1",
                              "user2",
                              "user3",
                              "user4",
                              "user5" };

            string[] password = {"user1pass",
                              "user2pass",
                              "user3pass",
                              "user4pass",
                              "user5pass" };

            Console.Write("Index   : ");
            int i = Convert.ToInt32(Console.ReadLine());  
           
            Console.WriteLine("Email   : " + email[i]);
            Console.WriteLine("username: " + username[i]);
            Console.WriteLine("Password: " + password[i]);

            Console.ReadKey();
        }
    }
}
