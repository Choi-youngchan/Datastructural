namespace Class3th__Circle_Linked_List_
{
    public class CircleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }
        private int size;
        private Node head;
        public CircleLinkedList()
        {
            size = 0;
            head = null;
        }
        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {

                if (head.next == head)
                {
                    head = null;
                }
                else
                {
                    head.next = head.next.next;
                }
                size--;
            }
        }
        public void RemoveBack()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (head.next == head)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;
                    for (int i = 0; i < size - 1; i++)
                    {
                        currentNode = currentNode.next;
                    }
                    currentNode.next = head.next;
                    head = currentNode;
                }
                size--;
            }
        }
        public void PushFront(T data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (size == 0)
            {
                head = newNode;
                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
            }
            size++;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();
            if (size == 0)
            {
                head = newNode;
                newNode.next = head;
                newNode.data = data;
            }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
                head = newNode;
                newNode.data = data;
            }
            size++;
        }
        public int Size()
        {
            return size;
        }
        public void Show()
        {
            if (head != null)
            {
                Node currentNode = head.next;

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();
            circleLinkedList.PushBack(10);
            circleLinkedList.PushBack(20);
            circleLinkedList.PushBack(30);
            circleLinkedList.PushFront(12);
            circleLinkedList.PushFront(11);
            circleLinkedList.RemoveFront();
            circleLinkedList.RemoveBack();

            circleLinkedList.Show();
            Console.WriteLine(circleLinkedList.Size());

        }
    }
}
