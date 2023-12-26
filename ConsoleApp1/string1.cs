using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class string1
    {
        static void Main()
        {
            //declare string
            string string_name = "The quick brown fox jumps over the lazy dog";


            // a) Print the character at the 12th index.
            Console.WriteLine("a) Character at 12th index: " + string_name[11]);

                        // b) Check whether the String contains the word “is”.
            Console.WriteLine("b) Contains 'is': " + string_name.Contains("is"));

            // c) Add the string “and killed it” to the existing string.
            //string_name += " and killed it";
            //Console.WriteLine("c) Modified string: " + string_name);
            // Second method
            string string2 = " and killed it";
            Console.WriteLine("c) Modified String second method: " + string.Concat(string_name, string2));

            // d) Check whether the String ends with the word “dogs”.
            Console.WriteLine("d) Ends with 'dogs': " + string_name.EndsWith("dogs"));

            // e) Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.
            Console.WriteLine("e) Equals (case-sensitive): " + string_name.Equals("The quick brown Fox jumps over the lazy Dog"));

            // f) Check whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.
            Console.WriteLine("f) Equals (case-insensitive): " + string_name.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", StringComparison.OrdinalIgnoreCase));

            // g) Find the length of the String.
            Console.WriteLine("g) Length: " + string_name.Length);

            // h) Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”.
            Console.WriteLine("h) Matches (case-sensitive): " + string_name.Equals("The quick brown Fox jumps over the lazy Dog"));

            // i) Replace the word “The” with the word “A”.
            //string_name = string_name.Replace("The", "A");
            Console.WriteLine("i) Replaced 'The' with 'A': " + string_name.Replace("The","A",StringComparison.OrdinalIgnoreCase));

            // j) Split the above string into two such that two animal names do not come together.
            string[] animalNames = string_name.Split(' ');
            int middleIndex = animalNames.Length / 2;

            // Join the first half of the array into the first substring
            //string firstSubstring = string.Join(" ", animalNames.Take(middleIndex));

            //// Join the second half of the array into the second substring

            //string secondSubstring = string.Join(" ", animalNames.Skip(middleIndex));

            string firstSubstring = string.Join(" ", animalNames, 0, middleIndex);

            // Join the words from the middle index to the end into the second substring
            string secondSubstring = string.Join(" ", animalNames, middleIndex, animalNames.Length - middleIndex);


            Console.WriteLine("j) First Substring: " + firstSubstring);
            Console.WriteLine("   Second Substring: " + secondSubstring);


            // k) Print the animal names alone separately from the above string.
            Console.WriteLine("k) Animal names alone:");
            Console.WriteLine("Animal 1: " + animalNames[3]);
            Console.WriteLine("Animal 2: " + animalNames[animalNames.Length - 1]);

            // l) Print the above string in completely lower case.
            Console.WriteLine("l) Lower case: " + string_name.ToLower());

            // m) Print the above string in completely upper case.
            Console.WriteLine("m) Upper case: " + string_name.ToUpper());

            // n) Find the index position of the character “a”.
            Console.WriteLine("n) Index of 'a': " + string_name.IndexOf('a'));

            // o) Find the last index position of the character “e”.
            Console.WriteLine("o) Last index of 'e': " + string_name.LastIndexOf('e'));

            // p) Prompt the user to enter the home directory of Tomcat server.
            Console.Write("Enter the home directory of Tomcat server: ");
            string homeDirectory = Console.ReadLine();

            // To the path that the user enters, add another path to WebApps/MyApps/Images directory.
            string imagePath = $"{homeDirectory}\\WebApps\\MyApps\\Images";
            Console.WriteLine("p) New path: " + imagePath);

            // q) Write a C# code that has a constant string that represents poem lines.
            const string poemLines = @"I WANDER'D lonely as a cloud
            That floats on high o'er vales and hills,
            When all at once I saw a crowd,
            A host, of golden daffodils;Beside the lake, beneath the trees,
            Fluttering and dancing in the breeze.";

            Console.WriteLine("q) Poem lines:");
            Console.WriteLine(poemLines);
        }
    }
}


