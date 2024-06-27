namespace Class14th___Graph_Adjacency_List_
{
    public class AdjacencyList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
            public Node(T data, Node link = null)
            {
                this.data = data;
                next = link;
            }
        }
        private int size;
        private int arraySize;
        private T[] vertex;
        private Node[] list;
        public AdjacencyList()
        {
            size = 0;
            arraySize = 10;
            vertex = new T[arraySize];
            list = new Node[arraySize];
            // for(int i =  0; i < arraySize; i++)
            // {
            //     list[i] = new Node();
            // }
        }
        public void Insert(T data)
        {
            if (size >= arraySize)
            {
                Console.WriteLine("AdjacencyList Overflow");
                return;
            }
            vertex[size++] = data;

        }
        public void Connect(int u, int v)
        {
            if (size <= 0)
            {
                Console.WriteLine("AdjacencyList is Empty");
                return;
            }
            if (u >= size || v >= size)
            {
                Console.WriteLine("Index Out of Range");
                return;
            }
            list[u] = new Node(vertex[v], list[u]);
            list[v] = new Node(vertex[u], list[v]);
        }
        public void Show()
        {
            // for (int i = 0; i < size; i++)
            // {
            //     Node currentNode = list[i];
            //     while (currentNode != null)
            //     {
            //         Console.Write(vertex[i] + " : " + list[i].data + " - ");
            //         currentNode = currentNode.next;
            //     }
            //     Console.WriteLine();
            // }
            for (int i = 0; i < size; i++)
            {
                Console.Write(vertex[i] + " : ");
                Node currentNode = list[i];

                while (currentNode != null)
                {
                    Console.Write(currentNode.data + "  ");
                    currentNode = currentNode.next;
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인접 리스트
            // 그래프의 각 정점에 인접한 정점들을 연결 리스트로 표현하는 방법입니다.

            // 장점
            // 그래프의 모든 간선의 수를 O(V+E)로 표현할 수 있습니다.

            //단점
            // 두 정점을 연결하는 간선을 조회하거나 정점의 차수를 알기 위해서 정점의 인접리스트를 모두 탐색해야 하므로,
            // 정점의 차수만큼의 시간이 필요합니다.
            AdjacencyList<char> graph = new AdjacencyList<char>();

            graph.Insert('A');
            graph.Insert('B');
            graph.Insert('C');
            graph.Insert('D');

            graph.Connect(0, 1);
            graph.Connect(0, 2);
            graph.Connect(2, 3);

            graph.Show();


            #endregion
        }
    }
}
