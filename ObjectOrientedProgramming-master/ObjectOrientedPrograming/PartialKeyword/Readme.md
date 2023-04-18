#Partial Yapılanması Nedir ?

Bir class'ın, struct'ın yahut interface'in aynı yahut farklı dosyalarda birden fazla parçasının tasarlanmasını lakin bu parçaların özünde bir bütün olarak kullanılmasını sağlayan,kodun daha organize ve kolay okunabilirliğini arttıran özelliklerdir.Normal şartlarda aynı namespace altında birden fazla aynı isimde yapı bulundurulamaz ama bu yapılar partial olarak tasarlanıyorsa bu mümkündür !

-----------------------------------------------------------------------------------------------------------------

#Partial Yapılanmasının Kullanım Amacı Nedir ? 

1-)Kod Bölümleme
Büyük ve karmaşık yapıdaki sınıfları daha okunabilir ve düzenlenebilir parçalara bölmek için kullanılabilir.

2-)İş Bölümü
Ekiplerin,aynı sınıfın farklı kısımlarını aynı anda geliştirebilmeleri için kullanılabilir.

-----------------------------------------------------------------------------------------------------------------

#Partial Yapılanmalarda Kısıtlamalar Nelerdir ? 

Parça olması planlanan tüm yapılar partial keyword'ü ile işaretlenmelidir.
Tüm partial yapılar aynı namespace altında bulunmalıdır.Farklı projeler yahut modüllere yayılamaz.
Partial olan bir yapının tüm parçalarının türleri ve isimleri aynı olmak zorundadır.

-----------------------------------------------------------------------------------------------------------------

#Partial Metotlar Nelerdir ? 

Partial yapılar partial metotlar barındırabilirler.Partial metotlar, sınıfın bir parçasında geliştiricinin metot bildiriminde bulunmasını sağlar.Başka bir parçasında ise diğer geliştirici tarafından bu metot tanımlanabilir.

-----------------------------------------------------------------------------------------------------------------