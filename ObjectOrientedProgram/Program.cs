namespace ObjectOrientedProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Duplicate Elements\n2.Unique Elements\n3.Frequency of Each Element\n4.Find Max And Min element in an Array\n5.Print Pattern\n6.Print Pattern 2\n7.Reverse of String\n8.Sum Of All Digits of Given Number\n9.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                DuplicateElements duplicate = new DuplicateElements();

                switch (option)
                {
                    case 1:
                        duplicate.DuplicateNumbers();
                        break;
                    case 2:
                        duplicate.PrintUniqueElements();
                        break;
                        case 3:
                        duplicate.FrequencyOfEachElementInArray();
                        break;
                        case 4:
                        duplicate.FindMaximumAndMinimum();
                        break;
                        case 5:
                        duplicate.Pattern();
                        break;
                    case 6:
                        duplicate.Pattern2();
                        break;
                        case 7:
                        duplicate.ReverseEachWord();
                        break;
                        case 8:
                        duplicate.SumOfAllNumbers();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}
