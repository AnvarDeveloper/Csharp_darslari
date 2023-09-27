using System;
public class Yosh
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tugulgan yilingiz: ");
        int tyil=Convert.ToInt32(Console.ReadLine());
        string jyil=DateTime.Now.ToString("yyyy");
        int jjyil=Convert.ToInt32(jyil);
        Console.WriteLine("Yoshingiz = "+(jjyil-tyil)*365);
    }
}
