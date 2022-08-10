namespace BasicPractiseProblems
{
    class LeapYear
    {
        public static void Check()
        {
            Console.WriteLine("Question 2 : Leap Year check \n");
            Console.Write("Enter a year : ");

            try
            {
                var year = Convert.ToInt32(Console.ReadLine());
                if (year.ToString().Length == 4)
                {
                    var leapChk = (year % 4 == 0) ? string.Format("{0} is a Leap Year", year) : string.Format("{0} is NOT a Leap Year", year);
                    Console.WriteLine("\n>>>> {0}", leapChk);
                }
                else
                {
                    Console.WriteLine("\n!!!! ENTER A FOUR DIGIT NUMBER !!!!");
                    Check();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!!");
                Check();
            }
        }
    }
}