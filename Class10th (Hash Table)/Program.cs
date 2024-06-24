namespace Class10th__Hash_Table_
{
    public class HashTable<KEY, VALUE>
    {
        private class Bucket
        {
            public int count;
            public Node head;
        }
        private class Node
        {
            public KEY key;
            public VALUE value;

            public Node next;
        }
        private Bucket[] bucket;
        private readonly int arraySize;
        public HashTable()
        {
            arraySize = 6;
            bucket = new Bucket[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                bucket[i] = new Bucket();
            }
        }
        int HashFuction(KEY key)
        {
            return int.Parse(key.ToString()) % 6;
        }
        Node CreateNode(KEY key, VALUE value)
        {
            Node newNode = new Node();
            newNode.key = key;
            newNode.value = value;
            newNode.next = null;
            return newNode;
        }
        public void Insert(KEY key, VALUE value)
        {
            // 해시 함수를 통해서 값을 받는 임시 변수
            // 새로운 노드 생성
            // 노드가 존재하지않는다면
            // 1. bucket[hashIndex]의 head 포인터에 새로운 노드를 저장한다.
            // 1. newNode의 next에 bucket[hashIndex]의 head의 값을 저장한다.
            // 2. bucket[hashIndex].head를 방금생성한 노드의 주소를 가리키게한다.
            // 3. 카운트를 증가시킨다.
            int hashIndex = HashFuction(key);
            Node newNode = CreateNode(key, value);
            if (bucket[hashIndex].count <= 0)
            {
                bucket[hashIndex].head = newNode;
                bucket[hashIndex].count++;
            }
            else // 노드가 1개라도 존재한다면
            {
                newNode.next = bucket[hashIndex].head;
                bucket[hashIndex].head = newNode;
                bucket[hashIndex].count++;
            }
        }
        public void Remove(KEY key)
        {
            // int hashIndex = HashFuction(key);
            // Node currentNode = bucket[hashIndex].head;
            // Node previousNode = new Node();
            // if (bucket[hashIndex].head == null)
            // {
            //     Console.WriteLine("null");
            // }
            // else if (bucket[hashIndex].head != null)
            // {
            //     for(int i = 0; i < bucket[hashIndex].count; i ++)
            //     {
            //         if (currentNode.key.ToString != key.ToString)
            //         {
            //             previousNode = currentNode;
            //             currentNode = currentNode.next;
            //         }
            //         else if(currentNode.key.ToString == key.ToString)
            //         {
            //             if(currentNode.next == null)
            //             {
            //                 currentNode = null;
            //             }
            //             else
            //             {
            //                 previousNode.next = currentNode.next;
            //                 currentNode = previousNode;
            //             }
            //         }
            //     }
            // }
            // ------------------------------------------------------------------
            // 1. 해쉬 함수를 통해서 값을 받는 임시 변수
            int hashIndex = HashFuction(key);
            // 2. Node를 탐색할 수 있는 순회용 포인터 선언
            Node currentNode = bucket[hashIndex].head;
            // 3. 이전 노드를 저장할 수 있는 포인터 변수
            Node previouseNode = null;
            // 4. currentNode가 null 과 같다면 함수를 종료
            if (currentNode == null)
            {
                Console.WriteLine("Hash Table is Empty");
                return;
            }
            // 5. currentNode를 이용해서 내가 찾고자하는 key값을 찾습니다
            while (currentNode != null)
            {
                if (currentNode.key.ToString == key.ToString)
                {
                    //내가 삭제하고자 하는 key 가 head 노드라면
                    if (currentNode == bucket[hashIndex].head)
                    {
                        bucket[hashIndex].head = currentNode.next;
                    }
                    else
                    {
                        previouseNode.next = currentNode.next;
                    }
                    bucket[hashIndex].count--;
                    return;
                }
                else
                {
                    previouseNode = currentNode;
                    currentNode = currentNode.next;
                }
                Console.WriteLine("Not key Found");
            }
        }
        public void Show()
        {

            // for (int i = 0;i < bucket.Length;i++)
            // {
            //     Node currentNode = bucket[i].head;
            // 
            //     if (currentNode == null)
            //     {
            //         
            //     }
            //     else if ( currentNode.next == null)
            //     {
            //         Console.WriteLine(currentNode.value);
            //     }
            //     else
            //     {
            //         while (currentNode.next != null)
            //         {
            //             Console.WriteLine(currentNode.value);
            //             currentNode = currentNode.next;
            //         }
            //     }
            // }
            for (int i = 0; i < arraySize; i++)
            {
                Node currentNode = bucket[i].head;
                while (currentNode != null)
                {
                    Console.Write("[" + i + "]" + " KEY : " + currentNode.key + " VALUE : " + currentNode.value + " ");
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
            HashTable<int, string> hashTable = new HashTable<int, string>();
            hashTable.Insert(0, "Mart");
            hashTable.Insert(1, "Market");
            hashTable.Insert(7, "Shop");
            hashTable.Insert(2, "Mall");

            hashTable.Remove(0);

            hashTable.Show();
        }
    }
}
