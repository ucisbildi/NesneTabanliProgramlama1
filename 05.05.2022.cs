using System;

class Program {
  /*
  Değişken(Variable): Kullanılan dilin izin verdiği     
  veri tipleri çerçevesinde istediğimiz verileri, 
  bilgileri saklamamıza sağlayan yapılardır. Varsayılan
  değerleri **yoktur("null"dur)**.

  Metot(Method): Program içerisinde bir işi, bir görevi 
  yerine getirmek için yazılmış alt programlardır.

  Nesne(Object): Özellik veya işlevden herhangi birine 
  veya ikisine birden sahip olan varlıklardır.

  Sınıf(Class): Bir nesnenin sınırlarını belirleyen     
  yapıdır.

  Alan(Field): Sınıf sınırları içinde tanımlanmış     
  değişkenlerdir. Varsayılan değerleri **vardır**.

  İşlev(Function): Sınıf sınırları içinde tanımlamış 
  her fonksiyon işlevdir.

  Özellik(Property): Sınıf içinde tanımlanmış erşim ve 
  değiştirme yetkisi işlevlerle kısıtlanabilen işlev benzeri   
  değişkenlerdir.
  */


  /*
  Bir nesne oluşturmak için sınırları belli bir yapı(bir 
  sınıf) oluşturulmalıdır.

  class SinifAdi{
    "SinifAdi" adında boş bir nesne oluşturumuş ve bu   
    nesnenin sınırlarını belirlemiş oldunuz.
  }

  """""""""""""""
  class SinifAdi{
  }
  """""""""""""""
  */

  /*
    ERİŞİM DEĞİŞTİRİCİLER:

    Erişim değiştiricileri görevi bir nesneye nereden erişim
    sağlanabileceğini denetlemek ve kısıtlamaktır.

    public(halka açık), private(özel), protected(korumalı),
    internal(dahili), protected internal(dahili korumalı)   
    ve private protected(özel korumalı) şeklinde erşim 
    değiştiricileri vardır. Ancak şu an için public(halka açık)
    ve private(özel) erişim değiştiricilerini inceleyeceğiz.

    public(halka açık): Başına public erişim değiştiricisi
                        yazılan nesnelere istenilen her yerden 
                        ulaşılabilir(yaşam alanının dışına      
                        çıkartılabilir).

    private(özel): Başına private erişim değiştiricisi yazılan
                   nesneler tanımlandığı yaşam alanının(Süslü 
                   parantezin açıldığı yerden kapatıldığı
                   yere kadar) içinde kalır ve dışarı           
                   çıkartılamazlar.

    **Bir sınıf içinde bir işlevi yada alanı alan yada işlevin başına  
    erşim değiştirici koymadan tanımlarsanız bu alan yada işlev "private"
    erşim değiştiricisi ile otomatik olarak tanımlanır.
  */
  
  class Oyuncu
  {
    public string adi;
    public string takimi;
    public byte formaNo;
    /*
    adi, takimi ve formaNo "Oyuncu" sınıfı
    içinde tanımlanmış alanlardır.
    */

    /*
    Bir metot (dolayısla aynı zamanda bir işlev) farkı parametereler 
    ile çağırılmak istenilebilir. Örneğin:

    public int Topla(int a, int b)
    {
      return a+b;
    }

    public int Toplam(int a, int b, int c)
    {
      return a+b+c;
    }

    61. satırda a ve b adında, int tipinde iki parametre alan 
    "Topla" fonksiyonu tanımlanmış. Sadece iki parametre alan
    "Topla fonksiyonu tanımlanmış olsaydı "Topla" metodu "Topla(2, 3)"
    gibi çağırılabilecekti. Ancak 66. satırda 3 parametreli "Topla"
    fonksiyonu tanımlanmış. Bu **aynı "Topla" metodunu** 3 parametre   
    ile çağırmaya olanak sağlamıştır. **Her aşırı yükleme hafızaya 
    yük bindirir.** Yukarıdaki "Topla" metodu örnek olması için aşırı
    yüklenmiştir. Bunun gibi bir metodun:

    public int Topla(int birinci, int ikinci, params int[] digerleri)
    {  
      return birinci+ikinci+digerleri.Sum();
    }

    şeklinde tanımlanması daha mantıklıdır ve bu kodu yazan kişinin 
    hafıza yönetiminin iyi olduğunu gösterir.
    */
    
