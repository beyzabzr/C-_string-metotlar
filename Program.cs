using System;

namespace string_metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersiniz CSharp, Hosgeldiniz.";
            string degisken2 = "CSharp";

            //length;
            Console.WriteLine(degisken.Length); // kac karakter oldugunu yazdirir

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper()); //Butun harfleri buyuk yazar
            Console.WriteLine(degisken.ToLower()); //Butun harfleri kucuk yazar

            //Concat
            Console.WriteLine(string.Concat(degisken, " Merhaba")); //degiskeni merhaba ile birlesitirir

            //Compare , CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1 (iki degisken ayni karakter sayisina sahip ise;0 , 1.degisken 2. degiskenden daha fazla karakter sayisina sahip ise;1 , 2.degisken 1.degiskenden daha fazla karakter sayisina sahip ise; -1 dondurur.)
            Console.WriteLine(String.Compare(degisken, degisken2, true));// 0, 1, -1 (true = buyuk kucuk harf duyarli) 
            Console.WriteLine(String.Compare(degisken, degisken2, false));// 0, 1, -1 (false = buyuk kucuk harf duyarsiz)

            //Contains , EndsWith , StartWith
            Console.WriteLine(degisken.Contains(degisken2)); //1. degiskenin icinde 2. degisken var mi?
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz.")); //degisken "Hosgeldiniz." ile bitiyor mu?
            Console.WriteLine(degisken.StartsWith("Hosgeldiniz.")); //degisken "Hosgeldiniz." ile basliyor mu?

            //IndexOf , LastIndexOf
            Console.WriteLine(degisken.IndexOf("CSharp")); //degisken icerisinde ki CSharp degerinin en basi olan "C"'nin indexini verir. (bulamazsa -1 doner)
            Console.WriteLine(degisken.IndexOf("Beyza")); //-1
            Console.WriteLine(degisken.LastIndexOf("i")); //Sondan baslayarak "i"'nin indexini verir.

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! ")); //0. indexten baslayarak "Merhaba! "'yi ekler. 

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // degiskenin 30 karakter sonrasina (soluna)degisken2'yi ekle
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); //Yildiz ekle
            Console.WriteLine(degisken.PadRight(50) + degisken2); // degisken2'nin 50 karakter sonrasina (sagina) degisken'e ekle
            Console.WriteLine(degisken.PadLeft(50, '-') + degisken2); //tire ekle

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. indexten sonrasini siler
            Console.WriteLine(degisken.Remove(5, 3)); //5.indexten baslayarakk 3 karakter siler
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#")); //CSharp'i, C# ile degistir.
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); // ' ' ; bosluklara gore parcala ve bana 1. indexini getir

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4.indexten baslayarak devamini getir
            Console.WriteLine(degisken.Substring(4, 6)); // 4. indexten baslayarak 6 karakter getir.
        }
    }
}