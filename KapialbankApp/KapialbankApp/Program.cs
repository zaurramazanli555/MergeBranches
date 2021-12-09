using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapialbankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp();
            MobileApp();
            APISayt();
        }
        public static void WebApp()
        {
            Console.WriteLine("This is Web Application");
        }
        public static void MobileApp()
        {
            Console.WriteLine("This is Mobile  Application");
        }
        public static void APISayt()
        {
            Console.WriteLine("This is Api");
        }
        public static void Reklam()
        {
            Console.WriteLine("This is ReklamApp");
        }
    }
}
