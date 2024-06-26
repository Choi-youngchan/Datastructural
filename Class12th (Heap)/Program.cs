namespace Class12th__Heap_
{
    public class Heap
    {
        private int size;
        private int arraySize;
        private int[] array;
        int error = -99999;
        public Heap()
        {
            size = 0;
            arraySize = 8;
            array = new int[arraySize];
        }
        public void Insert(int data)
        {
            // if (size == arraySize)
            // {
            //     Console.WriteLine("full");
            // }
            // else if (size <arraySize)
            // {
            //     array[++size] = data;
            //     int child = size;
            //     int parent = size / 2;
            //     if (parent >= 1)
            //     {
            //         while (array[child] > array[parent])
            //         {
            //             Swap(ref child, ref parent);
            //         }
            //         array[child] = array[child];
            //         array[parent] = array[parent];
            //     }
            // 
            // }
            // -------------------------------------------
            if (size >= arraySize - 1)
            {
                Console.WriteLine("Heap is full");
            }
            else
            {
                array[++size] = data;
                int child = size;
                int parent = size / 2;
                while (child > 1)
                {
                    if (array[child] > array[parent])
                    {
                        Swap(ref array[child], ref array[parent]);
                    }
                    child = parent;
                    parent = child / 2;
                }
            }
        }
        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void Show()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public int Remove()
        {
            if (size <= 0)
            {
                Console.WriteLine("Heap is Empty");
                return error;
            }
            else
            {
                int value = array[1];
                array[1] = array[size];
                array[size] = 0;
                size--;
                // int parent = 1;
                // int childLeft = parent * 2;
                // int childRight = parent * 2 + 1;
                // 
                // while (parent == 1)
                // {
                //     if (array[childLeft] > array[parent] || 
                //         array[childRight] > array[parent])
                //     {
                //         if(array[childLeft] > array[childRight])
                //         {
                //             Swap(ref array[parent], ref array[childLeft]);
                //             childLeft = parent;
                //             parent = childLeft / 2;
                // 
                //         }
                //         else if (array[childRight] > array[childLeft])
                //         {
                //             Swap(ref array[parent], ref array[childRight]);
                //             childRight = parent;
                //             parent = childRight / 2;
                //         }
                //     }
                //     else if(array[childLeft] < array[parent] &&
                //             array[childRight] < array[parent])
                //     {
                //         break;
                //     }
                // }
                // return value;
                // --------------------------------
                int parent = 1;
                while (parent * 2 <= size)
                {
                    int child = parent * 2;
                    // 왼쪽 자식 노드보다 오른쪽 자식 노드 더 클때
                    if (array[child] < array[child + 1])
                    {
                        child++;
                    }
                    // 부모 노드의 key갑이 자식 노드의 key값 보다 크면 반복문을 종료합니다.
                    if (array[child] < array[parent])
                    {
                        break;
                    }
                    Swap(ref array[parent], ref array[child]);
                    parent = child;
                }
                return value;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();
            heap.Insert(10);
            heap.Insert(11);
            heap.Insert(12);
            heap.Insert(9);
            heap.Insert(8);
            heap.Insert(13);
            heap.Insert(15);
            Console.WriteLine("TOP : " + heap.Remove());
            Console.WriteLine("TOP : " + heap.Remove());
            Console.WriteLine("TOP : " + heap.Remove());
            Console.WriteLine("TOP : " + heap.Remove());
            Console.WriteLine("TOP : " + heap.Remove());
            Console.WriteLine("TOP : " + heap.Remove());

            heap.Show();
        }
    }
}
