using System;
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
    }
}
