#InterfaceSegregation Nedir?

Bir nesnenin yapması gereken her farklı davranışların, o davranışlara odaklanmış özel interfaceler ile eşleşmesini öneren prensiptir.

Böylece ihtiyaç olan davranışları temsil eden interfaceler eşliğinde ilgili sınıflara kazandırabilir ve hiçbir sınıfın kullanmadığı bir imzayı zorla implement etmek zorunda kalmaksızın inşa sürecine devam edebiliriz.

Sınıflara ihtiyaç duymadıkları imzaları arayüzlerle zorlayarak işlevsiz metotlar eklemek ISP'ı ihlal etmek demektir.

Hacmi geniş olan ve davranışsal olarak farklı yetenekleri içerisinde barındıran interface'ler mümkün mertebe yeteneklerine göre parçalanarak küçültülmelidirler.

Kümülatif olarak yetenekleri barındıran interfaceler sınıflara uygulandığı taktirde çoğu sınıf için birçok yeteneğe ihtiyac duyulmayacağı için anlamsız kalıp olarak tanımlanıp kalacaktırlar.Bu da istenmeyen bir durumdur.

Genellikle bu tarz istenmeyen durumlar salt olarak NotSupportedException veya NotImplementedException gibi hataların fırlatıldığı metotlarda fark edilebilmektedirler.

Yazılımdaki davranışları tek bir bütün olarak tutmaktansa, birbirlerinden bağımsız olacak şekilde birden çok parçaya bölmek ideal kod yapısını ortaya çıkarır.

//////////////////////////////////////////////////////SON OLARAK////////////////////////////////////////////////

**ISP ihlali, doğrudan LSP ve SRP'ın da ihlaline sebebiyet vermektedir.
**ISP, sınıf tarafından desteklenmeyecek metotların lüzumsuz yere tanımlanmamasına karşı odaklanırken, LSP ise benzer şekilde bu tarz işlevisz metotların barındırıldığı sınıflardan olan nesnelerin kendi aralarında olan değişimleri sürecinde patlama ya da boşa çıkma riskini ortadan kaldırmaya odaklanmaktadır.