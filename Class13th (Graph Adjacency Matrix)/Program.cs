namespace Class13th__Graph_Adjacency_Matrix_
{
    public class AdjacencyMatrix<T>
    {
        private int size; // 정점의 갯수
        private int arraySize;
        private T[] vertex; // 정점의 집합
        private int[,] matrix;
        public AdjacencyMatrix()
        {
            size = 0;
            arraySize = 10;
            vertex = new T[arraySize];
            matrix = new int[arraySize, arraySize];
        }
        public void Insert(T data)
        {
            if (size >= arraySize)
            {
                Console.WriteLine("AdjacencyMatrix is Full");
                return;
            }
            vertex[size] = data;
            size++;
        }
        public void Connect(int i, int j)
        {
            if (size <= 0)
            {
                Console.WriteLine("AdjacencyMatrix is Empty");
            }
            else if (i < size && j < size)
            {
                matrix[i, j] = 1; matrix[j, i] = 1;
            }
            else
            {
                Console.WriteLine("Out of Range");
            }
        }
        public void Show()
        {
            if (size <= 0)
            {
                return;
            }
            else
            {
                Console.Write("    ");
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(vertex[i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write(vertex[i] + " : ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            // for(int i = 0; i < size; i++)
            // {
            //     for(int j = 0; j < size; j++)
            //     {
            //         Console.Write(matrix[i, j]);
            //     }
            //     Console.WriteLine();
            // }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 그래프
            // 요소들이 서로 복잡하게 연결되어 있는 관계를 표현하는 자료 구조이며,
            // 정점과 간선들의 집합으로 구성되어 있습니다.

            // 정점 (Vertex) : 노드(Node) 데이터가 저장되는 그래프의 기본 원소입니다.
            // 간선 (Edge) : 노드들을 연결하는 선입니다.
            // 인접 정점 (Adjacent Vertex) : 간선으로 직접 연결된 정점을 의미합니다.
            // 차수 (Degree) : 정점에 연결된 간선의 수 를 의미합니다.
            // 경로 (Path) : 정점들을 연결하는 간선들이 순서입니다.
            // 그래프의 종류 
            // 1. 무방향 그래프 : 간선에 방향이 없는 그래프입니다.
            // 2. 방향 그래프 : 간선에 방향이 있는 그래프입니다.
            // 3. 가중치 그래프 : 간선에 가중치가 있는 그래프입니다.
            #endregion

            #region 인접 행렬
            // 정점들 간의 연결 관계를 2차원 배열로 표현하는 방식입니다.
            // 정점의 개수가 V일때 V * V 크기의 2차원 배열을 사용합니다.

            // 장점
            // 1. 두 정점이 연결되어 있는지 확인하기 쉽습니다.
            // 2. 두 정점 사이의 간선의 가중치를 쉽게 확인할 수 있습니다.

            // 단점
            // 1. 정점의 개수가 많을 때 메모리 낭비가 심합니다.

            AdjacencyMatrix<char> matrix = new AdjacencyMatrix<char>();
            matrix.Insert('A');
            matrix.Insert('B');
            matrix.Insert('C');
            matrix.Insert('D');

            matrix.Connect(2, 3);
            matrix.Connect(0, 1);
            matrix.Connect(0, 2);
            matrix.Show();

            #endregion
        }
    }
}
