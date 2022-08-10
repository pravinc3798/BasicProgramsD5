namespace BasicPractiseProblems
{
    class BasicProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 1. Flip Coin \n 2. Leap Year \n 3. Power of 2s \n 4. Harmonic Number \n 5. Prime Factors \n 6. Quotient and Remainder \n 7. Reverse \n 8. Odd/Even \n 9. Vowel or Consonant \n 10. Largest among three numbers \n");
            Console.Write("Input a number corresponding to desired program : ");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: Coin.Flip(); break;
                case 2: LeapYear.Check(); break;
                case 3: PowerOf2s.Get(); break;
                case 4: HarmonicNumber.GetNthNumber(); break;
                case 5: PrimeFactors.GetFactors(); break;
                case 6: Division.GetQuotientRemainder(); break;
                case 7: Reverse.GetReversed(); break;
                case 8: EvenOdd.Check(); break;
                case 9: VowelConsonant.ChkAlphabet(); break;
                case 10: LargestIn3.GetMaximum(); break;
                default: Console.WriteLine("INVALID INPUT!!"); break;
            }
        }
    }
}