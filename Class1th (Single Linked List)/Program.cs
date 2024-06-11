namespace Class1th__Single_Linked_List_
{
    public class SingleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }

        Node head;
        private int size;

        public SingleLinkedList()
        {
            size = 0;
            head = null;
        }
        public void RemoveFront()
        {
            if (head != null)
            {
                head = head.next;
                size--;
            }
            else
            {
                Console.WriteLine("LinkedList is Empty");
            }
        }
        public void RemoveBack()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                if (size == 1)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;
                    Node previousNode = currentNode;

                    while (currentNode.next != null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    previousNode.next = currentNode.next;
                }
                size--;
            }
        }
        public void PushFront(T data)
        {
            // head.next = null;

            // if (size == 0)

            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else if (head != null)
            {
                Node newNode = new Node();
                newNode.next = head;
                newNode.data = data;
                head = newNode;
            }
            size++;
        }
        public void PushBack(T data)
        {
            if (head == null)
            {
                Node newNode = new Node();
                head = newNode;
                newNode.data = data;
                newNode.next = null;
            }
            else
            {
                Node currentNode = head;
                Node newNode = new Node();

                if (currentNode.next == null)
                {
                    newNode.data = data;
                    currentNode.next = newNode;
                }
                else
                {
                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    newNode.data = data;
                    currentNode.next = newNode;
                }

            }
            size++;
        }
        public void Show()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
            // ---------------------------------
            // Node currentNode = new Node();
            // currentNode = head;
            //
            //    for (int i = 0; i < size; i++)
            //     {
            //        if (currentNode.data != null)
            //        currentNode = currentNode.next;
            //        Console.WriteLine(currentNode.data);
            //     }

        }
        public int Size()
        {
            return size;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singlinkedlist = new SingleLinkedList<int>();
            singlinkedlist.PushFront(30);
            singlinkedlist.PushFront(20);
            singlinkedlist.PushFront(10);

            singlinkedlist.RemoveFront();
            singlinkedlist.RemoveFront();
            singlinkedlist.RemoveFront();

            singlinkedlist.PushBack(30);
            singlinkedlist.PushBack(20);
            singlinkedlist.PushBack(10);

            singlinkedlist.RemoveBack();



            Console.WriteLine(singlinkedlist.Size());
            singlinkedlist.Show();


        }
    }
}
