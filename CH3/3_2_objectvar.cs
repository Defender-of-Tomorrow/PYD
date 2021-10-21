using System;

namespace CH3_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object o1 = 123;
            object o2 = 3.141592653589793238462642283279m;
            object o3 = true;
            object o4 = 'a';
            object o5 = "안녕하쇼!";

            Console.WriteLine("Type: {0}, Value : {1}", o1.GetType(), o1);
            Console.WriteLine("Type: {0}, Value : {1}", o2.GetType(), o2);
            Console.WriteLine("Type: {0}, Value : {1}", o3.GetType(), o3);
            Console.WriteLine("Type: {0}, Value : {1}", o4.GetType(), o4);
            Console.WriteLine("Type: {0}, Value : {1}", o5.GetType(), o5);

            var v1 = 123;
            var v2 = 3.141592653589793238462642283279m;
            var v3 = true;
            var v4 = 'a';
            var v5 = "안녕하쇼!";

            Console.WriteLine("Type: {0}, Value : {1}", v1.GetType(), v1);
            Console.WriteLine("Type: {0}, Value : {1}", v2.GetType(), v2);
            Console.WriteLine("Type: {0}, Value : {1}", v3.GetType(), v3);
            Console.WriteLine("Type: {0}, Value : {1}", v4.GetType(), v4);
            Console.WriteLine("Type: {0}, Value : {1}", v5.GetType(), v5);
        }
    }
}