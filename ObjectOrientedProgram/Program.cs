namespace ObjectOrientedProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Duplicate Elements\n2.Unique Elements\n3.Frequency of Each Element\n4.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
