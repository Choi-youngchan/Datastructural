using System.Linq;

namespace Program
{
    public class Stack<T>
    {
        private int top;

        private readonly int arraySize;
        private T [] array;
        private T error;

        public Stack()
        {
            top = -1;
            arraySize = 10;

            array = new T[arraySize];
        }
        public void Push(T data)
        {
            if (top < arraySize - 1)
            {
                array[++top] = data;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }
       public T Peek()
       {
           return array[top];
       }
       public T Pop() 
       {
           if (arraySize > 0)
           {
               return array[top--];
           }
           else
           {
                Console.WriteLine("Stack is Empty");
                return error;
           }
       }
        public bool Contains(T data)
        {
            for (int i = 0; i <= top; i ++)
            {
                if (array[i].ToString() == data.ToString())
                {
                    return true;
                }
            }
            return false;
        }
         static bool CheckBracket(string content)
         {
             // content "{" "[" "(" ")" "]" "}";
             Stack<char> stack = new Stack<char>();
            //  (content.Contains() == true;)
             if (Contains(content) == true)
             {
                 if ( content == "{" ) 
                    { stack.Push('{'); }
                 else if (content ==  "[")
                    { stack.Push('['); }
                 else if (content == "(") 
                    { stack.Push('('); }
             }
         
         }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
             Stack<int> stack = new Stack<int>();
             stack.Push(1);
             stack.Push(2);
             stack.Push(3);
             stack.Push(4);
             stack.Push(5);
             stack.Pop();
             Console.WriteLine(stack.Contains(5));

        }
    }
}
