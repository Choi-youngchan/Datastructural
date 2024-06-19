namespace Class7th__Vector_
{
    public class Vector<T>
    {
        private int size;
        private int capacity;
        private T[] array;
        public Vector()
        {
            size = 0;
            capacity = 0;
            array = null;
        }
        public void Resize(int newSize)
        {
            capacity = newSize;
            T[] newArray = new T[capacity];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public void Add(T data)
        {
            if (capacity <= 0)
            {
                Resize(1);
            }
            else if (size >= capacity)
            {
                Resize(capacity * 2);
            }
            array[size++] = data;
        }
        public void RemoveAt(int index)
        {
            //  for (int i = 0; i < size; i++) 
            //  { 
            //      array[index+i] = array [index+i + 1];
            //  }
            //  size--;
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = default;
            size--;
        }
        public void Reserve(int newSize)
        {
            if (newSize < capacity)
            {
                return;
            }
            else
            {
                Resize(newSize);
            }
        }

        public T this[int index]
        {
            get { return array[index]; }
        }
        public int Count()
        {
            return size;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector<int> vector = new Vector<int>();
            vector.Reserve(10);

            vector.Add(10);
            vector.Add(20);
            vector.Add(30);

            vector.RemoveAt(1);

            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine(vector[i]);
            }

        }
    }
}
