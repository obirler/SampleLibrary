using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLibrary;
using HarmonyLib;

namespace HarmonySample
{
    [HarmonyPatch(typeof(Class1), "qazxsw")]
    internal class PatchClass2
    {
        // Prefix method for modifying arguments before the original method
        private static bool Prefix(ref double __result, double val)
        {
            Console.WriteLine($"Prefix qazxsw called with {val}");
            // Set the new return value
            __result = 3 * val;
            Console.WriteLine($"Prefix qazxsw returning {__result}");
            // Return false to skip the original method
            return false;
        }

        private static void Postfix(ref double __result)
        {
            Console.WriteLine($"Postfix qazxsw called with result {__result}");
        }
    }
}