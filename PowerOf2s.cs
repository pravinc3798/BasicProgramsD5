namespace BasicPractiseProblems
{
    class PowerOf2s
    {
        public static void Get()
        {
            Console.WriteLine("Question 3 : Power of 2s (restrict at overflow of int) \n");
            Console.Write("Enter a number : ");

            try
            {
                var num = Convert.ToInt32(Console.ReadLine());

                if (num > 32)
                    throw new Exception();

                for (var i = 0; i <= num; i++)
                {
                    Console.WriteLine(">>>> 2 to the power {0} : {1}", i, Math.Pow(2, i));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!!");
                Get();
            }
        }
    }
}