using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ObjectOrientedProgram
{
    public class DuplicateElements
    {
        public void DuplicateNumbers()
        {
            int[] num = { 2, 2, 3, 4, 5, 5, 6, 7, 7, 8 };
            int duplicate = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        duplicate++;
                    }
                }
            }
            Console.WriteLine(duplicate);
        }
        public void PrintUniqueElements()
        {
            int[] array = { 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 7, 7, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                bool duplicate = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        duplicate = false;
                        break;
                    }
                }
                if (duplicate)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        public void FrequencyOfEachElementInArray()
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 7, 8 };

            // Create arrays to store unique elements and their frequencies
            int[] uniqueElements = new int[array.Length];
            int[] frequencies = new int[array.Length];

            int uniqueCount = 0;

            // Loop through each element in the array
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                bool found = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (uniqueElements[j] == element)
                    {
                        // Increment the frequency if found
                        frequencies[j]++;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    uniqueElements[uniqueCount] = element;
                    frequencies[uniqueCount] = 1;
                    uniqueCount++;
                }
            }
            // Print the frequencies
            Console.WriteLine("Element   Frequency");
            for (int i = 0; i < uniqueCount; i++)
            {
                Console.WriteLine($"{uniqueElements[i]}         {frequencies[i]}");
            }
        }
        public void FindMaximumAndMinimum()
        {
            int[] array = { 1, 9, 43, 6, 3, 7, 8,23, 10 };
            int max = array[0];
            int min = array[0];
            for(int i=0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
                if (array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Maximum :{0}  Minimum : {1}",max,min);
        }
        public void Pattern()
        {
            Console.WriteLine("********");
            Console.WriteLine("*******");
            Console.WriteLine("******");
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
        }
        public void Pattern2()
        {
            Console.WriteLine("*******");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*******");
        }
        public void ReverseEachWord()
        {
            string[] input = { "ReverseWord" };
            string reverse = "";
            for(int i=0; i < input.Length; i++)
            {
                char[] chars= input[i].ToCharArray();
                Array.Reverse(chars);
                reverse=new string(chars);
                Console.WriteLine(reverse);
            }
        }
        public void SumOfAllNumbers()
        {
            int number = 123675456;
            int sum = 0;
            string numberstring=number.ToString();
            for(int i=0;i<numberstring.Length;i++)
            {
                sum += int.Parse(numberstring[i].ToString());
            }
            Console.WriteLine(sum);
        }
        public void SumOfMatrix()
        {
            int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {5,6,7}
            };
            int rows=matrix.GetLength(0);
            int columns=matrix.GetLength(1);
            for(int i=0;i<rows;i++)
            {
                int rowSum = 0;
                for(int j=0;j<columns;j++)
                {
                    rowSum+= matrix[i,j];
                }
                Console.WriteLine("Row"+(i+1)+" : "+rowSum );
            }
        }
    }
}
