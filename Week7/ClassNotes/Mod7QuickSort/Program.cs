namespace Mod7QuickSort
{
    internal class Program
    {
        static void QuickSort(int[]arr,int low, int high)
        {
            if(low<high)
            {
                int p_index = Partition(arr, low, high);
                QuickSort(arr, low, p_index - 1);
                QuickSort(arr, p_index + 1, high);
            }
        }

        static int Partition(int[]arr, int low, int high)
        {
            int pivot = arr[low];// select the first element as pivot to be placed in pivot spot
            int i = low;
            int j = high;
            do
            {
                //increment i until we find an element greater than pivot
                while(i<=j && arr[i]<=pivot)
                {
                    i++;
                }
                //decrement j until we find a element lesser than pivot
                while(i<=j && arr[j]>=pivot)
                {
                    j--;
                }
                //if i and j stop, swap both of them. larger values to right and smaller to left
                if(i<=j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }
            while (i < j);
            // we found the correct position for pivot
            if(low!=j)
            {
                int temp = arr[low];
                arr[low] = arr[j];
                arr[j] = temp;
            }
            return j;

        }

        static void Main(string[] args)
        {

            int[] arr = { 54, 78, 63, 92, 45, 86, 15, 28, 37 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
