public class D
{
    public virtual void X() /* Override edebilmek için virtual ile işaretledik. */
    {
        Console.WriteLine("Merhaba D");
    }
}
public class F : D
{
    sealed public override void X() /* F classından sonra bu X metodunun override edilmemesini isteyebilirsin.İşte burada sealed keywordünü kullanrak bunun önüne geçebiliriz */
    {
        Console.WriteLine("Merhaba F");
    }
}
public class G : F
{
    public override void X() /* Burda hata alacağız. */
    {
        Console.WriteLine("Merhaba G");
    }
}