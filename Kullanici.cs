using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikBakiyeİşlemleri;


public class Kullanici // Kullanici isimli bir sınıf oluşturur
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public decimal Bakiye { get; set; }

    public Kullanici(string ad, string soyad, decimal bakiye)
    {
        Ad = ad;
        Soyad = soyad;
        Bakiye = bakiye;
    }
}




