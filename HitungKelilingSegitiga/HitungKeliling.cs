using System;

namespace NUnitTest
{
    public class HitungKeliling
    {
        public int HKSegitiga(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            // Create an instance of the HitungKeliling class
            HitungKeliling hitungKeliling = new HitungKeliling();

            // Call the HKSegitiga method with sample values
            int hasilKeliling = hitungKeliling.HKSegitiga(3, 4, 5);

            // Display the result
            Console.WriteLine("Hasil Keliling Segitiga: " + hasilKeliling);
        }
    }
}