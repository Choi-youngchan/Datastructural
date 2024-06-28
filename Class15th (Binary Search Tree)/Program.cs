namespace Class15th__Binary_Search_Tree_
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
                    if (currentNode.data > data)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
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
        public void Remove(int data)
        {
            // Node currentNode = root;
            // Node parentNode = null;
            // while (currentNode != null)
            // {
            //     if (currentNode.data == data)
            //     {
            //         if (currentNode.left == null && currentNode.right == null) 
            //         {
            //             if (parentNode.left.data == data)
            //             {
            //                 parentNode.left = null;
            //                 break;
            //             }
            //             else
            //             {
            //                 parentNode.right = null;
            //                 break;
            //             }
            //         }
            //     }
            //     else
            //     {
            //         if (currentNode.data > data)
            //         {
            //             parentNode = currentNode;
            //             currentNode = currentNode.left;
            //         }
            //         else
            //         {
            //             parentNode = currentNode;
            //             currentNode = currentNode.right;
            //         }
            //     }
            // }
            // Console.WriteLine("Cannot Find Data");
            // ------------------------------------------------------------
            Node currentNode = root;
            Node parentNode = null;
            if (currentNode == null)
            {
                Console.WriteLine("BinarySearchTree is Empty");
            }
            else
            {
                while (currentNode.data != data)
                {
                    parentNode = currentNode;
                    if (currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                    if (currentNode == null)
                    {
                        break;
                    }
                }
            }
            if (currentNode == null)
            {
                Console.WriteLine("Cannot Find Data");
            }
            else
            {
                if (currentNode.left == null && currentNode.right == null)
                {
                    if (parentNode != null)
                    {
                        if (parentNode.left == currentNode)
                        {
                            parentNode.left = null;
                        }
                        else
                        {
                            parentNode.right = null;
                        }
                    }
                    else
                    {
                        root = null;
                    }
                }
                else if (currentNode.left == null || currentNode.right == null)
                {
                    if (parentNode.right == currentNode)
                    {
                        if (currentNode.right == null)
                        {
                            parentNode.right = currentNode.left;
                        }
                        else
                        {
                            parentNode.right = currentNode.right;
                        }
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            parentNode.left = currentNode.left;
                        }
                        else
                        {
                            parentNode.left = currentNode.right;
                        }
                    }
                }
                else
                {
                    //  Node traceNode = currentNode.right;
                    //  Node findNode = traceNode.left;
                    //  while(findNode.left != null)
                    //  {
                    //      traceNode = findNode;
                    //      findNode = findNode.left;
                    //  }
                    //  currentNode.data = findNode.data;
                    //  traceNode.left = findNode.right;
                    // ----------------------------------------
                    Node findNode = currentNode.right;
                    Node traceNode = findNode;
                    while (findNode.left != null)
                    {
                        traceNode = findNode;
                        findNode = findNode.left;
                    }
                    currentNode.data = findNode.data;

                    traceNode.left = findNode.right;
                }
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            // binarySearchTree.Insert(10);
            // binarySearchTree.Insert(7);
            // binarySearchTree.Insert(15);
            // binarySearchTree.Insert(5);
            // binarySearchTree.Insert(8);
            // binarySearchTree.Insert(14);
            // binarySearchTree.Insert(22);
            // 
            // 
            // binarySearchTree.Remove(22);
            // binarySearchTree.Remove(5);
            // 
            // binarySearchTree.Remove(15);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(19);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(21);


            binarySearchTree.Remove(19);

            binarySearchTree.Inorder(binarySearchTree.root);
            // Console.WriteLine();
            // 
            // Console.WriteLine("BinarySearchTree FInd ( 9 ) : " + binarySearchTree.Find(9));
            // Console.WriteLine("BinarySearchTree FInd ( 11 ) : " + binarySearchTree.Find(11));

        }
    }
}
