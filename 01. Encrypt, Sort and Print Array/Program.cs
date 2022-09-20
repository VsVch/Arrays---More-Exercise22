using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumVowel = 0;
            int sumConsonant = 0;
            int sum = 0;

            int[] sortNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    int currentLetter = name[j];
                    if (currentLetter == 97 || currentLetter == 101 || currentLetter == 105 || currentLetter == 111 || currentLetter == 117 || currentLetter == 65 || currentLetter == 69 || currentLetter == 73 || currentLetter == 79 || currentLetter == 85)
                    {
                        sumVowel += currentLetter * name.Length;
                    }
                    else
                    {
                        sumConsonant += currentLetter / name.Length;
                    }
                }
                sum = sumConsonant + sumVowel;
                sortNumbers[i] = sum;

                sum = 0;
                sumConsonant = 0;
                sumVowel = 0;


            }
            Array.Sort(sortNumbers);
            for (int i = 0; i < sortNumbers.Length; i++)
            {
                Console.WriteLine(sortNumbers[i]);

            }

        }
    }
}
