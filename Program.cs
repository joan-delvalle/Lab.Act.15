using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Act._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a numeric grade (0-100):");

                string input = Console.ReadLine();
                int grade;

                if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                {
                    char letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = 'C';
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = 'D';
                    }
                    else
                    {
                        letterGrade = 'F';
                    }

                    Console.WriteLine($"Letter Grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                }
            
        }
    }

}

