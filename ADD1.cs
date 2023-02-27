using System;

namespace Polymorephism1
{
    class ADD1
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void add(float a, float b, float c)
        {
            Console.WriteLine(a + b + c);
        }
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + "\t" + s2);
        }
    }
    class ADD2:ADD1
    {
        public void add(string s1, string s2, string s3)
        {
            Console.WriteLine(s1 + "\t" + s2 + "\t" + s3);
        }

    }
}
