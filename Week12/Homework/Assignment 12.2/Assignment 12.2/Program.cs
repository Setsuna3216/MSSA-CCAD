namespace Assignment_12._2
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
            Console.WriteLine("=== Remove Linked List Elements ===");
            (int[] list, int val)[] tests =
            {
                (new[] { 1, 2, 6, 3, 4, 5, 6 }, 6),
                (new int[] { }, 1),
                (new[] { 7, 7, 7, 7 }, 7)
            };
            foreach (var (list, val) in tests)
                Console.WriteLine($"[{string.Join(",", list)}], val={val} -> {Print(RemoveElements(Build(list), val))}");
        }

        static ListNode? RemoveElements(ListNode? head, int val)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode curr = dummy;
            while (curr.next != null)
            {
                if (curr.next.val == val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
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
