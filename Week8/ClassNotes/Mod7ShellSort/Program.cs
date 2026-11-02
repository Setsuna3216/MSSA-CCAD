namespace Mod7ShellSort
{
    internal class Program
    {

        static void ShellSort(int[]data)
        {
            int gap = data.Length / 2;//n=6, gap=3
            int i, j;
            while(gap>0)
            {
                i = gap;
                while(i < data.Length)
                {
                    int temp = data[i];//number to be placed in correct spot
                    j = i - gap;//j is the index of the element to compare with temp
                    while(j >= 0 && data[j] > temp)
                    {
                        data[j + gap] = data[j];//shift the larger element to the right
                        j -= gap;//move j back by the gap
                    }
                    data[j + gap] = temp;//place the temp in its correct position
                    i++;//move to the next element
                }
                gap /= 2;//reduce the gap for the next iteration
            }

        }

        static void Main(string[] args)
        {

            int[] arr = { 3, 5, 8, 9, 6, 2 };
            ShellSort(arr);


        }
    }
}
