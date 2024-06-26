namespace Program
{
    public class AdjacencyList<T>
    {
        private class Node
        {
            private T data;
            private Node next;
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
            if(size >= arraySize) 
            {
                Console.WriteLine("Full");
                    return;
            }
            vertex[size] = data;
            size++;
        }
        public void Connect(int x, int y)
        {
            list[x] = vertex[y];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인접 리스트
            // 그래프의 각 정점에 인접한 정점들을 연결 리스트로 표현하는 방법입니다.

            // 장점
            // 그래프의 모든 간선의 수를 O(V+E)로 표현할 수 있습니다ㅏ.

            //단점
            // 두 정점을 연결하는 간선을 조회하거나 정점의 차수를 알기 위해서 정점의 인접리스트를 모두 탐색해야 하므로,
            // 정점의 차수만큼의 시간이 필요합니다.

            #endregion
        }
    }
}
