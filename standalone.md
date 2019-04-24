# Ant Man is having a party 
![AntMan](https://user-images.githubusercontent.com/2546640/56691312-a24f6b80-66ad-11e9-8986-4f3ac73e182b.gif)

**No Spoliers**

Hey Friends, I know we are saving the world but, I thought you might want to my house warming. 
Let me know what you would like and who's in :) .
```csharp --destination-file .\test_humanizer\Program.cs --project .\test_humanizer\test_humanizer.csproj
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
        public static void Run3()
        {
            #region run3
              string ordinalword = 21.ToOrdinalWords();
              Console.WriteLine("Ant Man:",ordinalword);
            #endregion
        }
       
    }
}
```
```csharp --source-file .\test_humanizer\Program.cs --project .\test_humanizer\test_humanizer.csproj --region run
            string singular = "meats".Singularize();
            Console.WriteLine("Thor: {0}", singular);   
```
```csharp --source-file .\test_humanizer\Program.cs --project .\test_humanizer\test_humanizer.csproj --region run1
string roman  = 2010.ToRoman();
            Console.WriteLine("Tony Stark:{0}",roman);
```
```csharp --source-file .\test_humanizer\Program.cs --project .\test_humanizer\test_humanizer.csproj --region run2
string ordinalword = 21.ToOrdinalWords();
              Console.WriteLine("Black Widow:Maybe {0} of June after we deal with Thanos?",ordinalword);
```
```csharp --source-file .\test_humanizer\Program.cs --project .\test_humanizer\test_humanizer.csproj --region run3
        string ordinalword = 21.ToOrdinalWords();
        Console.WriteLine("Ant Man:",ordinalword);
```
