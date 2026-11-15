namespace Assignment_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. Best Time to Buy and Sell Stock ===");
            int[][] stockTests = { new[] { 7, 1, 5, 3, 6, 4 }, new[] { 7, 6, 4, 3, 1 } };
            foreach (var prices in stockTests)
                Console.WriteLine($"[{string.Join(",", prices)}] -> {MaxProfit(prices)}");

            Console.WriteLine();
            Console.WriteLine("=== 2. Reverse Linked List ===");
            int[][] listTests = { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2 }, Array.Empty<int>() };
            foreach (var values in listTests)
            {
                var list = new MyLinkedList();
                foreach (var v in values) list.Add(v);
                Console.Write($"{list} -> ");
                list.Reverse();
                Console.WriteLine(list);
            }
        }

        static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            foreach (var price in prices)
            {
                if (price < minPrice) minPrice = price;
                else if (price - minPrice > maxProfit) maxProfit = price - minPrice;
            }
            return maxProfit;
        }
    }

    internal class Node
    {
        public int Value;
        public Node? Next;

        public Node(int value)
        {
            Value = value;
        }
    }

    internal class MyLinkedList
    {
        private Node? head;
        private Node? tail;

        public void Add(int value)
        {
            var node = new Node(value);
            if (head is null)
            {
                head = tail = node;
            }
            else
            {
                tail!.Next = node;
                tail = node;
            }
        }

        public void Reverse()
        {
            Node? prev = null;
            Node? curr = head;
            tail = head;
            while (curr is not null)
            {
                var next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public override string ToString()
        {
            var parts = new List<string>();
            for (var n = head; n is not null; n = n.Next)
                parts.Add(n.Value.ToString());
            return $"[{string.Join(",", parts)}]";
        }
    }
}