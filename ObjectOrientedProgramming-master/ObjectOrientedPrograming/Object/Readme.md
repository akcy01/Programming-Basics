#Nesne Nedir ? 


İçerisinde bir veya birden fazla değer barındırabilen anlamlı verileri bir bütün olarak barındıran bir organizmadır.
Örneğin Bir çalışanın ismi soy ismi yaşı vs vs gibi değerler.

-----------------------------------------------------------------------------------------------------------------

#New Operatörü İle Nesne Oluşturma


C#'da nesne oluşturabilmek için "new" operatörü kullanılmaktadır.

-----------------------------------------------------------------------------------------------------------------

#Referans Nedir ?


RAM'in Stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen/referans eden değişkenlerdir,noktalardır.Class ile nesne oluşturabilirsin.Bu hem referans hem nesne olmaktadır.Interface,Abstract class bunlarla nesne değil referans oluşturabilirsin.

-----------------------------------------------------------------------------------------------------------------

#Referanssız Nesneler


Bir nesne oluşturulduğu an herhangi bir referansla işaretlenmezse eğer heap'e yerleştirilir.Lakin bu nesneye tarafımızca bir daha erişemeyiz.Haliyle ilgili nesneyle aramızdaki tek diyalog oluşturma anıdır.

-----------------------------------------------------------------------------------------------------------------

#Referanssız Nesne Üzerindeki Elemanlara Nasıl Erişilir ? 


Eğer ki bir nesne referanssızsa bunu oluşturabilmekteyiz.Lakin bu nesne memory'de gereksiz yer kaplayacağından dolayı belli bir süre sonra garbage collector tarafından temizlenenecektir.Referanssız nesneye erişmek mümkün değildir.

Garbage Collector : Heap'de referanssız olan nesneleri imha etmekten temizlemekten sorumlu bir yapılanmadır.

-----------------------------------------------------------------------------------------------------------------

#Object Initializer İle Değer Atama


Bunun örneği program.cs'de mevcuttur.

-----------------------------------------------------------------------------------------------------------------