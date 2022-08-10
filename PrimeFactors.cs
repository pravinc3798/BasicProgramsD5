namespace BasicPractiseProblems
{
    public class PrimeFactors
    {
        public static void GetFactors()
        {
            Console.WriteLine("Question 5 : Prime Factors \n");
            Console.Write("Input a number : ");

            try
            {
                var num = Convert.ToInt32(Console.ReadLine());

                if (num < 1)
                    throw new Exception();

                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                        Console.WriteLine(" >> {0}", i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                GetFactors();
            }

        }
    }
}