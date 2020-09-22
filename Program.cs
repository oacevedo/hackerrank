using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( migratoryBirds(new List<int>(){1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4}));
           Console.WriteLine( migratoryBirds(new List<int>(){1, 4, 4, 4, 5, 3}));
           
           Console.ReadKey();
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/migratory-birds/problem
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int migratoryBirds(List<int> arr)
        {
            var birdTypes = new int[5];
            for (int i = 0; i < arr.Count; i++)
            {
                birdTypes[arr[i] - 1 ]++;
            }

            int result = -1, max = -1;
            
            for (int i = 0; i < birdTypes.Length; i++)
            {
                if(birdTypes[i] > max)
                  {
                      max = birdTypes[i];
                      result = i+1;
                  }
            }

            return result;
        }



    }
}