    public Oyuncu()
    {
      /*
      Bu bir yapıcı(constructor) metot.
      Yapıcı işlev bir işlev(en nihayetinde bir metot) olduğu için
      çeşitli parametre alabilir yada parametre almasa bile
      tanımlanmınmış olan görevinden başka şeyler yaptırılabilir.
      */

      Console.WriteLine("Yapıcı metot çalıştı");
      /*
      Bu kod sınıfın her yeni örneği başlatıldığı zaman
      "Yapıcı metot çalıştı" yazısının ekrana yazılmasını sağlar.
      */
    }

    //Birinci aşırı yükleme
    public Oyuncu(string ad)
    {
      adi = ad;
    }

    //İkinci aşırı yükleme
    public Oyuncu(string ad, string tkm)
    {
      adi = ad;
      takimi = tkm;
    }

    //Üçüncü aşırı yükleme
    public Oyuncu(string ad, string tkm, byte fn)
    {
      adi = ad;
      takimi = tkm;
      formaNo = fn;
    }
    
    public string BilgiAl()
    {
      return string.Format("{0} {1} - {2}", adi, takimi, formaNo);
    }

    public void TakimDegistir(string yeniTakim)
    {
      takimi = yeniTakim;
    }

    /*
    BilgiAl ve TakimDegistir "Oyuncu" sınıfı içinde
    tanımlanmış işlevlerdir.
    */
  }
  
