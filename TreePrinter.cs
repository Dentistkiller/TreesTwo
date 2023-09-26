using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesTwo
{
    class TreePrinter
    {
        public static void PrintTree(TreeNode root, string indent = "", bool last = true)
        {
            if (root == null)
                return;

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│ ";
            }

            Console.WriteLine(root.Value);

            PrintTree(root.Left, indent, false);
            PrintTree(root.Right, indent, true);
        }
    }
}
