namespace MultipleInheritance
{

    interface A
    {
        void Number();
    }
    class B 
    {
        public void Show()
        {
            Console.WriteLine("class method");
        }
    }
    class C : B, A
    {
        public void Number()
        {
            Console.WriteLine("Interface method");
            //throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C  a1 = new C();
            a1.Show();
            a1.Number();
            Console.ReadLine();
            //Console.WriteLine("Hello, World!");
        }
    }
}
