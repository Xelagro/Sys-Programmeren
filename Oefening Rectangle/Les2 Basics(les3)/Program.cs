using System;

namespace Les2_Basics_les3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle rechthoek = new Rectangle(100, 100, 50, 60);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.MoveTo(100, 100);
        }
    }
}
