namespace BasicPractiseProblems
{
    class Division
    {
        public static void GetQuotientRemainder()
        {
            Console.WriteLine("Question 6 : Compute Quotient and Remainder \n");

            try
            {
                Console.Write("Input 1st number : ");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input 2nd number : ");
                var num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 1 || num2 < 1)
                    throw new Exception();
                
                var quotient = num1 / num2;
                var remainder = num1 % num2;

                Console.WriteLine("\n >>>>> Division of {0} by {1} yields : \n\n >>>>> Quotient : {2} \n >>>>> Reaminder : {3}", num1, num2, quotient,remainder);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                GetQuotientRemainder();
            }

        }
    }
}