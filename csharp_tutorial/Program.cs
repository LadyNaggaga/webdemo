using System;

namespace csharp_tutorial
{
    class Program
    {
        static void Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            switch(region)
            {
                case "Helloworld":
                    Run();
                    break;
                case "run1":
                    Run1();
                    break;
                case "run2":
                    Run2();
                    break;
            }
            
        }
        public static void Run()
        {
            #region Helloworld
            Console.WriteLine("Hello World!");
            #endregion
        }
        public static void Run1()
        {
            #region run1
            var name = "Your Name";
            Console.WriteLine("Hello " + name + "!");
            #endregion
        }
        public static void Run2()
        {
            #region run2
            Console.WriteLine("Hello World!");
            #endregion
        }
       
    }
}
