namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];

            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students2 = new string[3] { "Egin1", "Salih1", "Derin1" };

            //string[] students3 = { "Egin2", "Salih2", "Derin2" };

            //foreach (var student3 in students3)
            //{
            //    Console.WriteLine(student3);
            //}

            string[,] regions = new string[5, 3]
            {

                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"İzmir","Aydın","Muğla" },
                {"Trabzon","Rize","Samsun" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}