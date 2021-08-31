using System;
using System.Collections.Specialized;

namespace StringCollectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringCollection strCol = new StringCollection();
            String[] strArr = new String[] { "pankaj", "pawan", "vishal", "sujit", "digvijay", "param" };
            Console.WriteLine("Elements...");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
            strCol.AddRange(strArr);
            String[] arr = new String[strCol.Count];
            strCol.CopyTo(arr, 0);
            Console.WriteLine("Elements...after copying StringCollection to array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    
}
