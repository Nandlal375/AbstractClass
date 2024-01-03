namespace InterfaceClass
{
    interface IEmployee 
    {
        static int a;
        //public int MyProperty { get; set; }
        void Show();
       int Number();
    }

    class PartTimeEmployee : IEmployee
    {
        public void Show()
        {
            Console.WriteLine("This is method of IEmployee");
            
            //throw new NotImplementedException();
        }

        public int Number() 
        {

            return 20;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee ii = new PartTimeEmployee();
            PartTimeEmployee pte = new PartTimeEmployee();  
            pte.Show();
            
            Console.WriteLine(pte.Number());
            //Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
