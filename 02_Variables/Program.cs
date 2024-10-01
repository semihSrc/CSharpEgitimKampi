using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patato = 9.74;
            //tomato = 6.88;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " \u20BA");
            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " \u20BA");
            //Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " \u20BA");
            //Console.WriteLine("----Patates Birim Fiyatı: " + patato + " \u20BA");
            //Console.WriteLine("----Domates Birim Fiyatı: " + tomato + " \u20BA");
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, strawGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice=orangeGram * orangePrice;
            //double strawberryTotalPrice=strawGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patato;
            //double tomatoTotalPrice = tomato * tomatoGram;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice +" -Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " -Gramaj: " + orangeGram + " -Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " -Gramaj: " + strawGram + " -Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patato + " -Gramaj: " + patatoGram + " -Toplam Tutar: " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomato + " -Gramaj: " + tomatoGram + " -Toplam Tutar: " + tomatoTotalPrice);

            //double shoppinTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppinTotalPrice + " \u20BA");

            #endregion
            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName,passangerSurname,passangerDistrict,passangerCity,passangerAge,passangerId;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerId = Console.ReadLine();

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " +passangerId +"Yolcu: " + passangerName + " " + passangerSurname + " " + passangerDistrict + "/" + passangerCity + " " + passangerAge);


            #endregion
            #region Klavyeden Tamsayı Girişleri Ve Dönüşümler

            //int shoesPrices, computerPrice, chairPrice, tvPrice;
            //shoesPrices = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount;
            //int computerCount;
            //int chairCount;
            //int tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisar Sayısını Giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrices+computerPrice*computerCount+chairPrice*chairCount+tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1+ exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " +result);

            #endregion
            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");

            gender =char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}
