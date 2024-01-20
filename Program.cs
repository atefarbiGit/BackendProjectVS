using BackendProjectVS.Classes;
using System;

public class Program
{
    static void Main()
    {
        StringHelper stringHelper = new StringHelper();
        Console.WriteLine(stringHelper.CountDigits("34RDfdv5")); // Output: 3
        Console.WriteLine(MathHelper.MaxDivisor(234, 72));   // Output: 18
        Console.WriteLine(MathHelper.MaxDivisor(345, 900));  // Output: 15
    }
}

