// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.ComponentModel;

class Number1
{
    static void Main()
    {
        //①
        string[] sam = new string[] { "aaa", "bbb", "ccc", "ddd", "abc" };
        if (sam.Contains("aaa"))
        {
            Console.WriteLine("含んでいます");
        }
        else
        {
            Console.WriteLine("含んでいません");
        }

        //②
        List<string> bird = new List<string> { "crow", "sparrow", "swallow", "pigeon" };
        bird.Remove("sparrow");
        bird.RemoveAt(1);
        foreach (string New in bird)
        {
            Console.WriteLine(New);
        }
    }
}