namespace Inheritance
{
    public class Inheritance1
    {
        int i = 20;
        public void m1()
        {
            Console.WriteLine(i);
            Console.WriteLine("m1() in Inheritance class");
        }
        public void m2()
        {
            Console.WriteLine(i);
            Console.WriteLine("m2() in Inheritance class");
        }
    }
    class Inheritance2
    {
        double d = 3.2;
        public void display()
        {
            Console.WriteLine(d);
            Console.WriteLine("Display() in inheritance1 class");
        }
    }
    class myclass
    {
        static void Main(string[] args)
        {
            Inheritance1 s1 = new Inheritance1();
            s1.m1();
            s1.m2();
            Console.WriteLine("---------------");
            Inheritance2 S2 = new Inheritance2();
            S2.display();
        }
    }
}