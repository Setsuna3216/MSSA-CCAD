namespace Week5ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Q1 Tests:");

            int[] nums1 = { 2, 2, 1 };
            Console.WriteLine(FindSingleNum(nums1));  // Expected: 1

            int[] nums2 = { 4, 1, 2, 1, 2 };
            Console.WriteLine(FindSingleNum(nums2));  // Expected: 4

            int[] nums3 = { 1 };
            Console.WriteLine(FindSingleNum(nums3));  // Expected: 1

            int[] nums4 = { 5, 3, 5, 7, 7 };
            Console.WriteLine(FindSingleNum(nums4));  // Expected: 3
            //Q2
            Console.WriteLine("Q2 Tests:");

            int[] nums5 = { 3, 0, 1 };
            Console.WriteLine(FindMissingNum(nums5));  // Expected: 2

            int[] nums6 = { 0, 1 };
            Console.WriteLine(FindMissingNum(nums6));  // Expected: 2

            int[] nums7 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(FindMissingNum(nums7));  // Expected: 8

            int[] nums8 = { 0 };
            Console.WriteLine(FindMissingNum(nums8));  // Expected: 1

            int[] nums9 = { 1 };
            Console.WriteLine(FindMissingNum(nums9));  // Expected: 0
        }

        static int FindSingleNum(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int x in nums)
            {
                if (!seen.Add(x))
                {
                    seen.Remove(x);
                }
            }
            foreach (int x in seen)
            {
                return x;
            }
            return -1;
        }

        static int FindMissingNum(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>(nums);
          
            for (int i = 0; i <= nums.Length; i++)
            {
                if (!seen.Contains(i))
                {
                    return i;
                }
            }

            return -1;

        }
    }
}
