using System.Reflection;

namespace Program
{
    public class DoubleLinkedList<T>
    {
        private class Node
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


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLL= new DoubleLinkedList<int>();
            
            doubleLL.PushBack(10);

            Console.WriteLine(doubleLL.data);

        }
    }
}
