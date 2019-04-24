using System;
using Humanizer;
namespace test_humanizer
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
                case "run":
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
            #region run
            string singular = "geese".Singularize();
            Console.WriteLine("Thor " + singular);
            #endregion
        }
        public static void Run1()
        {
            #region run1
        
            #endregion
        }
        public static void Run2()
        {
            #region run2
        
            #endregion
        }
       
    }
}