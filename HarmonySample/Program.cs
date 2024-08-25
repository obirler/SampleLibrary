using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;

using SampleLibrary;

namespace HarmonySample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a Harmony instance
            var harmony = new Harmony("com.example.patch");
            harmony.PatchAll();

            var sample = new Class1();

            var m1_res = sample.Method1(10);
            var m2_res = sample.Method2(10);

            Console.WriteLine($"m1: {m1_res}");
            Console.WriteLine($"m2: {m2_res}");
            Console.ReadKey();
        }
    }
}