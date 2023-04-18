#Loose Coupling Nedir ?

Bir uygulama sürecinde işlevlerin gerçekleştirilebilmesi için nesneler üzerinden operasyonlar yürütülür.Bu nesneler kendi aralarında iş birliği yaparak,birbirlerine hizmet sunmakta ve her biri görevlerini yerine getirerek uygulamayı meydana getirmektedirler.İşte bu işbirliği neticesinde nesneler arasında bağımlılıklar meydana gelebilmektedir.
Bir nesne, kullandığı diğer bir nesne hakkında ne kadar detaya/bilgiye sahipse, o nesneye olan bağımlılık o oranda artmakta ve olası bir değişiklik yahut onarılma durumunda bağımlı olan sınıfta da revizyonu gerekli kılmaktadır.
OOP tasarımlarında nesneler arasındaki bağımlılıkları yüzde yüz bir şekilde ortadan kaldırmanın pek mümkün olmadığını söylemekte fayda vardır.Bundan dolayı nesneler arasındaki bağımlılıkları ortadan kaldıramıyorsak eğer mümkün mertebe törpülemeli bir başka deyişle bu bağımlılıkları yönetilebilir hale getirmeliyiz.

!! İyi bir tasarım; bağımsızlığın olduğu değil,bağımlılıkların kontrol edildiği tasarımdır...

Image2'deki yapı bir LooseCoupling yapısıdır..