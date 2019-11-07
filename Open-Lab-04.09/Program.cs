using System;

namespace Open_Lab_04._09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            Console.WriteLine("Enter array elements:");
            for (var x = 0; x < arr.Length; x++)
            {
                Console.WriteLine($"Enter {x + 1}. element:");
                arr[x] = Console.ReadLine();
            }

            Dups dups = new Dups();
            string[] result = dups.RemoveDups(arr);
            foreach (var item in result)
                Console.Write(item + ", ");
        }
    }
}
