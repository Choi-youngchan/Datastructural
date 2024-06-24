namespace Program
{
    public class Node
    {
        public int data;

        public Node left;
        public Node right;

        // public void Show()
        // {
        //     Console.WriteLine(data);
        // }

    }
    internal class Program
    {
        // static void Show(Node node)
        // {
        //     Console.WriteLine(node.data); 
        // }

        static Node CreateNode(int data, Node left, Node right)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.left = left;
            newNode.right = right;
            
            return newNode;
        }
        static void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + "-");
                Preorder(root.left);
                Preorder(root.right);
            }
        }
        static void Inorder(Node root)
        { 
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }
        static void Main(string[] args)
        {
            Node node4 = CreateNode(4, null, null);
            Node node5 = CreateNode(5, null, null);
            Node node6 = CreateNode(6, null, null);
            Node node7 = CreateNode(7, null, null);
            Node node2 = CreateNode(2, node4, node5);
            Node node3 = CreateNode(3, node6, node7);
            Node node1 = CreateNode(1, node2, node3);

            // Preorder(node1);
            Inorder(node1);
        }
    }
}
