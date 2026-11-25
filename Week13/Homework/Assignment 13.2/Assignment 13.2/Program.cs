namespace Assignment_13._2
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
            Console.WriteLine("=== Remove Nth Node From End of List ===");
            (int[] list, int n)[] tests =
            {
                (new[] { 1, 2, 3, 4, 5 }, 2),
                (new[] { 1 }, 1),
                (new[] { 1, 2 }, 1)
            };
            foreach (var (list, n) in tests)
                Console.WriteLine($"head = [{string.Join(",", list)}], n = {n} -> {Print(RemoveNthFromEnd(Build(list), n))}");
        }

        static ListNode? RemoveNthFromEnd(ListNode? head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode fast = dummy, slow = dummy;
            for (int i = 0; i < n; i++)
                fast = fast.next!;

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next!;
            }

            slow.next = slow.next!.next;
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