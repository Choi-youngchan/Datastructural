
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class HashTable<KEY,VALUE>
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
            int hashIndex = HashFuction(key);
            // 새로운 노드 생성
            Node newNode = CreateNode(key, value);
            // 노드가 존재하지않는다면
            if (bucket[hashIndex].count <= 0 )
            {
                // 1. bucket[hashIndex]의 head 포인터에 새로운 노드를 저장한다.
                bucket[hashIndex].head = newNode;
                bucket[hashIndex].count++;
            }
            else // 노드가 1개라도 존재한다면
            {
                // 1. newNode의 next에 bucket[hashIndex]의 head의 값을 저장한다.
                // 2. bucket[hashIndex].head를 방금생성한 노드의 주소를 가리키게한다.
                // 3. 카운트를 증가시킨다.
                newNode.next = bucket[hashIndex].head;
                bucket[hashIndex].head = newNode;
                bucket[hashIndex].count++;
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
            for(int i = 0;i < arraySize;i++)
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
            HashTable<int,string> hashTable = new HashTable<int,string>();
            hashTable.Insert(0, "Mart");
            hashTable.Insert(1, "Market");
            hashTable.Insert(1, "Shop");
            hashTable.Insert(2, "Mall");
            hashTable.Show();
        }
    }
}
