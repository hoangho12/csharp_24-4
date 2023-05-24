using System;
namespace bai4;

class Program
{
    static void Main(string[] args)
    {
        int VND = 23000;
        Console.WriteLine("Nhap USD");
        int USD = int.Parse(Console.ReadLine());

        Console.WriteLine("So tien "+USD+ " $= " + USD * VND + " VND");
    }
}
