namespace Class5th__Linear_Queue_
{
    public class LinearQueue<T>
    {
        private T[] array;

        private int front;
        private int rear;
        private int count;
        private T error;

        private readonly int arraySize;

        public LinearQueue()
        {
            front = 0;
            rear = 0;
            count = 0;
            arraySize = 5;

            array = new T[arraySize];
        }
        public void EnQuque(T data)
        {
            if (rear >= arraySize)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                array[rear++] = data;

                count++;
            }
        }
        public T DeQueue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return error;
            }
            else
            {
                T data = array[front];

                array[front] = default;

                array[front++] = data;
                count--;

                return data;
            }
        }
        public T Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return error;
            }
            else
            {
                return array[front];
            }
        }
        public int Count()
        {
            return count;
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
            LinearQueue<int> linearQueue = new LinearQueue<int>();
            linearQueue.EnQuque(10);
            linearQueue.EnQuque(20);
            linearQueue.EnQuque(30);
            linearQueue.EnQuque(40);
            linearQueue.EnQuque(50);

            Console.WriteLine(linearQueue.DeQueue());


            // linearQueue.Show();
        }
    }
}
