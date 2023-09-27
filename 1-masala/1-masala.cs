using System;
public class Aylana
{
   public static void Main(string[] args)
    {
        Console.WriteLine("Aylana radiusini kiriting: ");
        int radius=Convert.ToInt32(Console.ReadLine());
        double s=Math.PI*radius*radius;  
        double l=2*Math.PI*radius;
        Console.WriteLine("aylana yuzasi = "+s);
        Console.WriteLine("aylana uzunligi= "+l);

    }

}
