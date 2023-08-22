// See https://aka.ms/new-console-template for more information
class kisibilgisi
{
    public string adsoyad;
    public string egitimdurum;
    public string memleket;
    public string hobiFobi;
    public void bilgileri()
    {
        Console.WriteLine("Adım ve Soyadım: {0} \nEğitim durumum: {1}\nMemlektim: {2}\nHobilerim ve Fobilerim: {3} ", adsoyad, egitimdurum, memleket, hobiFobi);
    }
    
}
class adısoyadı : kisibilgisi
{
    public adısoyadı(string adsoyad)
    {
        this.adsoyad = adsoyad;
    }
}
class egitimdurumu : kisibilgisi
{
    public egitimdurumu(string egitimdurum)
    {
        this.egitimdurum = egitimdurum;
    }
}
class hobivefobi:kisibilgisi
{
    public hobivefobi (string hobiFobi)
    {
        this.hobiFobi = hobiFobi;
    }
}
class nereli : kisibilgisi
{
    public nereli(string memleket)
    {
        this.memleket = memleket;
    }
}


class program
{
    static void Main(string[] args)
    {
        kisibilgisi k1 = new kisibilgisi();
        k1.adsoyad = "Ahmet Melih Pekmez";
        k1.egitimdurum = "Lisans";
        k1.memleket = "Elazığ";
        k1.hobiFobi = "Hobilerim futbol oynamak, kod yazmak;Fobim ise yüksekliktir.";
        k1.bilgileri();

    }
    
}
