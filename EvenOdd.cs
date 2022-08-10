namespace BasicPractiseProblems
{
    class EvenOdd
    {
        public static void Check()
        {
            Console.WriteLine("Question 8 : Check whether a number is even or odd \n");

            try
            {
                Console.Write("Input a number : ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (input < 1)
                    throw new Exception();

                var test = (input % 2 == 0) ? string.Format("{0} is EVEN number", input) : string.Format("{0} is ODD number", input);

                Console.WriteLine("\n >>>>> {0}",test);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                Check();
            }

        }
    }
}