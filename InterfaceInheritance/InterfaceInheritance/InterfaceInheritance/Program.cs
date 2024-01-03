namespace InterfaceInheritance
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print1();
    }
    interface I3 : I1, I2
    {
        void Print2();
    }
    internal class Program : I3
    {
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print1 ();    
            p.Print2 ();
            p.Print();

            I3 myInterface = new Program();
            myInterface.

            //Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Interface 1");
            //throw new NotImplementedException();
        }

        public void Print1()
        {
            Console.WriteLine("Interface 2");
            //throw new NotImplementedException();
        }

        public void Print2()
        {
            Console.WriteLine("Interface 3");
            //throw new NotImplementedException();
        }
    }
}
