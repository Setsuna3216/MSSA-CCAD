namespace Week_11_Challenge_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Question 1: Sort Colors ===");
            int[][] colorTests = { new[] { 2, 0, 2, 1, 1, 0 }, new[] { 2, 0, 1 } };
            foreach (var nums in colorTests)
            {
                Console.Write($"[{string.Join(",", nums)}] -> ");
                SortColors(nums);
                Console.WriteLine($"[{string.Join(",", nums)}]");
            }

            Console.WriteLine();
            Console.WriteLine("=== Question 2: Maximum Number of Balloons ===");
            string[] balloonTests = { "nlaebolko", "loonbalxballpoon", "leetcode" };
            foreach (var text in balloonTests)
                Console.WriteLine($"\"{text}\" -> {MaxNumberOfBalloons(text)}");
        }

        static void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);
                    high--;
                }
            }
        }

        static int MaxNumberOfBalloons(string text)
        {
            var count = new int[26];
            foreach (var c in text)
                count[c - 'a']++;

            return Math.Min(
                Math.Min(count['b' - 'a'], count['a' - 'a']),
                Math.Min(Math.Min(count['l' - 'a'] / 2, count['o' - 'a'] / 2), count['n' - 'a']));
        }
    }
}