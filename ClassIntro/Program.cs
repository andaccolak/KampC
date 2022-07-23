namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
            kurs kurs1 = new kurs(); 
            kurs1.kursadi="c#";
            kurs1.egitmen = "engin";
            kurs1.izlenmeorani = 68;
            kurs1.begenmeorani = 2.5;

            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeorani = 38;
            kurs2.begenmeorani = 2.1;


            kurs kurs3 = new kurs();
            kurs3.kursadi = "python";
            kurs3.egitmen = "berkay";
            kurs3.izlenmeorani = 80;
            kurs3.begenmeorani = 0.6;


            kurs kurs4 = new kurs();
            kurs4.kursadi = ("c++");
            kurs4.egitmen = ("andac");
            kurs4.izlenmeorani = 52;
            kurs4.begenmeorani = 4.8;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4};

            foreach (var egitimler in kurslar)
            {
                Console.WriteLine(egitimler.kursadi + ":" + egitimler.egitmen);
            }


            //Console.WriteLine(kurs1.kursadi + ':' + kurs1.egitmen);



        }
    }
    class kurs
    {
        public string kursadi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeorani { get; set; }
        public double begenmeorani { get; set; }
    }
}
