using System;

namespace T02Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int untreatedPatients = 0;
            int treatedPatients = 0;

            for (int day = 1; day <= period; day++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (day % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    if (patients <= 8 )
                    {
                        treatedPatients += patients;
                    }
                    else
                    {
                        treatedPatients += 8;
                        untreatedPatients += patients - 8;
                    }
                }
                else
                {
                    if (patients <= 7)
                    {
                        treatedPatients += patients;
                    }
                    else
                    {
                        treatedPatients += 7;
                        untreatedPatients += patients - 7;
                    }
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
