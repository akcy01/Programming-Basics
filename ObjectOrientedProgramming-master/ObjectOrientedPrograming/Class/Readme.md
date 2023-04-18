#Class Kavramı 

OOP'de bir obje oluşuturabilmek için o öncelikle o objenin/nesnenin öncelikle modellenmesi gerekir.
Bu objenin modelini oluşturmak için class yapısı kullanılır.Bu sayede bir object üretilebilir.
Class'lar referans türüdür.!!
Class'lar türdür !!! Oluşturduğun nesnenin türüdür!!!

-----------------------------------------------------------------------------------------------------------------

#Sınıf İle Nesne Arasındaki İlişki Nedir ?


Class'dan nesne oluşturursun arasındaki ilişki budur.
!!Class'lar namespace içinde,namespace dışında veya class içinde class(Nested Type) oluşturulabilir.Class içinde class oluşturmaya nested type denir.

-----------------------------------------------------------------------------------------------------------------

#Sınıf Modelinden Referans Noktası Oluşturma


Bir class tanımlandığında o class adı artık bir türdür.Haliyle o türü kullanmak için direkt olarak class adını kullanmamız yeterlidir.
Örneğin
OrnekModel w; Bu referans noktası(w) sayesinde heap'de tutulan nesnelere erişebiliriz.
OrnekModel w = new OrnekModel(); Bu w'de bir referans noktasıdır.

-----------------------------------------------------------------------------------------------------------------

#Class Members

1-)Field
Nesne içerisinde veri depoladığımız tuttuğumuz alandır.
Class içerisindeki değişkenlerdir.
Nesne içerisinde değer tutmamızı sağlayan alanlardır.
Örnek;

class MyClass
{
	int a;
}

Field'lar türüne özgü varsayılan değer alırlar.Bu int'in varsayılan değeri 0'dır.Stack'da tutulur.


2-)Property
Property'ler özünde metottur.Metotlardan farkı parametre almamakta ve içerisinde get ve set olmak üzere iki adet blok almaktadır.

!!Property'nin değeri çağrıldığında get bloğu tetiklenir.Eğer property'e değer gönderiyorsan set bloğu tetiklenir.

Yani property yapıları özünde nesne içerisindeki bir field'ın dışarıya kontrollü bir şekilde açılmasını ve kontrollü bir şekilde dışarıdan veri alınmasını sağlayan yapılardır.İşte biz propertylerin bu işlevine encapsulation diyeceğiz.

-----------------------------------------------------------------------------------------------------------------

#Full Property 

En sade property yapılanmasıdır.İçerisinde get ve set blokları tanımlanmalıdır.FullProperty'lerde set bloğu tanımlanmazsa sadece okunabilir(readonly) get bloğu tanımlanmazsa sadece yazılabilir(write only) olacaktır.Bunda get ve set içerisine bazı koşullar eklenebilir.Belirlenen koşullara göre get veya set metodu çalıştırılabilir.

-----------------------------------------------------------------------------------------------------------------

#Prop 

Bir property her ne kadar encapsulation yapsa da temsil ettiği field'daki dataya hiç müdahele etmeden erişilmesini ve veri atanmasını sağlıyorsa böyle bir durumda kullanılan property imzasıdır.Bu da Encapsulation'u uyguluyordur.

public int Yasi {get; set;} Bu prop'dur.Compiler otomatikmen burdaki field'ları dolduracaktır.

-----------------------------------------------------------------------------------------------------------------

#AutoPropertyInitializers

Bir property'in ilk değerini nesne ayağa kalkar kalkmaz verebiliriz.
Örneğin;
class Ornek
{
	public string Adi {get; set;} = "Oğuz";
	public int Yasi {get; set;} = 22;
}

-----------------------------------------------------------------------------------------------------------------

#Class İçinde Class Tanımlamak

Class içinde class tanımlarsak tanımladığımız class tanımlanan class'ın üyesi değildir!!Doğru olmayan bir kullanımdır class içinde class oluşturmak.

-----------------------------------------------------------------------------------------------------------------

#Class Elemanlarına Açıklama Satırı Ekleme

Oluşturduğumuz classların üzerine gelince bir açıklama yazmak isteyebiliriz.Üç tane / işareti koyarak yaparsın
		  /// <summary>
         ///	"Özeti buraya yazarsın !1"
         /// </summary> Karşına böyle bir yapı gelir
Bunun uygulamasını class klasöründe bulabilirsiniz.

-----------------------------------------------------------------------------------------------------------------





















