namespace Parenthesis10._1
{
    internal class Program

    {

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;          // Last valid element in nums1
            int j = n - 1;          // Last element in nums2
            int k = m + n - 1;      // Last position in nums1

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

            // Copy remaining elements from nums2, if any
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }

        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (letters[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            // Wrap around if no greater character exists
            return letters[left % letters.Length];
        }


        //n=2 ()()  (())
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Backtrack(result, "", 0, 0, n);
            return result;
        }

        private static void Backtrack(
            List<string> result,
            string current,
            int open,
            int close,
            int n)
        {
            // Base case: used all n pairs
            if (current.Length == 2 * n)
            {
                result.Add(current);
                return;
            }

            // Add '(' if we have opening parentheses left
            if (open < n)
            {
                Backtrack(
                    result, current + "(", open + 1, close, n);
            }

            // Add ')' only if it won't make the string invalid
            if (close < open)
            {
                Backtrack(
                    result, current + ")", open, close + 1, n);
            }
        }


        static void Main(string[] args)
        {


            // ['c','f','j']  target='a'
            // letters[left%letters.lenght]
         var result=GenerateParenthesis(2);
            foreach(var s in result)
            {
                Console.WriteLine(s);
            }
            //nums1=[1,2,3,0,0,0]m=3
            //nums2=[2,5,6] n=3
            //[1,2,2,3,5,6]
            //i=m-1 2
            //j=n-1 2
            //k=m+n-1 5
        }
    }
}
