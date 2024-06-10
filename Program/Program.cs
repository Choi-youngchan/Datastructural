using System.Reflection;

namespace Program
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

        public void PushFront(T data)
        {
            // head.next = null;

            // if (size == 0)

            if(head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else if(head != null)
            {
                Node newNode = new Node();
                newNode.next = head;
                newNode.data = data;
                head = newNode;
            }
            size++;
        }
        public void Show()
        {
               Node currentNode = head;
               
               while(currentNode != null)
               {
                   Console.WriteLine(currentNode.data);
                   currentNode = currentNode.next;
               }
            // ---------------------------------
            //   Node currentNode = new Node();
            //   currentNode = head;
            //  if (currentNode.data != null)
            //      for (int i = 0; i < size; i++)
            //       {
            //          currentNode = currentNode.next;
            //          Console.WriteLine(currentNode.data);
            //       }
            // 
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
            singlinkedlist.Show();
            Console.WriteLine(singlinkedlist.Size());
        }
    }
}
