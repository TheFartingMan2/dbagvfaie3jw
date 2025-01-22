using System;

namespace HelloWorld
{
    class Program
    {
        public bool poem;
        public static bool GoodPoem;
        

        public static bool greatness()
        {
            if (GoodPoem != true) return true;
            return false;
        }

        public static void Main(string[] args)
        {
        	GoodPoem = true;
 
            Program p = new Program(); 
            if (p.poem == greatness()) 
            {
                Console.WriteLine("Create awesomeness");
            }
            else
            {
                Console.WriteLine("bruh");
            }
        }
    }
}
