namespace BasicPractiseProblems
{
    class HarmonicNumber
    {
        public static void GetNthNumber()
        {
            Console.WriteLine("Question 4 : N-th Harmonic Number \n");
            Console.Write("Input a number : ");

            try
            {
                var num = Convert.ToInt32(Console.ReadLine());

                if (num < 1)
                    throw new Exception();

                float nHarmonic = 0f;
                for (float i = 1; i < num; i++)
                {
                    nHarmonic += 1 / i;
                }

                Console.WriteLine("\n >>>>> {0}th Harmonic Number : {1}", num, nHarmonic);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                GetNthNumber();
            }
        }
    }
}