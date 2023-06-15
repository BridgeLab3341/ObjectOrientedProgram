using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
