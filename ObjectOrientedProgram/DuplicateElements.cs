﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class DuplicateElements
    {
        public void DuplicateNumbers()
        {
            int[] num = { 2,2,3,4,5,5,6,7,7,8 };
            int duplicate = 0;
            for(int i=0; i<num.Length;i++)
            {
                for(int j=i+1; j < num.Length;j++)
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
            int[] array = {2,3,4,5,1,2,3,4,5,6,7,7,8};
            for(int i=0;i<array.Length;i++)
            {
                bool duplicate = true;
                for(int j=0;j<array.Length;j++)
                {
                    if (array[i] == array[j] && i!=j)
                    {
                        duplicate = false;
                        break;
                    }
                }
                if(duplicate)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
