using System;

namespace T06TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            double point = 0;
            string powerfulWord = "";

            while (word != "End of words")
            {
                double currPoint = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    currPoint += word[i];
                }
                switch (word[0])
                {
                    case 'a':    
                    case 'e':    
                    case 'i':    
                    case 'o':    
                    case 'u':    
                    case 'y':    
                    case 'A':    
                    case 'E':    
                    case 'I':    
                    case 'O':    
                    case 'U':    
                    case 'Y':
                        currPoint *= word.Length;
                        break;
                    default:
                        currPoint = Math.Floor((double)currPoint / word.Length);
                        break;
                }

                if (currPoint > point)
                {
                    point = currPoint;
                    powerfulWord = word;
                }
                word = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {powerfulWord} - {point}");
        }
    }
}
