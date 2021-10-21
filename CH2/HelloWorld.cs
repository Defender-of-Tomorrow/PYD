using System;                                   // using : keyword
using static System.Console;                    // Console : Write, WriteLine, Read, ReadLine

namespace BrainCSharp                           // Create namespace called BrainCSharp.
{
    class HelloWorld                            // Create class called HelloWorld.
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)         // Memory allocate when executing a program if use static keyword.
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");     // System.Console.WriteLine
                return;
            }

            WriteLine("Hello, {0}!", args[0]);                          // using static System.Console;
        }
    }
}
