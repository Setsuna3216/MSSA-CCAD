namespace Week_10_Challenge_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1

            string s = "abcd";
            string t = "ecabd";

            char result = FindTheDifference(s, t);
            Console.WriteLine("Question 1:");
            Console.WriteLine(result);

            //Q2
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            Merge(nums1, 3, nums2, 3);

            Console.WriteLine("Question 2:");
            Console.WriteLine(string.Join(", ", nums1));

        }
        static char FindTheDifference(string s, string t)
        {
            int sum = 0;

            foreach (char c in t)
            {
                sum += c;
            }

            foreach (char c in s)
            {
                sum -= c;
            }

            return (char)sum;
        }
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
