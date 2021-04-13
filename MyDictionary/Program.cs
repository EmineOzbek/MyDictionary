using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> employees = new MyDictionary<int, string>();
            employees.Add(employees.Count + 1, "Emine");
            employees.Add(employees.Count + 1, "Nermin");
            employees.Add(employees.Count + 1, "Oğuzhan");
            employees.Add(employees.Count + 1, "Elif");
            employees.Add(employees.Count + 1, "Cemal");



            for (int i=0; i<employees.Count; i++)
            {
                Console.WriteLine("Eleman No: {0}, İsim: {1}", employees.Keys[i], employees.Values[i] );
            }

            Console.WriteLine("Eleman Sayısın:{0}",employees.Count);




        }
    }
}
