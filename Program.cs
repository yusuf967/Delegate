namespace _01.Delegates
{
    internal class Program
    {

        delegate void MyDelegate(int sayi1, int sayi2);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Add);
            myDelegate += Impact;
            myDelegate.Invoke(5, 8);
        }

        static void Add(int sayi1,int sayi2)
        {
            Console.WriteLine($"Toplam= {sayi1+sayi2}");
        }

        static void Impact(int sayi1,int sayi2)
        {
            Console.WriteLine($"Çarpma= {sayi1 * sayi2}");
        }
    }
}