  public static void Main (string[] args) {
    //Sınıftan bir nesne oluşturma:
    //!!! Değişkenler gibi tanımlanmazlar !!!
    
    /*
    //Birinci tip nesne oluşturma:

    SinifAdi nesne;
    nesne = new YapiciMetot()

    //Aynı sınıftan bir nesne dizisi(birden fazla nesne) 
    //tanımlanmak istenirse nesneler bu şekilde oluşturulmalı.
    */

    
    //İkinci tip nesne oluşturma:
    //SinifAdi nesne = new YapiciMetot()
    Oyuncu oyuncu = new Oyuncu();
    /*

    İlk başta gördüğünüz "Oyuncu" nesnenin tipidir.

    Sonraki "oyuncu1" nesnenin adıdır.

    "=" atama operatörüdür.

    "new" kendinden sonra gelecek "yapıcı metodu" çağrıp
    bu yapıcı metodun bağlı olduğu sınıfın yeni bir örneğini
    başlatacaktır

    "Oyuncu()", "Oyuncu" sınıfının yapıcı(başlatıcı) 
    metodudur. Bir sınıf oluşturulduğunda o sınıfın yapıcısı da       
    otomatik olarak oluşturulur. Bu **yapıcının(İng.:         
    constructor) adı sınıf adı ile aynıdır. Her ne kadar 
    yapıcılar otomatik olarak tanımlanmış olsa da yapıcıların 
    normal görevlerinden başka özel bir şey yapması istenirse bu 
    yapıcılar sınıf içinde özel olarak tanımlanabilir.
    */

    Console.WriteLine(oyuncu.BilgiAl()); //261. satıra gidin.
    //Çıktı:  - 0

    Console.WriteLine(); //Ekrandaki yazıların daha okunaklı
                        //olması için bir satır boşluk bırakıldı.
    
    Oyuncu oyuncu1 = new Oyuncu();
    
    oyuncu1.adi = "Bafetimbi Gomis";
    oyuncu1.takimi = "Galatasaray";
    oyuncu1.formaNo = 18;
    /*
    **Sadece "oyuncu1" nesnesi için** yaratıldığı sınıf olan 
    "Oyuncu" sınıfında bulunan alanlar yukarıdaki veriler ile
    doldurulmuştur.

    "nesne.alan = deger" şekinde **nesnenin içinde bulunan**
    alana "deger" atanır.
    Sadece"nesne.alan" yazıldığında ise nesnenin içindeki
    varsayılan yada atanan değer gösterilir.
    */
    Console.WriteLine(oyuncu1.adi); //Çıktı: Bafetimbi Gomis
    /*
    Yukarıdaki kodun çıktı olarak ekramna "Bafetimbi Gomis" 
    yazdırmasının nedeni 111. satırda "oyuncu1.adi" alanına 
    "Bafetimbi Gomis" değerinin atanmış olmasıdır.

    Peki ya bu değerler atanmamış olsaydı ekranda ne görürdük?
    Cevap **sadece alanlara(sınıf içi değişkenler) -direkt olarak
    bir sınıfın içinde tanımlanmalıdırlar. Sınıfın içindeki bir 
    işlevin içinde tanımlanmış olan değişkenler değişkendir alan 
    değil.- özgü varsayılan değerler olacaktır.

    *********************************************************
    Varsayılan **alan** değerleri:
      Tamsayı tipleri(byte, short, int, long vb.) için 0,
      Kayan noktalı sayı tipleri(float, double) için 0.0,
      Matıksal ifadeler(bool) için false,
      Karakter ve dizinler(char, string) için '\0' yada "\0",
      Referans tipleri için "null"dur.
    *********************************************************
    */

    Console.WriteLine(oyuncu1.BilgiAl());
    //Çıktı: Bafetimbi Gomis Galatasaray - 18

    oyuncu1.TakimDegistir("Al Hilal");
    //"oyuncu1"in takımı "Al Hilal" olarak değiştirildi.

    Console.WriteLine(oyuncu1.BilgiAl());
    //Çıktı: Bafetimbi Gomis Al Hilal - 18

    /*
    Bir sınıfın işlevine nesne.Islev() şelinde ulaşabilirsiniz.
    */

    Console.WriteLine(); //Ekrandaki yazıların daha okunaklı
                        //olması için bir satır boşluk bırakıldı.
    
   //Üçüncü tip nesne oluşturma:
    Oyuncu oyuncu2 = new(); 
    /*
    SinifAdi nesne = new();

    C# 9.0 ve sonrası için geçerlidir. Yapıcı metodu özel olarak
    çağırmak(91. satıra bakın) gerekmez. 
    */

    oyuncu2.adi = "Cristiano Ronaldo";
    oyuncu2.takimi = "Manchester United";
    oyuncu2.formaNo = 7;
    /*
    3. tip nesne oluşturma en düşük C# 9.0 için sorun oluşturmaz. 
    162, 162 ve 164. satırdaki atamalar da önceki cümlede 
    bahsedilen durumda sorun oluşturmaz.
    */

    Console.WriteLine(oyuncu2.BilgiAl());
    //Çıktı: Cristiano Ronaldo Manchester United - 7

    //Birinci aşırı yükleme örneği
    Oyuncu oyuncu3 = new Oyuncu("Zlatan Ibrahimovic");

    Console.WriteLine(); //Ekrandaki yazıların daha okunaklı
                        //olması için bir satır boşluk bırakıldı.
    
    Console.WriteLine(oyuncu3.BilgiAl());
    //Çıktı: Zlatan Ibrahimovic  - 0

    //İkinci aşırı yükleme
    Oyuncu oyuncu4 = new Oyuncu("Wesley Sneijder", "Galatasaray");

    Console.WriteLine(); //Ekrandaki yazıların daha okunaklı
                        //olması için bir satır boşluk bırakıldı.
    
    Console.WriteLine(oyuncu4.BilgiAl());
    //Çıktı: Wesley Sneijder Galatasaray - 0

    //Üçüncü aşırı yükleme
    Oyuncu oyuncu5 = new Oyuncu("Didier Drogba", "Galatasaray", 11);

    Console.WriteLine(); //Ekrandaki yazıların daha okunaklı
                        //olması için bir satır boşluk bırakıldı.

    Console.WriteLine(oyuncu5.BilgiAl());
    //Çıktı: Didier Drogba Galatasaray - 11
  }
}
