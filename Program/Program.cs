using System.Reflection;

namespace Program
{
    public class DoubleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node previous;
            public Node next;
        }
        private Node head;
        private Node tail;
        private int size;

        public DoubleLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }
        public Node First()
        {
            return head;
        }
        public Node Last()
        {
            return tail;
        }
        public void AddAfter(Node position, T data)
        {
            Node previousNode = new Node();
            Node nextNode = new Node();
            Node newNode = new Node();


            if (position.next == null)
            {
                PushBack(data);
            }
            else
            {
                previousNode = position;
                nextNode = position.next;
                position.next = newNode;
                newNode.previous = previousNode;
                newNode.next = nextNode;
                nextNode.previous = newNode;
                newNode.data = data;
                size++;
            }
        }


        public void RemoveBack()
        {
            if (tail == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                if (head == tail)
                {
                    tail = tail.next;
                    head = tail;
                }
                else
                {
                    tail.previous.next = null;

                    tail = tail.previous;
                    // tail = tail.previous;
                    // tail.next = null;
                }
                size--;
            }
        }
        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                if (head == tail)
                {
                    head = head.previous;
                    tail = head;
                }
                else
                {
                     head.next.previous = null;
                     head = head.next;
                    //  head = head.next;
                    //  head.previous = null;
                }
                size--;
            }
        }
        public void PushBack(T data)
        {
            Node newNode = new Node();
            if (tail == null)
            {
                tail = newNode;
                head = newNode;
                newNode.data = data;
                newNode.previous = null;
                newNode.next = null;

            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;

                tail = newNode;

                newNode.data = data;
                newNode.next = null;
            }
            size++;
        }
        public void PushFront(T data)
        {
            if (head == null)
            {
                
                head = new Node();
                tail = head;
                head.previous = null;
                head.next = null;

                head.data = data;
            }
            else
            {
                Node newNode = new Node();
                newNode.next = head;

                head.previous = newNode;
                head = newNode;
                newNode.previous = null;

                newNode.data = data;
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
            DoubleLinkedList<int> doubleL= new DoubleLinkedList<int>();
            
            doubleL.PushFront(30);
            doubleL.PushFront(20);
            doubleL.PushFront(10);
            DoubleLinkedList<int>.Node node = doubleL.First();
           
            doubleL.AddAfter(node.next, 99);
            doubleL.Show();
            Console.WriteLine(doubleL.Size());


        }
    }
}
