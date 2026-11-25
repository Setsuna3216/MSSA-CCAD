namespace Assignment_13._1
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Add Two Numbers ===");
            (int[] a, int[] b)[] tests =
            {
                (new[] { 2, 4, 3 }, new[] { 5, 6, 4 }),
                (new[] { 0 }, new[] { 0 }),
                (new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 })
            };
            foreach (var (a, b) in tests)
                Console.WriteLine($"l1 = [{string.Join(",", a)}], l2 = [{string.Join(",", b)}] -> {Print(AddTwoNumbers(Build(a), Build(b)))}");
        }

        static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
                carry = sum / 10;
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            return dummy.next;
        }

        static ListNode? Build(int[] values)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;
            foreach (int v in values)
            {
                tail.next = new ListNode(v);
                tail = tail.next;
            }
            return dummy.next;
        }

        static string Print(ListNode? head)
        {
            var values = new List<int>();
            for (var n = head; n != null; n = n.next)
                values.Add(n.val);
            return $"[{string.Join(",", values)}]";
        }
    }
}