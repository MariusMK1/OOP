using System;
using Shop.ConsoleApp.Services;

namespace Shop.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ApplicationService = new ApplicationService();

            while (true)
            {
                Console.WriteLine("Enter your comand");
                string command = Console.ReadLine();
                ApplicationService.Process(command);
            }
        }
    }
}
