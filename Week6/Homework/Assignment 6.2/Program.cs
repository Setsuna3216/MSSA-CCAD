namespace Assignment_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            MyStack myStack = new MyStack(5);
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            //Q2

            int[] nums = [1, 2, 3, 4];

            int[] answer = new int[nums.Length];

            int left = 1;
            int right = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = left;
                left = left * nums[i];
            }
            for (int i = nums.Length-1; i >= 0; i--)
            {
                answer[i] = answer[i] * right;
                right = right * nums[i];
            }



            Console.WriteLine(string.Join(", ", answer));

        }
    }
}
