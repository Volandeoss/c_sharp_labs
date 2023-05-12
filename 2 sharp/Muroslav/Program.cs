using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace lab2
{



    public class Word
    {

        private string word;
        //public int AmountOfNumbers;
        private char X;
        public void EnterWord()
        {
            Console.WriteLine("Enter your word:");

            word = Console.ReadLine();

        }



        public int CountNumber()
        {

            int AmountOfNumbers = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (char.IsNumber(word[i]))
                {
                    //Console.WriteLine(word[i]);
                    AmountOfNumbers++;


                }



            }
            return (AmountOfNumbers);


        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Word object1 = new Word();
            object1.EnterWord();
            Console.WriteLine(object1.CountNumber());
        }

    }
}
