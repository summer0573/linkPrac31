﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkPrac31
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            foreach(var item in input)
            {
                if(item % 2 == 0) output.Add(item);
            }
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            var output2 = from item in input
                          where item % 2 == 0
                          orderby item descending
                          select item;

            foreach(var item in output2)
            {
                Console.WriteLine(item);
            }

            int[] output3 = output2.ToArray();
            List<int> output4 = output2.ToList();

            var output5 = from item in input
                          where item % 2 == 0
                          select new
                          {
                              A = item * 2,
                              B = item * item,
                              C = 100
                          };

            foreach(var item in output5)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine();
            }

            List<product> foods = new List<product>
            {
                new product () {Name = "군고구마", Price = 1500},
                new product () {Name = "호떡", Price = 1000},
                new product () {Name = "붕어빵", Price = 1200},
                new product () {Name = "오뎅", Price = 800},
            };

            var output6 = from food in foods
                          where food.Price > 1500
                          orderby food.Name ascending
                          select food;

            foreach(var item in output6) {
                Console.WriteLine(item);
            }
        }
    }
}
