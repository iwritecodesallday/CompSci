using System;
namespace HelloWorld_1_1_1
{
    class UseArgument
    {
        public static void Main(string[] args)
        {
            
            string Name_01 = args[0];
            string Name_02 = args[1];
            string Name_03 = args[2];

            Console.WriteLine(Name_03);
            Console.WriteLine(Name_02);
            Console.WriteLine(Name_01);
            
        }
    }
}
