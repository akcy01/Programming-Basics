#Nesne Tabanlı Programlama Nedir ? 

Nesne tabanlı programlama bir yaklaşımdır.Yazılım geliştirme süreçlerini kısaltan ve sistematik bir hale getiren bir tekniktir.Gerçek hayatı programlama için simüle eden nesneleri baz alan bir programlama tekniğidir.
   Her şey bir nesnedir.
Örnek olarak
-Sen
-Ben
-Personel
-Ürün

-----------------------------------------------------------------------------------------------------------------

#Nesnenin Anatomisi 

Nesne Tabanlı programlamada en küçük esas parça nesne(obje,object)'dir.
Nesneler içlerinde veri tutabilecekleri alanlar barındırırlar.Bu alanlara field diyeceğiz.
Tüm nesneler esasında bir sınıf modellemesi örneğidir.

-----------------------------------------------------------------------------------------------------------------

#Nesne Kavramı

Gerçek hayattaki bir olguyu nesneyi programlama dünyasına tarif ederken o şekilde tarif edip modelleyeceğiz.

-----------------------------------------------------------------------------------------------------------------

#Nesne Modellemesi

Nesnelerin oluşturulabilmesi için öncelikle modellenmesi gerekir.Nesne modellemesi de class'lar ile gerçekleştirilir.
Bir arabayı örnek alalım.Öncelikle bir Araba class'ı oluşturalım.Bu class'da bir arabada olabilecek tüm ortak noktaları tanımlamalıyız.İşte bu şekilde bir Nesneyi modellemiş oluruz ve bu yapılan class sayesinde istediğim herhangi bir araba nesnesi üretip ona değerler atayabiliyorum.Class'ın içinde tanımladığımız ortak noktalar sayesinde mesela audi'nin motor gücünü daha yüksek girebilirsin.Böyle düşün.!

-----------------------------------------------------------------------------------------------------------------

#Nesneler Hangi Türdendir 

Nesneler referans türlü değerlerdir.

-----------------------------------------------------------------------------------------------------------------

#Referans Türlü Değerler Nelerdir 

Ram'de iki türlü bellek vardır Stack ve Heap.

1-)STACK 
Değer türlü değişkenler ve değerleri tutulur.Referansları tutulur.
Örneğin ;
int a = 5;
bool b = true;
!!Kod yazarken stackt'deki bu değişkenlere isimleri üzerinden erişebilmekteyiz.a dediğimizde 5 değerini elde etmekteyiz.

2-)HEAP
Normal şartlar aldında Stack'e doğrudan erişme hakkımız vardır.Lakin Heap'e doğrudan erişim hakkımız yoktur.
Heap'taki nesnelere biz direkt erişemesekte Stack'teki referanslar erişebilmektedir.Biz de Stack'de Heap'daki nesneleri işaret eden referanslar tanımlarız.Örneğin = Nesne1 n1 = new Nesne1() r1 burada referanstır bunun sayesinde Heap'daki nesnelere ulaşırız.

!!Nesnelere ve Class'lara referans türlü denmesinin sebebi işte budur !!!!

-----------------------------------------------------------------------------------------------------------------


















