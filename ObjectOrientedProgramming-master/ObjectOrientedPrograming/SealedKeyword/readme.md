#Sealed Keyword'ü Nedir?


Bir sınıfın miras vermesini yahut başka bir deyişle başka bir sınıf tarafından miras alınmasını engelleyen bir keyword'dür.Sadece sınıflarda ve sadece override edilmiş metotlarda kullanılabilir.

-----------------------------------------------------------------------------------------------------------------

#Metot Üzerinde Sealed Keyword'ünün İşlevi


Kalıtımsal durumlarda,atalardan gelen ve birinci dereceden alt sınıf tarafından 'override' edilmiş olan 'virtual' memberlarının hiyerarşideki sonraki sınıflar tarafından 'override' edilmesini ilgili member'ı sealed ile işaretleyerek engelleyebiliriz.Program2.cs'de uyguluyorum.
Pratikte bu yöntem sayesinde üst sınıfın davranışını güvenli bir şekilde korumuş ve ilgili metodun değiştirilmesini önlemiş oluyoruz. 

-----------------------------------------------------------------------------------------------------------------

#Sealed Keyword'ü Hangi Durumlarda Kullanılır?


1-)Sınıfların davranışlarını korumak istediğimizde.
2-)Performans İyileşmesi İstediğimizde.
3-)Singleton Design Pattern.

-----------------------------------------------------------------------------------------------------------------