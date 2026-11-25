namespace Assignment_12._1
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
            Console.WriteLine("=== 1. Ransom Note ===");
            string[][] noteTests = { new[] { "a", "b" }, new[] { "aa", "ab" }, new[] { "aa", "aab" } };
            foreach (var t in noteTests)
                Console.WriteLine($"ransomNote=\"{t[0]}\", magazine=\"{t[1]}\" -> {CanConstruct(t[0], t[1])}");

            Console.WriteLine();
            Console.WriteLine("=== 2. Palindrome Linked List ===");
            int[][] listTests = { new[] { 1, 2, 2, 1 }, new[] { 1, 2 }, new[] { 1, 2, 3, 2, 1 }, new[] { 1 } };
            foreach (var arr in listTests)
                Console.WriteLine($"[{string.Join(",", arr)}] -> {IsPalindrome(Build(arr))}");
        }

        static bool CanConstruct(string ransomNote, string magazine)
        {
            int[] count = new int[26];
            foreach (char c in magazine)
                count[c - 'a']++;

            foreach (char c in ransomNote)
            {
                if (count[c - 'a'] == 0)
                    return false;
                count[c - 'a']--;
            }
            return true;
        }

        static bool IsPalindrome(ListNode? head)
        {
            ListNode? slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow!.next;
                fast = fast.next.next;
            }

            ListNode? second = Reverse(slow);
            ListNode? first = head;
            while (second != null)
            {
                if (first!.val != second.val)
                    return false;
                first = first.next;
                second = second.next;
            }
            return true;
        }

        static ListNode? Reverse(ListNode? head)
        {
            ListNode? prev = null, curr = head;
            while (curr != null)
            {
                ListNode? next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
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
    }
}
