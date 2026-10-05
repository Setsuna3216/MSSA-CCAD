namespace Assignment_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            HouseLinkedList list = new HouseLinkedList();
            
            House house1 = new House();

            house1.houseNumber = 101;
            house1.briefAddress = "123 Main St";
            house1.typeOfHouse = "Ranch";
            list.Add(house1);

            House house2 = new House();

            house2.houseNumber = 205;
            house2.briefAddress = "456 Oak St";
            house2.typeOfHouse = "Colonial";
            list.Add(house2);

            House house3 = new House();

            house3.houseNumber = 310;
            house3.briefAddress = "789 Pine St";
            house3.typeOfHouse = "Townhouse";
            list.Add(house3);

            Console.Write("Enter house number: ");
            int target = Convert.ToInt32(Console.ReadLine());

            list.Search(target);
            list.Display();


            //Q2
            //Q3
            int[] nums = { 0, 1, 0, 3, 12 };

            int[] result = ArrayMove0(nums);

            Console.WriteLine(string.Join(", ", result));

        }
        static int[] ArrayMove0(int[] nums)
        {
            int position = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[position]=nums[i];
                    position++;
                }
            }
            for (int i = position; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
