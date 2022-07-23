// See https://aka.ms/new-console-template for more information
namespace Donguler

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {"yazılım kampı", "temel kamp" ,"java kampı", "java", "c#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}