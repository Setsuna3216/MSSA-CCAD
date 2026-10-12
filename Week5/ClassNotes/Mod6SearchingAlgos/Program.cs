namespace Mod6SearchingAlgos
{
    internal class Program
    {
        // O(n)
        //space: O(1)
        static bool LinearSearch(int[]arr,int target,out int index)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]==target)
                {
                    index = i;
                    return true;
                }
                
            }
            index = -1;
            return false;
        }

        //O(log n)
        //space: O(1)
        //pre requisite: sorted array
        static int BinarySearch(int[]arr, int target)
        {
            int left = 0; //start
            int right = arr.Length - 1;//end
            int mid = 0;
            while(left<=right)// when left and right cross each other, we stop
            {
                mid = (left + right) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;

            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 12, 1, 34, 500, 234, 23, 99 };
            int index;
            
            if(LinearSearch(nums,24,out index))
            {
                Console.WriteLine($"Target found at index {index}");
            }
            else
            {
                Console.WriteLine("Target not found..");
            }

           
            Array.Sort(nums);
            int result = BinarySearch(nums, 500);
            if (result!=-1)
            {
                Console.WriteLine($"Number is found at index {result} ");
            }
          
        }
    }
}
