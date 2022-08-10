using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;

            string degiskenVeri = null;

            Console.WriteLine(deger);

            byte b = 5;             //1 byte
            sbyte s = 6;            //1 byte

            short sVeri = 7;        //2 byte
            ushort uVeri = 8;       //2 byte

            Int16 i = 9;            //2 byte
            int inte = 10;          //4 byte
            Int32 intee = 11;       //4 byte
            Int64 inteee = 12;      //8 byte

            uint inteeeVeri = 13;   //4 byte
            long l = 14;            //8 byte
            ulong lo = 15;          //8byte
            
            //  REEL SAYİLAR
            float f = 16;           //4 byte
            double d = 17;          //8 byte
            decimal c = 18;         //16 byte

            char ca = 'a';          //2 byte
            string str = "b";       //sinirsiz

            bool b2 = true;
            bool b3 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 5.1;

            string stri = string.Empty;
            stri = "Yunus Emre";
            string ad = "Yunus Emre";
            string soyad = "Başer";
            string tamAd = ad + " " + soyad;

            //Integer tanımlama şekilleri
            int one = 5;
            int two = 6;
            int sum = one + two;

            //boolean
            bool bol = 18 < 2;

            //değişken dönüşümleri
            string text = "28";
            int int20 = 20;
            string yeniDeger = text + int20.ToString();
            Console.WriteLine(yeniDeger); //ciktisi 2820

            int int21 = int20 + Convert.ToInt32(text);
            Console.WriteLine(int21);    //ciktisi 48

            int int22 = int20 + int.Parse(text);
            Console.WriteLine(int22);    //ciktisi 48

            // Datetime
            string dateTime = DateTime.Now.ToString("dd.MM.yy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yy");
            Console.WriteLine(dateTime2);

            // Saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
