//Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.
//Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı
//Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.
//Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.
using System;

public class Araba
{
    // Özellikler
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    private int kapıSayısı;

    // Kapı Sayısı için kapsülleme
    public int KapıSayısı
    {
        get { return kapıSayısı; }
        set
        {
            if (value == 2 || value == 4)
            {
                kapıSayısı = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı Sayısı sadece 2 veya 4 olabilir. Değer -1 olamaz.");
                kapıSayısı = -1;
            }
        }
    }

    // Yapıcı Metot
    public Araba(string marka, string model, string renk, int kapıSayısı)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayısı = kapıSayısı;
    }

    // Bilgileri yazdır
    public void BilgiGoster()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapıSayısı}");
    }
}

class Program
{
    static void Main()
    {
        // 1-4 kapı sayısı ile araba nesnesi oluşturma
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        araba1.BilgiGoster();

        // Geçersiz kapı sayısı ile araba nesnesi oluşturma
        Araba araba2 = new Araba("Honda", "Civic", "Kırmızı", 3);
        araba2.BilgiGoster();
    }
}
