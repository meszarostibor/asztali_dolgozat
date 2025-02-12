namespace celloveszetCLI
{
    public class Program
    {

        public static List<Cellovo> cellovok = new List<Cellovo>();


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream) {
                cellovok.Add(new Cellovo(sr.ReadLine()));                    
            }
            sr.Close();

            foreach (var item in cellovok) { 
                Console.WriteLine( $"{item.nev} {item.legnagyobb()}");
            }

            int index = 0;
            for (int i = 0; i < cellovok.Count; i++) {
                if (cellovok[i].legnagyobb() > cellovok[0].legnagyobb()) {
                    index = i;
                }              
            }

            Console.WriteLine("A legnagyobb találatot elérő lövő eredménye:");
            Console.WriteLine(cellovok[index].ToString());

            index = 0;
            for (int i = 0; i < cellovok.Count; i++)
            {
                if (cellovok[i].atlag() < cellovok[index].atlag())
                {
                    index = i;
                }
            }

            Console.WriteLine("A leggyengébb átlagu találatot lövő eredménye:");
            Console.WriteLine($"{cellovok[index].nev} {cellovok[index].atlag()}" );

            Console.ReadKey();
        }
    }
}
