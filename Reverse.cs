namespace BasicPractiseProblems
{
    class Reverse
    {
        public static void GetReversed()
        {
            Console.WriteLine("Question 7 : Reverse whatever is provided \n");

            try
            {
                Console.Write("Input something : ");
                var input = Console.ReadLine();

                var reversedInput = "";

                for (var i = 0; i < input.Length; i++)
                {
                    reversedInput += input[(input.Length - i - 1)];
                }

                Console.WriteLine("\n >>>>> Reversed Output : {0}", reversedInput);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                GetReversed();
            }

        }
    }
}