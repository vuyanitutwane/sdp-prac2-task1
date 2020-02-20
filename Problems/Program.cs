using System;

namespace Problems
{
    class Program
    {
        static void Prefix(string input)
        {
            Console.WriteLine(input.Length + "," + input.Split().Length + ":" + input);
        }
        static void Main(string[] args)
        {
            Prefix("vuyani");
        }
    }
}
