using System;

namespace T02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string currentPassword = Console.ReadLine();

            while (currentPassword != password)
            {
                currentPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
