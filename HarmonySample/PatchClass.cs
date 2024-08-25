using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLibrary;

using HarmonyLib;

namespace HarmonySample
{
    [HarmonyPatch(typeof(Class1), "qwerty")]
    internal class PatchClass
    {
        // Prefix method for modifying arguments before the original method
        private static bool Prefix(ref double __result, double val)
        {
            Console.WriteLine($"Prefix qwerty called with {val}");
            // Set the new return value
            __result = val * val * val;
            Console.WriteLine($"Prefix qwerty returning {__result}");
            // Return false to skip the original method
            return false;
        }

        private static void Postfix(ref double __result)
        {
            Console.WriteLine($"Postfix qwerty called with result {__result}");
        }
    }
}