/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI...: NDP 1.Ödev
**				ÖĞRENCİ ADI.....: Mahmud Emre Başpehlivan
**				ÖĞRENCİ NUMARASI: G211210020
**              DERSİN ALINDIĞI GRUP...: 2.Öğretim A Grubu
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ödev02
{
    public static class ParolaGuvenligi
    {
        public static int KüçükHarf(string Password) // Şifrede ki küçük harf sayısını hesaplayan metod.
        {
            int sayac=0;
            for (int i = 0; i < Password.Length; i++)
                if (char.IsLower(Password[i]))
                    sayac += 1;
            return sayac*10;
        }
        public static int BüyükHarf(string Password) // Şifrede ki büyük harf sayısını hesaplayan metod.
        {
            int sayac = 0;
            for (int i = 0; i < Password.Length; i++)
                if (char.IsUpper(Password[i]))
                    sayac += 1;
            return sayac*10;
        }
        public static int Rakam(string Password) // Şifrede ki rakam sayısını hesaplayan metod.
        {
            int sayac = 0;
            for (int i = 0; i < Password.Length; i++) 
                if (char.IsDigit(Password[i]))
                    sayac += 1;
            return sayac*10;
        }
        public static int Sembol(string Password) // Şifrede ki sembol sayısını hesaplayan metod.
        {
            int sayac = 0;
            for (int i = 0; i < Password.Length; i++)
                if (!char.IsLetterOrDigit(Password[i])) 
                    sayac += 1;
            return sayac * 10;
        }

        public static int ParolaPuanı(string Password) // Şifrede ki karakterlerin puanını hesaplayan metod.
        {
            if (Password == null)
            {
                return 0;
            }

            int küçükHarfPuanı = KüçükHarf(Password);
            int büyükHarfPuanı = BüyükHarf(Password);
            int rakamPuanı = Rakam(Password);
            int semboolPuanı = Sembol(Password);

            return küçükHarfPuanı + büyükHarfPuanı + rakamPuanı + semboolPuanı;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string cevap = null;
            do
            {
                Console.ForegroundColor= ConsoleColor.White;
                int puan = 0;
                Console.WriteLine("Bir şifre oluşturunuz"); // Burda şifre oluşturuluyor.

                string Sifre = Console.ReadLine();

                

                int Kücük= ParolaGuvenligi.KüçükHarf(Sifre), kucuk=ParolaGuvenligi.KüçükHarf(Sifre);
                int Büyük = ParolaGuvenligi.BüyükHarf(Sifre), buyuk=ParolaGuvenligi.BüyükHarf(Sifre);               
                int Rakam = ParolaGuvenligi.Rakam(Sifre), rakam=ParolaGuvenligi.Rakam(Sifre);
                int Sembol = ParolaGuvenligi.Sembol(Sifre), sembol=ParolaGuvenligi.Sembol(Sifre);
                

               
                if(Kücük>20)   Kücük=20; // Şifrede küçük harflerden gelen puan 20 den büyüse 20 ye eşitleniyor.
                if(Büyük>20)   Büyük=20; // Şifrede büyük harflerden gelen puan 20 den büyüse 20 ye eşitleniyor.
                if (Rakam>20)   Rakam=20; // Şifrede rakamlardan gelen puan 20 den büyüse 20 ye eşitleniyor.

                if (kucuk <= 0) // Şifrede küçük harf olup olmadığına bakılıyor.
                { 
                    Console.WriteLine("En az 1 küçük harf giriniz");
                }
                else
                {     
                    if(buyuk <= 0) // Şifrede büyük harf olup olmadığına bakılıyor.
                    {
                        Console.WriteLine("En az 1 büyük harf giriniz");
                    }
                    else
                    { 
                        if(rakam<=0) // Şifrede rakam olup olmadığına bakılıyor.
                        {
                            Console.WriteLine("En az 1 rakam giriniz");
                        }
                        else
                        {
                            if(sembol<=0) // Şifrede sembol olup olmadığına bakılıyor.
                            {
                                Console.WriteLine("En az 1 sembol giriniz");
                            }
                            else
                            {
                                for (int i = 0; i < Sifre.Length; i++) // Şifrede boşluk varsa şifreyi kabul etmiyor.
                                {
                                    if (char.IsWhiteSpace(Sifre[i]))
                                    {
                                        Console.WriteLine("Şifreniz karakter olarak boşluk içeremez");
                                        break;
                                    }
                                } 
                                if (Sifre.Length < 9) // Şifrenin minumum 9 karakterden oluşup oluşmadığına bakıyor.
                                {
                                    Console.WriteLine("Minumum 9 karakterli olmalıdır.");
                                }
                                else if (Sifre.Length == 9) // Eğer şifre 9 karakterse şifre puanına 10 puan ekliyor.
                                {
                                    puan += 10;
                                }
                                puan = Kücük + Büyük + Rakam + Sembol;
                                if (puan < 70)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Şifreniz kolay bir şifredir.");
                                    Console.ForegroundColor= ConsoleColor.Red;
                                    Console.WriteLine("        Şifrenizde ki küçük harf sayısı :" + kucuk / 10); // Şifrede ki küçük harf sayısını gösteriyor.
                                    Console.WriteLine("        Şifrenizde ki büyük harf sayısı :" + buyuk / 10); // Şifrede ki büyük harf sayısını gösteriyor.
                                    Console.WriteLine("        Şifrenizde ki rakam  sayısı :" + rakam / 10); // Şifrede ki rakam sayısını gösteriyor.
                                    Console.WriteLine("        Şifrenizde ki sembol sayısı :" + sembol / 10); // Şifrede ki sembol sayısını gösteriyor.
                                    Console.WriteLine("   Şifrenizi değiştirmek istermisiniz (e/h)"); cevap = Console.ReadLine();
                                }
                                else if (puan < 90 && 70 <= puan)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("Şifreniz normal zorlukta bir şifredir.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("       Şifrenizde ki küçük harf sayısı :" + kucuk / 10); // Şifrede ki küçük harf sayısını gösteriyor.
                                    Console.WriteLine("       Şifrenizde ki büyük harf sayısı :" + buyuk / 10); // Şifrede ki büyük harf sayısını gösteriyor.
                                    Console.WriteLine("       Şifrenizde ki rakam  sayısı :" + rakam / 10); // Şifrede ki rakam sayısını gösteriyor.
                                    Console.WriteLine("       Şifrenizde ki sembol sayısı :" + sembol / 10); // Şifrede ki sembol sayısını gösteriyor.
                                    Console.WriteLine("   Şifrenizi değiştirmek istermisiniz (e/h)"); cevap = Console.ReadLine();
                                }
                                else if (puan <= 100 && 90 <= puan)
                                {
                                    Console.WriteLine("Güçlü bir şifre oluşturdunuz.");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("      Şifrenizde ki küçük harf sayısı :" + kucuk / 10); // Şifrede ki küçük harf sayısını gösteriyor.
                                    Console.WriteLine("      Şifrenizde ki büyük harf sayısı :" + buyuk / 10); // Şifrede ki büyük harf sayısını gösteriyor.
                                    Console.WriteLine("      Şifrenizde ki rakam  sayısı :" + rakam / 10); // Şifrede ki rakam sayısını gösteriyor.
                                    Console.WriteLine("      Şifrenizde ki sembol sayısı :" + sembol / 10); // Şifrede ki sembol sayısını gösteriyor.
                                    Console.WriteLine("   Başka bir şifre yazmak istiyormusunuz (e/h)"); cevap = Console.ReadLine();
                                } 
                                
                            }
                        }
                    }
                }
            } while (cevap == "e");
            Console.ReadLine();
        }
    }
}
