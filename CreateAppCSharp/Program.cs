using CreateAppSCharp;
using System.IO.MemoryMappedFiles;
using System.Numerics;

namespace CreateAppCSharp;

class Program
{
    static void Main(string[] args)
    {
        // Реализуйте операторы неявного приведения из long,int,byt в Bits
        // По сути, к сделанному на семинаре в файле BitGetable.cs я добавил следующий код:
        // public static implicit operator byte(Bits bits) => (byte)bits.Value;
        // public static explicit operator Bits(byte value) => new(value);
        // public static implicit operator int(Bits bits) => (int)bits.Value;
        // public static explicit operator Bits(int value) => new(value);

        Bits bits = new(63);
        Bits bitsByte = new((byte)11);
        Bits bitsInt = new((int)10);
        Bits bitsLong = new((long)12);

        Console.WriteLine(bits);
        Console.WriteLine(bitsByte);
        Console.WriteLine(bitsInt);
        Console.WriteLine(bitsLong);


    }
}



public enum Gender { man, woman }

