using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{

    class Program
    {
        static void Main(string[] args)
        {
            //List<int> DC = new List<int>();
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    DC.Add(ran.Next(1, 100));
            //}
            //DC = DC.OrderBy(o => o).ToList();
            //Console.WriteLine(DC[DC.Count - 1]);
            //int sum = 0;
            //for (int i = 0; i < DC.Count; i = i + 2)
            //{
            //    Console.WriteLine(" elements " + DC[i]);
            //    DC.Remove(i); //delete, task 2
            //    sum += DC[i];
            //}
            //Console.WriteLine(" sum " + sum);

            ////task3
            //double avgTask3 = 0;
            //List<double> GQ = new List<double>();
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    GQ.Add(ran.Next(1, 100));
            //}
            //avgTask3 = GQ.Sum(o => o) / GQ.Count;
            //Console.WriteLine(" sum " + avgTask3);
            //foreach (var item in GQ)
            //    if (item > avgTask3)
            //        Console.WriteLine("value more than avg1" + item);

            //foreach (var item in GQ.Where(o=>o> avgTask3))
            //    Console.WriteLine("value more than avg2" + item);

            //task4
            //string str = "sdljhdsflgdsgsdlkhgfklhgflk'hfkl'hhgd";
            //List<char> XX = str.ToList();
            //XX.Reverse();
            //foreach (var item in XX)
            //{
            //    Console.Write(item);
            //}
            //task5
            //string s1 = "TOP";
            //string s2 = "POT";
            //string s3 = "";
            //foreach (char item in s1.Reverse())
            //{
            //    s3 += item;
            //}
            //if (s3 == s2)
            //{ Console.WriteLine("Victory"); }
            //task6

            string text = "be or not to be is a question";
            List<string> Alen = new List<string>();
            Alen = text.Split(' ').ToList();
            string bookva = "aoieu";
            foreach (var item in Alen)
            {
                if (bookva.Contains(item[0]))
                    Console.WriteLine(item);
            }
            foreach (var item in Alen)
            {
                if (!bookva.Contains(item[0]))
                    Console.WriteLine(item);
            }

       

        }
    }
}
