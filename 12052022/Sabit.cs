using System;

class Daire{
  public const float PI = 3.14f; //3.14 değerini taşıyan PI sabit **alanı.

  public double Alan(double yaricap){
    return PI*yaricap*yaricap;
  }

  public double Cevre(double yaricap){
    return 2*PI*yaricap;
  }
}

class Program {

  const float sabitAlan = 0.24f;
  /*
  sabitAlan", "Program" **sınıfı içinde  tanımlandığı 
  için **sabit "alan"dır.
  */
  
  public static void Main (string[] args) {
    /*
    Sabit: Değişken gibi hafızada yer kaplayan
    ve ancak değişkenden farklı olarak **yapıcı 
    metodun içinde ataması yapıldıktan sonra
    içindeki değerin değiştirilmesinin mümkün 
    olmadığı ve tanımlandığı yerde atama 
    yapılması gereken yapılardır.

    const [tip] [sabit_adi] = [sabit_degeri];
    şeklnde tanımlanır.
    */

    const int sabitTamSayi = 1; 
    /*
    sabitTamSayi", "Main" metodu içinde **yerel olarak
    tanımlandığı için **sabittir.
    */
    
    Console.WriteLine($"Sabit Tam Sayı değeri: {sabitTamSayi}"); //Çıktı: 1
    Console.WriteLine($"Sabit Alan değeri: {sabitAlan}"); //Çıktı: 0.24

    Console.WriteLine(); //Daha okunaklı olması
                         //boşluk bırakıldı.

    Daire daire = new Daire(); //"Daire" sınıfının "daire" adında
                               //yeni bir örneği başlatıldı.
    
    double dAlan = Math.Round(daire.Alan(5), 1); 
    /*
    Başlatılan örnekten "Alan" işlevi
    5 "yaricap" değeri ile çağrıldı.
    ve bu değer "dAlan" değişkenine atandı.
    Beklenen "dAlan" değeri: 78.5

    (
    Burada "Math" sınıfının "Round" metodu ile yuvarlama işlemi
    yapıldı çünkü programlama dillerinin genelinde kayar noktalı
    sayıların depolamısı ile ilgili bir olay var

    Eğer 0.2 ve 0.1 toplarsanız 0.3 sayısını elde edersiniz değil mi?
    Makineye göre bunun cevabı hayır çünkü makine bu toplamın sonucunu
    0.30000000000000004 olarak bulur. 

    Console.WriteLine(0.2+0.1); //Çıktı: 0.30000000000000004

    Detaylı (İngilizce) anlatım için:
    www.youtube.com/watch?v=WJgLKO-qac0
    )
    */

    double dCevre = Math.Round(daire.Cevre(5), 1); //56. satıra bakın.
                                                   //Beklenen "dCevre" değeri: 31.4
                                    
    Console.WriteLine($"Alan: {dAlan}"); //Çıktı: 78.5
    Console.WriteLine($"Çevre: {dCevre}"); //Çıktı: 31.4
    Console.WriteLine($"PI sayısı: {Daire.PI}"); //Çıktı: 3.14
    /*
    Bir sınıf içinde tanımlanmış bir sabit "alan"a 
    SinifAdi.SabitAlanAdi şeklinde ulaşılabilir.
    */
  }
}
