using System.Linq;

namespace Program
{
    public class CircleQueue<T>
    {
        private int front;
        private int rear;
        private int count;

        private readonly int arraySize;
        T[] array;

        public CircleQueue()
        {
            arraySize = 5;
            front = arraySize - 1;
            rear = arraySize - 1;

            count = 0;
            array = new T[arraySize];
        }
        public void EnQueue(T data)
        {
            if (rear < 5 )
            {
                array[rear++] = data;
                //array[front] = default;
                
                count++;

            }
            else
            {
                rear = rear % 5;
                array[rear++] = data;
                array[front] = array[rear - 1];
                // if (rear == 0)
                // {
                //     front = 4;
                // }
                // else
                // {
                //     front = rear - 1;
                // }
                count = (count % 5) + 1;
            }
        }
        public T Peek()
        {
            return array[front];
        }
        public void Show()
        {
            for (int i = front; i < rear; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CircleQueue<int> queue = new CircleQueue<int>();
            queue.EnQueue(10);
            //queue.EnQueue(20);
            //queue.EnQueue(30);
            //queue.EnQueue(40);
            //
            //queue.Peek();
             queue.Show();
        }
    }
}
