using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldInCSharp
{
    public class First
    {
        public int Id;
        public static void One()
        {
            Console.WriteLine("Public");
        }
        private static void Two()
        {
            Console.WriteLine("Private");
        }
        internal static void Three()
        {
            Console.WriteLine("internal");
        }
        protected static void Four()
        {
            Console.WriteLine("protected");
        }
    }
    public class Second:First
    {
        public int x = 100;
        public static int y = 200;

       
    }
}
