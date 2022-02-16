using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "dersimiz c sharp,hoşgeldiniz!";
            string degisken2 = "dersimiz c sharp";
            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToLower());
            //concat
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));//birleştirme
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));// true dersem büyük küçük harf duyarsız hale gelir.
            Console.WriteLine(String.Compare(degisken, degisken2, false));
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith(",hoşgeldiniz!"));
            Console.WriteLine(degisken.IndexOf("a"));
            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));
            Console.WriteLine(degisken.LastIndexOf("i"));
            //padleft , padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));//30 a tamamlayacak kadar boşluk ekler.
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));//* ekliyor.
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2.PadLeft(30, '*'));
            //remove
            Console.WriteLine(degisken.Remove(10));
            //replace
            Console.WriteLine(degisken.Replace("c sharp","c#"));
            //split
            Console.WriteLine(degisken.Split(' ')[2]);//boşluk koyunca içini diziye çeviriyor ve 2 indeksteki degeri alıyorsun
            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
