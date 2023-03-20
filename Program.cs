using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

 class Penjumlahan
{
    public int JumlahTigaAngka<T> (T x, T y, T z)
    {
        
        return (dynamic) x + (dynamic)y + (dynamic)z;
    }
}
public class Program
{
    public static void Main()
    {
        Penjumlahan penjumlahan= new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 22));
        

    }
}