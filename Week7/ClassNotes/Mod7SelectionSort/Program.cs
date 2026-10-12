namespace Mod7SelectionSort
{
    
    internal class Program
    {
        //[2,1,23,45,78]
        //o(nsq)
        static void SelectionSort(int[] nums)
        {
            int minPos, temp = 0;
            for(int i=0;i<nums.Length-1;i++)
            {
                minPos = i;
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[j] < nums[minPos])//found a smaller number
                    {
                        minPos = j;
                    }
                }
                if(minPos!=i)// avoid swapping with itself, number is already on the right spot
                {
                    temp = nums[i];
                    nums[i] = nums[minPos];
                    nums[minPos] = temp;

                }
            }

        }
        static void Main(string[] args)
        {
            int[] nums = { 12, 1, 45, 67, 11, 10 };
            SelectionSort(nums);
            foreach(var i in nums)
            {
                Console.WriteLine(i);

            }
       
        }
    }
}
