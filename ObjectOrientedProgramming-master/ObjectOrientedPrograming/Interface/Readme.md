#Interface Nedir ? 


C# Interface, yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
Bir Class’ın methodlarını belirtmek için kullanılırlar. Bu methodların içeriğine müdahale etmezler. Programcı istediği allgoritma ile metodların içerisini doldurup işlemini tamamlayabilir.

-----------------------------------------------------------------------------------------------------------------

#Interface Hakkında Bilinmesi Gerekenler ?


**Erişim belirleyici özelliği varsayılan “public” olarak ayarlıdır.

**Private, Protected, Static gibi tanımlanamazlar

**İçerisine kod parçası eklenemez sadece tanımlama yapılabilir.

**Başka bir interface’den türetebiliriz.

**Başka bir class’tan türetemeyiz

**Interface kullanan Class’lar interface içerisindeki tüm metodları implement etmek zorundadır.

**Interface içerisinde yanlızca metodlar ve propertyler tanımlanır, field tanımlanamaz.

-----------------------------------------------------------------------------------------------------------------