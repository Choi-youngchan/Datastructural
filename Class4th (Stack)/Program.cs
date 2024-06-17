namespace Class4th__Stack_
{
    public class Stack<T>
    {
        private int top;

        private readonly int arraySize;
        private T[] array;
        private T error;
        private int count;

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
                count++;
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
                count--;
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
            for (int i = 0; i <= top; i++)
            {
                if (array[i].ToString() == data.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public int Count()
        {
            return count;
        }
    }

    internal class Program
    {
        static bool CheckBracket(string content)
        {
            if (content.Length <= 0)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < content.Length; i++)
            {
                char character = content[i];
                if (character == '{' || character == '[' || character == '(')
                {
                    stack.Push(character);
                }
                else if (character == '}' || character == ']' || character == ')')
                {
                    char bracket = stack.Pop();

                    if (bracket == '(' && character != ')')
                    { return false; }
                    if (bracket == '{' && character != '}')
                    { return false; }
                    if (bracket == '[' && character != ']')
                    { return false; }
                }
            }
            if (stack.Count() <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);
            // stack.Pop();
            // Console.WriteLine(stack.Contains(4));
            bool flag = CheckBracket("");

            Console.WriteLine(flag);

        }
    }
}
