namespace HelloWorld
{
    class Program
    {
        static Random rnd = new Random();
        static int[] MagassagTMB = new int[13];
        static double[] TestsulyTMB = new double[13];
        static void Main(string[] args)
        {
            Console.WriteLine("Kecskepásztor feladat");
            Feladat1(); Console.WriteLine("\n----------------------\n");
            Feladat2(); Console.WriteLine("\n----------------------\n");
            Feladat3(); Console.WriteLine("\n----------------------\n");
            Feladat4(); Console.WriteLine("\n----------------------\n");
            Feladat5(); Console.WriteLine("\n----------------------\n");
            Feladat6(); Console.WriteLine("\n----------------------\n");
            Feladat7(); Console.WriteLine("\n----------------------\n");
            Feladat8(); Console.WriteLine("\n----------------------\n");
            Feladat9(); Console.WriteLine("\n----------------------\n");
        }

        private static void Feladat9()
        {
            Console.WriteLine("Feladat 9: Írjon programot mely megmondja legfeljebb hány kecskének a súlyát kell összeadni" +
                ", hogy a testsúlyok összege 210 kg vagy a fölötti legyen");
            double Celsuly = 0;
            int Szamlalo = 0;
            while(Celsuly<210)
            {
                Celsuly += TestsulyTMB[Szamlalo];
                Szamlalo++;
            }
            Console.WriteLine($"Ennyi kecske kell a célig: {Szamlalo} ennyi súllya teljesült: {Celsuly:0.00}");
        }

        private static void Feladat8()
        {
            Console.WriteLine("Feladat 8: Rendezzük súly szerint");
            double CsereSuly;
            int CsereMagassag;
            for (int i = 0; i < MagassagTMB.Length; i++)
            {
                for (int j = 0; j < MagassagTMB.Length-1; j++)
                {
                    if(TestsulyTMB[j]<TestsulyTMB[j+1])
                    {
                        CsereSuly = TestsulyTMB[j];
                        CsereMagassag = MagassagTMB[j];
                        TestsulyTMB[j]=TestsulyTMB[j+1];
                        MagassagTMB[j]=MagassagTMB[j+1];
                        TestsulyTMB[j + 1] = CsereSuly;
                        MagassagTMB[j + 1] = CsereMagassag;
                    }
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{i + 1:00}. kecske -> Súly: {TestsulyTMB[i]:0.00} kg" +
                    $" Magassag: {MagassagTMB[i]} cm");
            }

        }

        private static void Feladat7()
        {
            Console.WriteLine("Feladat 7: Keresés");
            Console.Write("Kérem adjon meg egy keresett testsúlyt 30 és 42,5 kg között: ");
            double KeresSuly=double.Parse(Console.ReadLine()!);
            int Szamlalo = 0;
            while(Szamlalo<TestsulyTMB.Length && KeresSuly!=TestsulyTMB[Szamlalo])
            { Szamlalo++; }
            if(Szamlalo==TestsulyTMB.Length)
            { Console.WriteLine("Nem volt olyan kecske akinek a súlya megegyezik"); }
            else
            { Console.WriteLine($"Volt olyan kecske akinek a súlya megegyezik " +
                $", mégpedig a {Szamlalo+1}"); }

        }

        private static void Feladat6()
        {
            Console.WriteLine("Feladat 6: legalacsonyabb kecske");
            int MinMag = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i < 13; i++)
            {
                if(MagassagTMB[i]<MinMag)
                { 
                    MinMag = MagassagTMB[i];
                    MinHely = i+1;
                }
            }
            Console.WriteLine($"A legalacsonyabb kecske : {MinMag} cm");
            Console.WriteLine($"\nA kecske sorszáma: {MinHely}");
        }

        private static void Feladat5()
        {
            Console.WriteLine("Feladat 5: legnehezebb kecske");
            double MaxSuly = TestsulyTMB.Max();
            int MaxHely = 0;
            for (int i = 0; i < 13; i++)
            { if(MaxSuly==TestsulyTMB[i])
                {
                    MaxHely = i+1;
                }
            }
            Console.WriteLine($"\nA legnehezebb kecske súlya: {MaxSuly}kg");
            Console.WriteLine($"\nA kecske sorszáma: {MaxHely}");


        }

        private static void Feladat4()
        {
            Console.WriteLine("Feladat 4: 36 kg feletti");
            int db36 = 0;
            for (int i = 0; i < 13; i++)
            {
                if(TestsulyTMB[i]>36)
                { db36++; }
            }
            Console.WriteLine($"Ennyi kecske súlya több mint 36 kg: {db36}");
        }

        private static void Feladat3()
        {
            Console.WriteLine("Feladat 3: Átlagok különbsége");
            int OsszMagassag = MagassagTMB.Sum();
            double AtlagMagassag=(double)OsszMagassag/TestsulyTMB.Length;
            Console.WriteLine($"A magasság átlag: {AtlagMagassag:0.00}");
            double OsszSuly = 0;
            for (int i = 0; i < 13; i++)
            {
                OsszSuly+=TestsulyTMB[i];
            }
            double AtlagSuly=OsszSuly/TestsulyTMB.Length;
            Console.WriteLine($"A súly átlag: {AtlagSuly:0.00}");
            double Kulonbseg = AtlagMagassag - AtlagSuly;
            Console.WriteLine($"A magasság és súly átlagának különbsége:" +
                $" {Kulonbseg:0.00} ");
        }

        private static void Feladat2()
        {
            Console.WriteLine("Feladat 2: Kiiratás");
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{i+1:00}. kecske -> Súly: {TestsulyTMB[i]:0.00} kg" +
                    $" Magassag: {MagassagTMB[i]} cm");
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("Feladat 1: tömbök feltöltése");
            for (int i = 0; i < 13; i++)
            {
                MagassagTMB[i] = rnd.Next(55,76);
                TestsulyTMB[i] = rnd.Next(300, 426) / 10.0;
            }
        }
    }
}
