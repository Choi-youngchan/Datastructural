namespace Class6th__Circle_Queue_
{
    public class CircleQueue<T>
    {
        private int front;
        private int rear;
        private int count;
        private T error;

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
            if (front == (rear + 1) % arraySize)
            {
                Console.WriteLine("Circle Queue is Full");
            }
            else
            {
                rear = (rear + 1) % arraySize;
                array[rear] = data;
                count++;
            }
        }
        public T DeQueue()
        {
            if (front == rear)
            {
                Console.WriteLine("Circle Queue is Empty");
                return error;
            }
            else
            {
                front = (front + 1) % arraySize;
                count--;
                return array[front];
            }
        }
        public T Peek()
        {
            return array[(front + 1) % arraySize];
        }
        public int Size()
        {
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CircleQueue<int> queue = new CircleQueue<int>();
            queue.EnQueue(10);
            queue.EnQueue(20);
            queue.EnQueue(30);
            queue.EnQueue(40);
            while (queue.Size() != 0)
            {
                Console.WriteLine(queue.DeQueue());
            }
            List<int> list = new List<int>();
            list.reve
        }
    }
}
