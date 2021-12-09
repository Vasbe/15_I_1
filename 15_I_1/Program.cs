using System;
using System.Linq;
using System.IO;
namespace _15_I_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите заданное число: ");
            int c = int.Parse(Console.ReadLine());
            string input = File.ReadAllText(@"C:\Users\vasbe\Desktop\input.txt");
            StreamWriter sw = new StreamWriter("C://Users//vasbe/Desktop/testOut.txt", true);
            string[] lines = input.Split();
            float[] nums = lines.Select(float.Parse).ToArray();
            var maxNums =
            from n in nums
            where n > c
            select n/2;
            foreach(var x in maxNums) 
            {
                sw.Write(x.ToString()+ " ");
            }
            sw.Close();
        }
    }
}