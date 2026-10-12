namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create BST
            TreeNode root = new TreeNode(8);
            root.left = new TreeNode(3);
            root.right = new TreeNode(10);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(6);

            // Test cases
            int[] testCases = { 8, 3, 6, 1, 10, 5, 15 };

            foreach (int val in testCases)
            {
                TreeNode? result = SearchBST(root, val);

                if (result != null)
                {
                    Console.WriteLine($"Search {val}: Found node {result.val}");
                    Console.WriteLine($"Left child: {result.left?.val.ToString() ?? "null"}");
                    Console.WriteLine($"Right child: {result.right?.val.ToString() ?? "null"}");
                }
                else
                {
                    Console.WriteLine($"Search {val}: Not found");
                }

                Console.WriteLine();
            }
        }
        static TreeNode? SearchBST(TreeNode? root, int val)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.val == val)
            {
                return root;
            }

            if (val < root.val)
            {
                return  SearchBST(root.left,val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
            
        }
    }
}
