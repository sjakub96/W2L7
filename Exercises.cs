using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L7
{
    public class Exercises
    {
        public void FirstExercise()
        {
            int a = 5;
            int b = 5;

            if(a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void SecondExercise()
        {
            Console.WriteLine("Please enter your number (even or odd): ");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void ThirdExercise()
        {
            Console.WriteLine("Please enter your number(positive or negative): ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else if (userInput < 0)
            {
                Console.WriteLine("Your number is negative");
            }
            else
            {
                Console.WriteLine("This is 0");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();
        }

        public void FourthExercise()
        {
            Console.WriteLine("Please enter your year: ");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput % 4 == 0)
            {
                if(userInput % 100 == 0)
                {
                    if(userInput % 400 == 0)
                    {
                        Console.WriteLine("This year is leap");
                    }
                    else
                    {
                        Console.WriteLine("This year is not leap");
                    }
                }
                else
                {
                    Console.WriteLine("This year is leap");
                }
            }
            else
            {
                Console.WriteLine("This year is not leap");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();
        }

        public void FifthExercise()
        {
            Console.WriteLine("Please enter your age: ");
            sbyte userInput = sbyte.Parse(Console.ReadLine());

            if(userInput >= 21 && userInput < 30)
            {
                Console.WriteLine("You can be envoy and prime minister");
            }
            else if(userInput >= 30 && userInput < 35)
            {
                Console.WriteLine("You can be envoy, prime minister and senator");
            }
            else if (userInput >= 35)
            {
                Console.WriteLine("You can be envoy, prime minister, senator and president");
            }
            else
            {
                Console.WriteLine("You can be a programmer");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void SixthExercise()
        {
            Console.WriteLine("Please enter your height: ");

            short userInput = short.Parse(Console.ReadLine());

            if (userInput >= 175)
            {
                Console.WriteLine("You are tall");
            }
            else if (userInput >= 100 && userInput < 175)
            {
                Console.WriteLine("You are medium");
            }
            else
            {
                Console.WriteLine("You are small");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void SeventhExercise()
        {
            Console.WriteLine("Please enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"The biggest number is first number: {firstNumber}");
            }
            else if(secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"The biggest number is second number: {secondNumber}");
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"The biggest number is third number: {thirdNumber}");
            }
            else
            {
                Console.WriteLine("Try again and remember that all numbers should be different :)");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void EighthExercise()
        {
            Console.WriteLine("Please enter your points from math exam: ");
            int mathExam = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your points from physics exam: ");
            int physicsExam = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your points from chemistry exam: ");
            int chemistryExam = int.Parse(Console.ReadLine());

            if((mathExam + physicsExam + chemistryExam > 180) || (mathExam + physicsExam > 150) || (mathExam + chemistryExam > 150))
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("Candidate not admitted to recruitment");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();
        }

        public void NinthExercise()
        {
            Console.WriteLine("Please enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());

            if(temperature < 0)
            {
                Console.WriteLine("It is very cold");
            }
            else if(temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("It is cold");
            }
            else if(temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("It is chilly");
            }
            else if(temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("It is OK");
            }
            else if(temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("It is hot");
            }
            else
            {
                Console.WriteLine("It is very very hot");
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void TenthExercise()
        {
            Console.WriteLine("Please enter the length of the segment A: ");
            int segmentA = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of the segment B: ");
            int segmentB = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of the segment C: ");
            int segmentC = int.Parse(Console.ReadLine());

            if(segmentA <= 0 || segmentB <= 0 || segmentC <= 0)
            {
                Console.WriteLine("Segment can not be zero or has a negative value !!!");
            }
            else
            {
                if (segmentA > segmentB && segmentA > segmentC)
                {
                    if (segmentB + segmentC > segmentA)
                    {
                        Console.WriteLine("You can build a triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can not build a triangle");
                    }
                }
                else if (segmentB > segmentA && segmentB > segmentC)
                {
                    if (segmentA + segmentC > segmentB)
                    {
                        Console.WriteLine("You can build a triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can not build a triangle");
                    }
                }
                else if ( segmentC > segmentB && segmentC > segmentA)
                {
                    if (segmentA + segmentB > segmentC)
                    {
                        Console.WriteLine("You can build a triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can not build a triangle");
                    }
                }
                else if (segmentA == segmentB && segmentB == segmentC)
                {
                    Console.WriteLine("You can build a triangle");
                }
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();

        }

        public void EleventhExercise()
        {
            Console.WriteLine("Please enter your grade (1-6): ");
            sbyte userGrade = sbyte.Parse(Console.ReadLine());

            switch(userGrade)
            {
                case 1:
                    Console.WriteLine("Insufficient");
                    break;
                case 2:
                    Console.WriteLine("Permitting");
                    break;
                case 3:
                    Console.WriteLine("Sufficient");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Very good");
                    break;
                case 6:
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine("Select number from 1 to 6");
                    break;
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();
        }

        public void TwelfthExercise()
        {
            Console.WriteLine("Please enter number of the day (1-7): ");
            sbyte userGrade = sbyte.Parse(Console.ReadLine());

            switch(userGrade)
            {
                case 1:
                    Console.WriteLine("It is Monday");
                    break;
                case 2:
                    Console.WriteLine("It is Thuesday");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It is Thursday");
                    break;
                case 5:
                    Console.WriteLine("It is Friday");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday");
                    break;
                default:
                    Console.WriteLine("Select number from 1 to 7");
                    break;
            }

            Console.WriteLine("Task completed. Press any key to continue...");
            Console.ReadKey();
        }

        public void ThirteenthExercise()
        {
            Console.WriteLine("Please enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose what you want to do: ");
            Console.WriteLine("Type 1 for addition");
            Console.WriteLine("Type 2 for subtraction");
            Console.WriteLine("Type 3 for multiplication");
            Console.WriteLine("Type 4 for division");

            sbyte userChoice = sbyte.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    int additionResult = firstNumber + secondNumber;
                    Console.WriteLine($"The result is: {additionResult}");
                    break;
                case 2:
                    int subtractionResult = firstNumber - secondNumber;
                    Console.WriteLine($"The result is: {subtractionResult}");
                    break;
                case 3:
                    int multiplicationResult = firstNumber * secondNumber;
                    Console.WriteLine($"The result is: {multiplicationResult}");
                    break;
                case 4:
                    if(secondNumber == 0)
                    {
                        Console.WriteLine("You can not divide be 0 !");
                    }
                    else
                    {
                        int divisionResult = firstNumber / secondNumber;
                        Console.WriteLine($"The result is: {divisionResult}");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter the number from 1 to 4");
                    break;
            }

            Console.WriteLine("Last task completed. Press any key to exit...");
            Console.ReadKey();
        }
    }
}


