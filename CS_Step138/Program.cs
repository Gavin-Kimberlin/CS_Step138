using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step138
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            string[] stringList = { "See no ", "Hear no ", "Speak no " };
            Console.WriteLine("Enter a word: ");
            string input1 = Console.ReadLine();
            string[] inputList = new string[3];

            for (int i = 0; i < stringList.Length; i++)
            {
                inputList[i] = stringList[i] + input1;
            }

            foreach (string p in inputList)
            {
                Console.WriteLine(p + "\n");
            }

            //Steps 2 & 3
            int k = 0;

            while (k == 0)
            {
                Console.WriteLine(k);
                k++; //Fixes the infinite loop
            }

            //Step 4
            int a = 0;
            int b = 5;

            while (a < b)
            {
                Console.WriteLine(a);
                a++;
            }

            //Step 5
            int c = 0;
            int d = 5;

            while (c <= d)
            {
                Console.WriteLine(c);
                c++;
            }

            //Steps 6, 7, & 8
            List<string> stringArray = new List<string>();
            stringArray.Add("pony");
            stringArray.Add("ball");
            stringArray.Add("steak");
            stringArray.Add("torch");
            stringArray.Add("blue");
            stringArray.Add("irish");
            stringArray.Add("right");
            stringArray.Add("house");
            stringArray.Add("boys");
            stringArray.Add("pokemon");

            int e = 5;
            do
            {
                Console.WriteLine("\nYou have " + e + " tries left to guess a word from a list of words.\nEnter a word:");
                string word = Console.ReadLine().ToLower();

                if (stringArray.Contains(word))
                {
                    int idx = stringArray.IndexOf(word);
                    Console.WriteLine(word + " is one of the words! It is at index " + idx + "." + "\nCongratulations!");
                    e = 0;
                }
                else if (e == 0)
                {
                    Console.WriteLine("\nYou have run out of guesses. Please shut down the program and try again.");
                }
                else
                {
                    Console.WriteLine("\nPlease try again.");
                    e--;
                }
            } while (e > 0);

            //Steps 9 & 10
            List<string> stringArray2 = new List<string>();
            stringArray2.Add("candy");
            stringArray2.Add("orange");
            stringArray2.Add("help");
            stringArray2.Add("tulip");
            stringArray2.Add("tulip");
            stringArray2.Add("car");
            stringArray2.Add("tattoo");
            stringArray2.Add("orange");
            stringArray2.Add("teeth");
            stringArray2.Add("lamp");

            int f = 5;
            do
            {
                Console.WriteLine("\nYou have " + f + " tries left to guess a word from the second list of words.\nEnter a word:");
                string word2 = Console.ReadLine().ToLower();

                if (stringArray2.Contains(word2))
                {
                    int idx2 = stringArray2.IndexOf(word2);
                    int idx3 = stringArray2.IndexOf( word2, idx2 + 1);
                    if (idx3 == -1)
                    {
                        Console.WriteLine(word2 + " is one of the words! It is at index " + idx2 + "." + "\nCongratulations!");
                    }
                    else
                    {
                        Console.WriteLine(word2 + " is two of the words! It is at indeces " + idx2 + " and " + idx3 + "." + "\nCongratulations!");
                    }
                    f = 0;
                }
                else if (f == 0)
                {
                    Console.WriteLine("\nYou have run out of guesses. Please shut down the program and try again.");
                }
                else
                {
                    Console.WriteLine("\nPlease try again.");
                    f--;
                }
            } while (f > 0);

            Console.WriteLine("\n\n");

            //Step 11
            List<string> stringArray3 = new List<string>();
            stringArray3.Add("peanut");
            stringArray3.Add("peanut");
            stringArray3.Add("string");
            stringArray3.Add("christmas");
            stringArray3.Add("sword");
            stringArray3.Add("atom");
            stringArray3.Add("christmas");
            stringArray3.Add("coding");
            stringArray3.Add("hate");
            stringArray3.Add("love");

            List<string> stringArray4 = new List<string>();

            foreach (string thing in stringArray3)
            {
                if (stringArray4.Contains(thing))
                {
                    Console.WriteLine(thing + " (duplicate)");
                }
                else
                {
                    Console.WriteLine(thing);
                    stringArray4.Add(thing);
                }
            }

            Console.ReadLine();
        }
    }
}
