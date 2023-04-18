namespace ObjectOrientedPrograming.Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            new MyClass();//İlk olarak oluşturduğumuz constructor metot devreye girecektir.
            new MyClass(2, 4);
            new MyClass("Oğuz Akçay");
        }
    }
}
