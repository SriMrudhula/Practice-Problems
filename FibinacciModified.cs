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
using System.Numerics;
using System;

class Solution {

    // Complete the fibonacciModified function below.
    static string fibonacciModified(int t1, int t2, int n) {
        var b1=BigInteger.Parse(t1.ToString());
        var b2=BigInteger.Parse(t2.ToString());
        var b3=BigInteger.Parse("0");
        for(int i=2;i<n;i++)
         {
             b3=b1+(b2*b2);
             b1=b2;
             b2=b3;
         }
return b3.ToString();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] t1T2n = Console.ReadLine().Split(' ');

        int t1 = Convert.ToInt32(t1T2n[0]);

        int t2 = Convert.ToInt32(t1T2n[1]);

        int n = Convert.ToInt32(t1T2n[2]);

        string result=fibonacciModified(t1, t2, n);
        textWriter.WriteLine(result);


        textWriter.Flush();
        textWriter.Close();
    }
}
