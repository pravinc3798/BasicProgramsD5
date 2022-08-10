namespace BasicPractiseProblems
{
    class VowelConsonant
    {
        public static void ChkAlphabet()
        {
            Console.WriteLine("Question 9 : Check whether an alphabet is Vowel or Consonant \n");

            var vowels = new string[] { "a", "e", "i", "o", "u" };

            try
            {
                Console.Write("Input an alphabet : ");
                var input = (Console.ReadLine()).ToLower();
                byte check = 0;
                if (input.Length == 1)
                {
                    foreach (var vowel in vowels)
                    {
                        if (vowel == input)
                        {
                            check = 1;
                            break;
                        }
                    }
                    var result = (check == 1) ? string.Format("{0} is a VOWEL", input) : string.Format("{0} is a CONSONANT", input);
                    Console.Write("\n>>>>> {0}", result);
                }
                else
                {
                    Console.WriteLine("\n !! Input single character !!");
                    ChkAlphabet();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\n!!! INVALID INPUT !!!\n");
                ChkAlphabet();
            }

        }
    }
}