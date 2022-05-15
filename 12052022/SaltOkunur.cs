using System;

class Sinif{
 /*
 readonly fields(salt okunur alanlar): Türkçe olarak "salt 
 okunur". Bu değişkenler yapıcı metot içinde bir kez atama 
 yapıldıktan sonra değiştirilemez ve program sonlanıncaya
 kadar aynı kalırlar.
 */

  public readonly int SaltOkunurAlan;
  /*
  "Sinif" sınıfı içinde, her yerden 
  ulaşılabilir, salt okunur ve int
  türünde olan, "SaltOkunurAlan" 
  adında bir alan tanımladık.
  */

  public Sinif(int SaltOkunurDeger){
    //Yapıcı metodun içindeyiz. Yapıcı metodu
    //"SaltOkunurDeger" ile çağırarak "SaltOkunurAlan"
    //alanına atamayı sınıfın yeni örneği başlatılırken yaptıracağız.

    SaltOkunurAlan = SaltOkunurDeger; //Atama yapıldı.
  }

  //Bu bir getter(alıcı) metottur.
  //"SaltOkunurAlan" alanının içindeki değeri döndürür.
  public int SaltOkunurAlanDegeri(){
    return SaltOkunurAlan;
  }
}

class Program {
  public static void Main (string[] args) {
    int AlanDegeri = 4; //Yerel değişken
    Sinif sinif = new Sinif(AlanDegeri); //"sinif" "AlanDegeri" ile başlatıldı.
    Console.WriteLine(sinif.SaltOkunurAlanDegeri());//Çıktı: 4
  }
}
