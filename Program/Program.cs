
namespace Program
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
        public void PushBack(T data)
        {
            Node newNode = new Node();
            if (size == 0)
            {
                head = newNode;
                newNode.next = head;
                newNode.data = data;
            }
            // else if (size == 1)
            // {
            //     newNode = head.next;
            //     newNode.next = head;
            //     head = newNode;
            //     newNode.data = data;
            // }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
                head = newNode;
                newNode.data = data;
            }
            size++;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
