namespace ConsoleApp1
{
    internal class Program
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            // Create dummy node
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode current = dummy;

            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    // Remove the node
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return dummy.next;
        }
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            // Find the middle
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse the second half
            ListNode prev = null;
            ListNode current = slow;

            while (current != null)
            {
                ListNode nextNode = current.next;

                current.next = prev;

                prev = current;
                current = nextNode;
            }

            // Compare both halves
            ListNode first = head;
            ListNode second = prev;

            while (second != null)
            {
                if (first.val != second.val)
                    return false;

                first = first.next;
                second = second.next;
            }

            return true;
        }
        public bool IsPalindrome(ListNode head)
        {
            List<int> values = new List<int>();

            // Store linked list values
            ListNode current = head;

            while (current != null)
            {
                values.Add(current.val);
                current = current.next;
            }

            // Compare first and last elements
            int left = 0;
            int right = values.Count - 1;

            while (left < right)
            {
                if (values[left] != values[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // Count characters in magazine
            foreach (char c in magazine)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
            }

            // Check characters in ransomNote
            foreach (char c in ransomNote)
            {
                if (!dict.ContainsKey(c) || dict[c] == 0)
                    return false;

                dict[c]--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
