namespace Mod7InsertionSort
{
    internal class Program
    {
        //stable, O(nsq)
        static void InsertionSort(int[]nums)
        {
            for(int i=1;i<nums.Length;i++)
            {
                int key = nums[i];
                int j = i - 1;
                while(j>=0 && nums[j]>key) // left side numbers are more
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 5, 3, 4, 1, 2 };
            InsertionSort(nums);
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }

         
        }
    }
}
