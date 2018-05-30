using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hodor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0x29, 0xe6, 0xf0, 0xec, 0x5d, 0xa4, 0xe8, 0xb4,	0x5d, 0x3d, 0xe2, 0x90,	0xb0, 0xa6 };
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 1; i < 256; i++)
                {
                    int z = i << 2 | i >> 5;
                    int res = z ^ 0x23;
                    byte[] intBytes = BitConverter.GetBytes(res);
                    if (intBytes[0] == arr[j])
                    {
                        Console.Write((char)i);
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
