#Inheritance(Kalıtım) Nedir


OOP'nin en önemli özelliğidir.Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir.

Aynı aile grubundan gelen nesnelerin ya da yatayda eşit seviyede olan tüm olguların benzer özelliklerini tekrar tekrar her birinde tanımlamaktansa bir üst sınıfa tanımlanmasını ve her bir sınıfın bu özellikleri üst sınıftan kalıtımsal olarak almasını sağlamaktadır.

Örnek olarak kadın ve erkek insandan türer.
bir diğer örnek insan ve hayvan canlıdan kalıtım alır.Böyle düşünebiliriz..

-----------------------------------------------------------------------------------------------------------------

#C# Programlama Dilinde Kalıtım


C# Dilinde kalıtım sınıflara özel bir niteliktir.
Yani bir sınıf sade ve sadece bir sınıftan kalıtım alabilir.

-----------------------------------------------------------------------------------------------------------------

#C#'da Kalıtım Nasıl Alınır 


C#'da iki sınıf arasında kalıtımsal ilişki kurabilmek için ":" operatörü kullanılmaktadır.
Örneğin;
class Araba 
{
	................
	................
	................
}

class Opel : Araba   //Opel sınıfı Araba sınıfından kalıtım alsın dedik.  
{

}

-----------------------------------------------------------------------------------------------------------------


#Base Class Ve Derived Class


Kalıtım veren sınıfa Base class.Kalıtım alan sınıfa Derived class denir.
!!Bir sınıfın sadece bir tane base classı olabilir.Dolaylı yoldan da olsa Ata sınıfın olabilir ama base class'ın olamaz.Şöyle düşün baban senin base class'ındır deden atandır.Böyle düşün deden senin base class'ın değildir atandır.!!
!!Bir base classın birden fazla derived class'ı olabilir.Bir babanın birden çok çocuğu olabilir diye düşün.

-----------------------------------------------------------------------------------------------------------------

#Kalıtımda Nesne Üretim Sırası


Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce o sınıflardan sırasıyla nesne üretilir.Yani heap'de kalıtım aldığı sınıf kadar yer tutulur.Heap'de gereksiz yer kaplamış olur.1 Tane nesne ürettiğini sanarsın ama kalıtımsal olarak birden çok nesne üretilir.

-----------------------------------------------------------------------------------------------------------------

#Bir Sınıftan Base Class Constructur'ına Ulaşım


Madem ki,herhangi bir sınıftan nesne üretimi gerçekleştirilirken öncelikle base class'ından nesne üretiliyor,bu demektir ki önce base class'ın constructor'ı tetikleniyor.

Haliyle bizler nesne üretimi esnasında base class'ta ğretilecek olan nesnenin istediğimiz constructor'larını tetikleyebilmeli yahut varsa parametre bu değerleri verebilmeliyiz.

İşte bunun için "base" Keyword'ünü kullanmalıyız.

!!DEFAULT CONSTRUCTOR!!
Sen ilgili class'da constructor oluşturmasan dahi orda default olarak bir constructor vardır.Yoksa nesne üretemezdi!!!!

Base keyword'ün kullanımını ilgili dosyada anlattım.!!!!

-----------------------------------------------------------------------------------------------------------------

#Tüm Nesnelerin Atası Object Türü


C# Programlama dilinde tüm sınıflar Object sınıfından türetilir.Bundan dolayı bir nesne yazdığında otomatik olarak 
Equals,GetHashCode,GetType,ToString gibi metotlar gelir..C#'da Tüm Sınıflar object sınıfından türetilir bunu asla unutma !!

-----------------------------------------------------------------------------------------------------------------