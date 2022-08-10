namespace BasicPractiseProblems
{
    class LargestIn3
    {
        public static void GetMaximum()
        {
            Console.WriteLine("Question 10 : Find largest among three numbers \n");

            try
            {
                var nums = new List<int>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Input a number : ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    nums.Add(number);
                }
                
                int max = 0;
                foreach (var num in nums)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine("\n >>>>> Largest input was : {0}", max);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                GetMaximum();
            }

        }
    }
}