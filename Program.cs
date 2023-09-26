namespace TreesTwo
{
    class Program
    {
        static void Main()
        {
            // Create a sample binary tree
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);

            // Print the tree structure
            Console.WriteLine("Binary Tree Structure:");
            TreePrinter.PrintTree(root);
        }
    }
}