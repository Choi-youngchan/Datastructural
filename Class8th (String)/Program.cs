namespace Class8th__String_
{
    public class String
    {
        private char[] array;
        private int error = -99999;
        public String()
        {
            array = null;
        }
        public void Add(char[] content)
        {
            array = new char[content.Length + 1];
            for (int i = 0; i < content.Length; i++)
            {
                array[i] = content[i];
            }
        }
        public void Concat(char[] content)
        {
            {
                char[] newArray = new char[array.Length + content.Length];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    newArray[i] = array[i];
                }
                for (int i = 0; i < content.Length; i++)
                {
                    newArray[(array.Length - 1) + i] = content[i];
                }
                array = newArray;
            }
        }
        public bool Equals(char[] content)
        {
            if (array == null)
            {
                return false;
            }
            else if (array.Length != content.Length + 1)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (content[i] == array[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public int IndexOf(char letter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return error;
        }
        public int Size()
        {
            return array.Length - 1;
        }
        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            String name = new String();
            char[] janna = new char[] { 'J', 'a', 'n', 'n', 'a' };
            char[] of = new char[] { 'o', 'f' };
            name.Add(janna);
            name.Concat(of);
            name.Show();
            Console.WriteLine();
            Console.WriteLine(name.Size());

            Console.WriteLine(name.IndexOf('o'));
            Console.WriteLine(name.Equals(new char[] { 'J', 'a', 'n', 'n', 'a', 'o', 'f' }));

        }
    }
}

