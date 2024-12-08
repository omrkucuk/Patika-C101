using System;

namespace Odev_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;             // 1 byte
            sbyte c = 5;            // 1 byte

            short s = 5;            // 2 byte
            ushort us = 5;          // 2 byte

            Int16 i16 = 2;          // 2 byte
            int i = 2;              // 4 byte
            Int32 i32 = 2;          // 4 byte
            Int64 i64 = 2;          // 8 byte

            uint ui = 2;            // 4 byte
            long l = 4;             // 8 byte
            ulong ul = 4;           // 8 byte

            // Reel Sayılar
            float f = 5f;           // 4 byte       
            double d = 5;           // 8 byte
            decimal m = 5m;         // 16 byte 

            char ch = '2';          // 2 byte
            string str = "Ömer";    // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;     // Çalıştığı anın tarih ve saat karşılığını getirir.
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 5.2;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Ömer Küçük";
            string ad = "Ömer";
            string soyad = "Küçük";
            string tamIsim = $"{ad} {soyad}";
            Console.WriteLine(tamIsim);

            // integer tanımlama şekilleri 

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = true;
            bool bool2 = false;
            bool bool3 = 10 > 2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);           // Çıktısı 2020

            int int30 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int30);               // Çıktısı 40

            int int40 = int20 + int.Parse(str20);

            // Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // gün.ay.yıl noktalı gelir
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); // gün/ay/yıl slashlı gelir
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");           // O anki saat ve dakika gelir
            Console.WriteLine(hour);   
        }
    }
}