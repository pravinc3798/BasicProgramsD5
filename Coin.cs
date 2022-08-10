namespace BasicPractiseProblems
{
    class Coin
    {
        public static void Flip()
        {
            Console.WriteLine("Q1. Flip a coin and print percentage of heads and tails. \n");

            Console.Write("How many times to flip the coin : ");

            try
            {
                var count = Convert.ToInt32(Console.ReadLine());
                var randomNum = new Random();
                if (count < 1)
                    throw new Exception(); // to go to catch block 

                var headCount = 0f;
                var tailCount = 0f;

                for (int i = 0; i < count; i++)
                {
                    var result = randomNum.NextDouble();
                    if (result < 0.5)
                    {
                        tailCount++;
                    }
                    else if (result > 0.5)
                    {
                        headCount++;
                    }
                }

                float ratio = headCount / tailCount;
                Console.WriteLine("\n>>>>> Coin Flipped {0} times : Head Count - {1} : Tail Count - {2} \n", count, headCount, tailCount);
                Console.WriteLine(">>>>> Head / Tail Ratio : {0}", ratio);
            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                Flip();
            }
        }
    }
}