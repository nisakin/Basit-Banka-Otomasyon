// See https://aka.ms/new-console-template for more information



using BankamatikBakiyeİşlemleri;

using System;
using System.ComponentModel.Design;

namespace BankaOtomasyonu
{
    class Program //sınıf tanımlaması yapılır. 
    {
       
        
        static void Main(string[] args)
        {
                Console.WriteLine("Adınızı girin: ");
                string ad = Console.ReadLine();

                Console.Write("Soyadınızı girin: ");
                string soyad = Console.ReadLine();

                Console.Write("Başlangıç bakiyenizi girin: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal bakiye))//klavyeden girilen değeri decimale çevirir.
                {

                    Kullanici Kullanici = new Kullanici(ad, soyad, bakiye);
                    //Kullanici adlı bir sınıfın bir nesnesi oluşturulur ve bu nesne, kullanıcının girdiği ad, soyad ve başlangıç bakiye değerleri ile başlatılır. Bu nesne, kullanıcının banka hesap bilgilerini temsil eder.


                    Console.WriteLine($"Ad: {Kullanici.Ad}"); // $ işareti dize içerisine değişkenleri doğrudan tanımlar.

                    Console.WriteLine($"Soyad: {Kullanici.Soyad}");//kullanıcının soyadını görüntüler.Kullanıcı sınıfında tutar.

                    Console.WriteLine($"Bakiye: {Kullanici.Bakiye}"); //bakiye bilgisini tutar.

                    Console.WriteLine("Kullanıcı oluşturuldu.");
                    

                    Console.WriteLine("Hoşgeldiniz! " + ad + " " + soyad);
                   


                }
            
            


                while (true) //sonsuz döngüyü başlatır.
            {

                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz:");
                Console.WriteLine("1-Bakiye Görüntüleme");
                Console.WriteLine("2-Para Çekme");
                Console.WriteLine("3-Para Yatırma");
                Console.WriteLine("4-Çıkış Yap");

                string secim = Console.ReadLine();// kullanıcıdan veri girişi istenir.

                if (secim == "1")
                {
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                }
                else if (secim == "2")
                {
                    Console.Write("Çekmek istediğiniz miktarı girin: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal miktar) && miktar > 0)
                    {
                        if (miktar <= bakiye)
                        {
                            bakiye -= miktar;
                            Console.WriteLine(miktar + " TL çekildi. Yeni bakiyeniz: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz miktar.");
                    }
                }
                else if (secim == "3")
                {
                    Console.Write("Yatırmak istediğiniz miktarı girin: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal miktar) && miktar > 0)
                    {
                        bakiye += miktar;
                        Console.WriteLine(miktar + " TL yatırıldı. Yeni bakiyeniz: " + bakiye);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz miktar.");
                    }
                }

                else if (secim == "4")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;

                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                }
            }
        }
    }
} 

    

        
    
            
            

            
            
        
    




















//kullanıcı sınıfı oluşturulmalı.
//bu sınıf ad soyad ve bakiye bilgisini saklamalı.
//ilk aşamada kullanıcıdan isim soyisim bilgisi istenmeli. başlangıç için bir bakiye belirlenmeli.
//hoşgeldiniz mesajı ve mevcut bakiyesi görüntülenmeli.
//kullanıcıya yapmak istediği işlem seçtirilir.
//1-bakiye görüntüleme(mevcut bakiyeyi görüntüler)
//2-para yükleme (kullanıcıdan yatırmak istediği miktar istenir ve mevcut bakiyeye eklenir.)
