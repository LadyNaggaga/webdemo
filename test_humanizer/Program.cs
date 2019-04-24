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
                case "run3":
                    Run2();
                    break;   
            }
            
        }
        public static void Run()
        {
            #region run
            string singular = "meats".Singularize();
            Console.WriteLine("Thor: {0}", singular);
            #endregion
        }
        public static void Run1()
        {
            #region run1
            string roman  = 2010.ToRoman();
            Console.WriteLine("Tony Stark:{0}",roman);
            #endregion
        }
        public static void Run2()
        {
            #region run2
              string ordinalword = 21.ToOrdinalWords();
              Console.WriteLine("Black Widow:Maybe {0} of June after we deal with Thanos?",ordinalword);
            #endregion
        }
        public static void Run2()
        {
            #region run3
              string ordinalword = 21.ToOrdinalWords();
              Console.WriteLine("Ant Man:",ordinalword);
            #endregion
        }
       
    }
}