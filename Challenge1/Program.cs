using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    class Program
    {
        public class Lettercount
        {
            public int word_count;
            public char letter;
        }

        public class LetterMethod
        {


            public List<Lettercount> count_char(string input)
            {
                IEnumerable<List<Lettercount>> result1;
                List<Lettercount> result = new List<Lettercount>();
                input = input.Trim('"');
                char[] inputArray = input.ToCharArray();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j])
                        {
                            count++;

                        }

                    }
                    Lettercount objletter = new Lettercount();
                    objletter.word_count = count;
                    objletter.letter = inputArray[i];
                    result.Add(objletter);
                }
                return result;
            }

        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter the input string");
            string input = '"' + Console.ReadLine() + '"';
            
            Lettercount obj1 = new Lettercount();
            LetterMethod obj2 = new LetterMethod();
          
            List<Lettercount> lettercounts = obj2.count_char(input);
            
            
            foreach (var item in lettercounts)
            {

                Console.WriteLine(item.letter + "=" + item.word_count);
         
               
            }


        }
    }
}

