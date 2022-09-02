namespace OOP
{
    class Man
    {
        public virtual void Speaks()
        {
            Console.WriteLine("Gently speaks...");
        }

    }

    class AngryMan : Man
    {
        public override void Speaks()
        {
            Console.WriteLine("Speaks rudely...");
        }

    }

    class Calculate
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Integer addition");
            return a + b;
        }

        public float Add(float a, float b)
        {
            Console.WriteLine("Floating Point addition");
            return a + b;
        }

        public string Add(string a, string b)
        {
            Console.WriteLine("String concatination");
            return a + b;
        }
    }
}
