using System;
// 1.1.1
namespace HelloWorld_1_1_1
{
    class HelloWorld
    {
        public static void Main(string[] args)
        {
            for (int i=0; i<10 ; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}

// 1.1.2
// 
// 1. public: Nothing Happened, the program ran still
// 2. Static: The Build Failed, Program doesn't contain a 'static' 'Main' method suitable for an entry point
// 3. void: The Build failed because a Method must have a return type
// 4. args: Identifier expected
// 
// 1.1.3
// 1. public: 
//    Member modifier static must precede the member type and name, the name publc does not exist in the current context
// 2. static:
//    Invalid token 'void' in class, struct or interface member declaration, the name static does not exist in the current context
// 3. void:
//    the type or namespace 'vod' could not be found, HelloWorld.Main(string[]), not all code paths return a value
// 4. args:
//    nothing
//