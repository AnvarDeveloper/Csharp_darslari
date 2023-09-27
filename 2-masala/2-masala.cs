using System;
public class Konvertatsiya
{
   public static void Main(string[] args)
    {
        Console.WriteLine("Valyuta qiymatini kiriting: ");
        double qiymat=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Valyuta kursi qiymatini kiriting: ");
        int kurs=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Summa = "+qiymat*kurs);
    }
}