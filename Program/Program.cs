namespace Program
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node()
            {
                data = default;
            }
        }
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            // if (root == null)
            // {
            //     root = CreateNode(data);
            // }
            // else
            // {
            //     Node currentNode = root;
            //     if (currentNode.data == data)
            //     {
            //         return;
            //     }
            //     if (currentNode.data > data)
            //     {
            //         if (currentNode.left == null)
            //         {
            //             currentNode.left = CreateNode(data);
            //         }
            //         else if (currentNode.left != null)
            //         {
            //             currentNode = currentNode.left;
            //             Insert(data);
            //         }
            //     }
            //     else if (currentNode.data < data)
            //     {
            //         if (currentNode.right == null)
            //         {
            //             currentNode.right = CreateNode(data);
            //         }
            //         else if (currentNode.right != null)
            //         {
            //             currentNode = currentNode.right;
            //             Insert(data);
            //         }
            //     }
            // }
            // -----------------------------------------------
            if (root == null)
            {
                root = CreateNode(data);
            }
            else
            {
                Node currentNode = root;
                while (currentNode != null)
                {
                    if(currentNode.data > data)
                    {
                        if(currentNode.left == null)
                        {
                            currentNode.left = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode= currentNode.left;
                        }
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }
        Node CreateNode(int data)
        {
            Node node = new Node();
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }
        public bool Find(int data)
        {
            // Node currentNode = root;
            // if (currentNode == null)
            // {
            //     Console.WriteLine("Empty");
            //     return false;
            // }
            // if (currentNode.data == data)
            // {
            //     return true;
            // }
            // else
            // {
            //     while (currentNode != null)
            //     {
            //         if (currentNode.data > data)
            //         {
            // 
            //             if (currentNode.data == data)
            //             {
            //                 return true;
            //             }
            //             else
            //             {
            //                 currentNode = currentNode.left;
            //             }
            // 
            //         }
            //         else if (currentNode.data < data)
            //         {
            //             if (currentNode.data == data)
            //             {
            //                 return true;
            //             }
            //             else
            //             {
            //                 currentNode = currentNode.right;
            //             }
            // 
            //         }
            //     }
            // }
            // return false;
            // ------------------------------------------------------
            Node currentNode = root;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return true;
                }
                else
                {
                    if (currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
            return false;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(9);
            binarySearchTree.Inorder(binarySearchTree.root);

            Console.WriteLine();

            Console.WriteLine("BinarySearchTree FInd ( 9 ) : " + binarySearchTree.Find(9));
            Console.WriteLine("BinarySearchTree FInd ( 11 ) : " + binarySearchTree.Find(11));

        }
    }
}
