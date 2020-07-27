using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        { 
            string answer = "y";
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();
            while (answer == "y")
            {
                Console.Write("Write a word or sentence: ");
                string sentence = Console.ReadLine().ToLower();
                Console.WriteLine();
                string[] words = sentence.Split();
                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
                //char[] y = { 'y' };
                string output = "";
                string temp = "";
                

                foreach (var word in words)
                {
                    int firstVowel = word.IndexOfAny(vowel);

                    if (firstVowel == 0)
                    {
                        temp = word + "way ";
                        output = output + temp;
                    }
                    else if (word.Length == 1)
                    {//so putting a consonant by itself doesn't crash the program...though now numbers can be put in
                        temp = (word.Substring(0) + word.Substring(0, 0) + "ay ");
                        output = output + temp;
                    }
                    else if (firstVowel != 0)
                    {
                        temp = (word.Substring(firstVowel) + word.Substring(0, firstVowel) + "ay ");
                        output = output + temp;
                        
                    }
                    else
                    {
                        Console.WriteLine("Type a word please.");
                    }
                    //tried to solve the y problem but couldn't quite get there.
                    //else if (firstVowel != 0)
                    //{
                    //    int firstY = word.IndexOfAny(y);
                    //    temp = (word.Substring(firstY) + word.Substring(0, firstY) + "ay ");
                    //    output = output + temp;
                    //}
                }
                Console.WriteLine(output);
                Console.WriteLine();
                Console.Write("Continue? (y/n) ");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == "n")
                {
                    Console.WriteLine("Thanks for typing some words!");
                    Console.WriteLine();
                }
            }
       
        }

    }

}

    

