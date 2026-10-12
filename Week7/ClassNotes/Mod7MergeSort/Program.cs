namespace Mod7MergeSort
{
    internal class Program
    {
        static void Divide(int[]arr,int left, int right)
        {

            if(left<right)
            {
                int mid = (left + right) / 2;
                Divide(arr, left, mid);//divide the left half
                Divide(arr, mid + 1, right);//divide the right half
                Merge(arr, left, mid, right);

            }
        }

        static void Merge(int[]arr,int left, int mid, int right)
        {
            int i = left;//first index of left subarray
            int j = mid + 1;//first index of right subarray
            int[] temp = new int[right + 1];//temp array to hold merged array
            int k = left;//index for temp array

            while(i<=mid && j<=right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];//smaller element in left half
                    i++;
                }
                else
                {
                    temp[k] = arr[j];//smaller element in right half
                    j++;
                }
                k++;

            }
            while(i<=mid)//if left array is having more elements remaining, put all of them in the temp
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            while(j<=right)//if right array is having more elements remaining, put all of them in the temp
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            for(int x=left;x<=right;x++)
            {
                arr[x] = temp[x];// sorted elements to be copied in the original
            }

        }


        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 8, 9, 6, 2 };
            Divide(arr, 0, arr.Length - 1);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
