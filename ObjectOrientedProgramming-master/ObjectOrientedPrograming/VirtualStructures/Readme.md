#Sanal Yapılar Nedir ?


Sanal yapılar,bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflarda da tekrar bildirilebilen yapılardır.Bu yapılar metot ya da property olabilir.

-----------------------------------------------------------------------------------------------------------------

#Sanal Yapılar Ne İçin Kullanılır


Bir sınıfta tanımlanmış olan herhangi bir member'ın kendisinden türeyen alt sınıflarda ezilip yeniden yazılıp yapılandırılması için kullanılır.Bu sanal yapı alt sınıflarda illa ki ezilip yeniden yapılandırılmak zorunda değildir!!!

-----------------------------------------------------------------------------------------------------------------

#Sanal Yapılar Nasıl Ezilir


Bir class'da virtual keyword'ü kullanılarak sanal hale hetirilmiş bir member(property ya da method),bu class'tan miras alınan torunlarında ezilmek ya da yeniden yazılmak isteniyorsa ilgili class'da imzası override keyword'ü ile işaretlenmiş vaziyette tekrardan aynı member oluşturulur.

-----------------------------------------------------------------------------------------------------------------