using System;

namespace CH3_4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine("Int a : {0}, String b : {1}\n", a, b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine("float c : {0}, String d : {1}\n", c, d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine("string e : {0}, Int f : {1}\n", e, f);

            string g = "1.2345";
            float h = (float)Convert.ToDouble(g);
            float i = float.Parse(g);
            Console.WriteLine("string g : {0}, float h : {1}, float i : {2}\n", g, h, i);

        }
    }
}