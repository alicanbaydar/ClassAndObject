using System;

namespace FabrikaPersonelAktivitesi
{
    class PersonelBilgisi
    {
        public string isim;                 // bilinçli public
        public string soyisim;
        public int tecrube;

        public int Maas { get; set; }
        public PersonelBilgisi() { }
        public PersonelBilgisi(string isim, string soyisim)             //const ile this kullanım
        {
            this.isim = isim;
            this.soyisim = soyisim;
            Console.WriteLine("Kişi oluşturuldu (Parametre girilerek): " + isim + soyisim);

        }
        public PersonelBilgisi(string ad, string soyad, int tecrube)    //overloading göstermekamaçlı tecrübe eklendi
        {
            isim = ad;
            soyisim = soyad;
            this.tecrube = tecrube;
            Console.WriteLine("Tecrübe bilgili kişi oluşturuldu");
        }

        private int kimlikNo;                               //Prop kullanım amaçlı
        public int KimlikNo {
            get { return kimlikNo; }
            set { kimlikNo = value; }
        }

        private int yas=18;                               //pro kullanımı yaş ile koşullandı
        public int Yas { get { return yas; }
             set { if (value > 18) yas = value; }
        }
    }

    class InsanKaynaklari
    {
        public void IseAlim(string isad, string issoyad)
        {
            Console.WriteLine(isad + " " + issoyad + " " + "işe alındı.");
        }
        public void IsCikis()
        {
            Console.WriteLine("İş çıkışı yapıldı");
        }
    }

    class Muhasebe
    {
        public void MaasVer(string maasAd, string maasSoyad, int maas)
        {
            Console.WriteLine("{0} {1} kişisine {2}TL maaş verildi ", maasAd, maasSoyad, maas);
        }
    }

    class MeslekSinifi : PersonelBilgisi
    {
        private string meslek;
        public string Meslek { get
            {
                return meslek;
            }
            set 
            { 
                if ((value=="MaviYaka")||(value=="BeyazYaka"))
                meslek=value;
                else
                {
                    meslek = "Farklı meslek grubu";
                }
            }
        }
        public void MeslekBilgi()
        {
            Console.WriteLine("Girilen Meslek Bilgisi:"+ Meslek);
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                PersonelBilgisi pbilgi1 = new PersonelBilgisi();            //ilk personel oluşturuldu
                pbilgi1.isim = "Ahmet";
                pbilgi1.soyisim = "Hancı";
                Console.WriteLine("{0} {1} kişisi oluşturuldu .", pbilgi1.isim, pbilgi1.soyisim);

                PersonelBilgisi pbilgi = new PersonelBilgisi("Alican", "Baydar");   //ikinci personel oluştu
                
                PersonelBilgisi pbilgi2 = new PersonelBilgisi("Atakan", "Baydar", 10);  //tebrübe bilgili kişi oluştu
                pbilgi2.Yas = 10;                                                     //tecrübe bilgili kişinin yaşı girildi
                Console.WriteLine("10 yaşında olamayacığı için yaşı 18 girildi yaş:"+ pbilgi2.Yas);

                InsanKaynaklari ik = new InsanKaynaklari();
                ik.IseAlim("Deniz", "Yanar");                            // deniz yanar kişisi işe alındı
                ik.IsCikis();                                           // herhangi iş çıkışı

                Muhasebe muhasebe = new Muhasebe();
                muhasebe.MaasVer(pbilgi.isim, pbilgi.soyisim, 2000);            //pbilgi nesne
                pbilgi.Maas = 3500;                                             

                MeslekSinifi meslekSinifi = new MeslekSinifi();
                meslekSinifi.Meslek = "MaviYaka";
                meslekSinifi.MeslekBilgi();
                
            }   

        }

}
