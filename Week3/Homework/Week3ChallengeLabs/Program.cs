namespace Week3ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 Palindrome
            Console.WriteLine(IsPalindrome("eye"));
            Console.WriteLine(IsPalindrome("home"));
            //Q2 sum of all digits in that string
            Console.WriteLine(SumDigitsInString("1q2w3e"));
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um"));
            Console.WriteLine(SumDigitsInString(" "));
            //Q3 return indices of the two numbers
            int[] nums = { 2, 7, 11, 15 };
            int[] result = TwoSum(nums, 9);

            Console.WriteLine(result[0] + ", " + result[1]);
            //Q4
            Console.WriteLine(MinLength("ABFCACDB"));
            Console.WriteLine(MinLength("ACBBD"));
        }

        static bool IsPalindrome(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int SumDigitsInString(string text) 
        { 
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    sum += text[i] - '0';
                }
            }

            return sum;
        
        }
        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
        static int MinLength(string text)
        {
            while (text.Contains("AB") || text.Contains("CD"))
            {
                text = text.Replace("AB", "");
                text = text.Replace("CD", "");
            }

            return text.Length;
        }
    }
}
