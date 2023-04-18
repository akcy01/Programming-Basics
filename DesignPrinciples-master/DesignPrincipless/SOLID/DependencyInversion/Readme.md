#Dependency Inversion Nedir ? 

Bir sınıfın herhangi bir türe olan bağımlılık durumuna karşı dikkatimizi çeken ve bu bağımlılığın mümkün mertebe tersine çevrilmesini öneren bir ilkedir.Bu prensip; geliştiricinin herhangi bir türe bağımlı olmadığını, bilakis türetin/yani nesnelerin geliştiriciye bağımlı olduğunu savunur.

Yazılımda gidişat tek bir davranışa bağımlı olmamalı, bilakis davranışlar sizin kararınıza bağımlı olmalı...

Dependency Inversion prensibi, bir sınıfın concrete/somut sınıflara değil onların abstractionlarına bağlı olması gerektiğini önerir.Böylece o sınıf herhangi bir somut sınıfa bağımlı olmayacak, tam tersi somut sınıflar ilgili sınıflara bağımlılık sergiliyor olacaktır.

Böylece hiçbir sınıf somut yapılanmalara değil onların soyut yapılarına güvenecektirler.