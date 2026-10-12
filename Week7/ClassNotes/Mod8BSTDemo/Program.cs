namespace Mod8BSTDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(30);
            tree.Add(20);
            tree.Add(90);
            tree.Add(85);
            Console.WriteLine("Inorder:");
            tree.InOrder(tree.Root);

            Console.WriteLine();

            Console.WriteLine("Preorder:");
            tree.PreOrder(tree.Root);

            Console.WriteLine();
            Console.WriteLine("Postorder:");
            tree.PostOrder(tree.Root);

            Console.WriteLine();

            Console.WriteLine($"Value present : {tree.Search(90)}");
            Console.WriteLine($"Value present : {tree.Search(9)}");
        }
    }
}
