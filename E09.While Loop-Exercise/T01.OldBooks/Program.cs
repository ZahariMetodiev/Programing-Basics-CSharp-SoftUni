using System;

namespace T01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favorityBook = Console.ReadLine();

            int counter = 0;
            string nextBook = Console.ReadLine();

            while (nextBook != "No More Books")
            {
                if (nextBook == favorityBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                counter++;
                nextBook = Console.ReadLine();
            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}
