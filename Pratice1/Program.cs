// find largest and smallest element in array
namespace Pratice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // find largest and smallest element in array and other properties

            int[] series = { 1, 10, 20, 30, -10, -100, 1000 };
            var result1 = series.Max(); // en büyük değer
            var result2 = series.Min(); // en küçük değer
            var result3 = series.Sum(); // toplam
            var result4 = series.Average(); // ortalama
            var result5 = series.Length;// eleman sayısı / uzunluğu
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            // sum of rows of two dimensional array 3*3

            int[,] table = { {1,2,3 }, {4,5,6 }, {7,8,9 } };
            var result6 = table[0, 0]; // 1. eleman
            var result7 = table[0, 0] + table[0, 1] + table[0, 2];
            Console.WriteLine(result6);
            Console.WriteLine("1 satır toplamı {0}", result7);



            Console.ReadLine();


        }
    }

}