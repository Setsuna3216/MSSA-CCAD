namespace Assignment_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Palindrome Number
            Console.WriteLine("Q1 - Palindrome Number");

            Console.WriteLine($"121: {IsPalindromeNumber(121)}");
            Console.WriteLine($"-121: {IsPalindromeNumber(-121)}");
            Console.WriteLine($"123: {IsPalindromeNumber(123)}");
            Console.WriteLine($"1221: {IsPalindromeNumber(1221)}");


            // Q2 - Sum of Individual Digits
            Console.WriteLine("\nQ2 - Sum of Individual Digits");

            int number = 1234;
            Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfTheIndividualDigits(number)}");


            // Q3 - Contains Duplicate
            Console.WriteLine("\nQ3 - Contains Duplicate");

            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine($"[1, 2, 3, 1]: {IsAnyDuplicate(nums1)}");
            Console.WriteLine($"[1, 2, 3, 4]: {IsAnyDuplicate(nums2)}");
            Console.WriteLine($"[1, 1, 1, 3, 3, 4, 3, 2, 4, 2]: {IsAnyDuplicate(nums3)}");
        }

        static bool IsPalindromeNumber(int number) 
        {
            int num = 0;
            int num1;
            int num2 = number;
            if (number < 0)
            {
                return false;
            }
            while(num2 != 0)
            {
                
                num1 = num2 % 10;
                num2 = num2 / 10;
                num = num * 10 + num1;
                
            }

            if (num == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SumOfTheIndividualDigits(int number)
        {
            int sum = 0;
            int num1;
            int num2 = number;

            while (num2 != 0)
            {

                num1 = num2 % 10;
                num2 = num2 / 10;
                sum = sum + num1;

            }
            return sum;

        }

        static bool IsAnyDuplicate(int[] nums)
        {
            //for (int i = 0; i < nums.Length; i++) 
            //{
                //for(int j = i+1; j<nums.Length; j++)
                //{
                    //if (nums[i] == nums[j])
                    //{
                        //return true;
                    //}
                //}
            //}
            //return false;

            HashSet<int> seen = new HashSet<int>();
            foreach (int x in nums) 
            {
                //seen.Add(x);

                if (!seen.Add(x))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
