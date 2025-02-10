using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Proje_Pratikleri_01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region

            double exam1, exam2, exam3, average;

            Console.WriteLine("Vize Sınav: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Sınav: ");
            exam2 = double.Parse(Console.ReadLine());

            if (exam2 >= 45)
            {
                average = (exam1 * 0.4) + (exam2 * 0.6);
                Console.WriteLine("Öğrencinin not değeri: " + average);

                if (average <= 100 && average >= 90)
                {
                    Console.WriteLine("Notunuzun harf değeri: AA");
                }
                else if (average <= 89 && average >= 85)
                {
                    Console.WriteLine("Notunuzun harf değeri: BA");
                }
                else if (average <= 84 && average >= 80)
                {
                    Console.WriteLine("Notunuzun harf değeri: BB");
                }
                else if (average <= 79 && average >= 70)
                {
                    Console.WriteLine("Notunuzun harf değeri: CB");
                }
                else if (average <= 69 && average >= 60)
                {
                    Console.WriteLine("Notunuzun harf değeri: CC");
                }
                else if (average <= 59 && average >= 55)
                {
                    Console.WriteLine("Notunuzun harf değeri: DC");
                }
                else if (average <= 54 && average >= 50)
                {
                    Console.WriteLine("Notunuzun harf değeri: DD");
                }
                else if (average < 50)
                {
                    Console.WriteLine("Notunuzun harf değeri: FF");
                }
            }
            else
            {
                Console.WriteLine("Bütünleme Sınav: ");
                exam3 = double.Parse(Console.ReadLine());

                average = (exam1 * 0.4) + (exam3 * 0.6);
                Console.WriteLine("Öğrencinin not değeri: " + average);

                if (average <= 100 && average >= 90)
                {
                    Console.WriteLine("Notunuzun harf değeri: AA");
                }
                else if (average <= 89 && average >= 85)
                {
                    Console.WriteLine("Notunuzun harf değeri: BA");
                }
                else if (average <= 84 && average >= 80)
                {
                    Console.WriteLine("Notunuzun harf değeri: BB");
                }
                else if (average <= 79 && average >= 70)
                {
                    Console.WriteLine("Notunuzun harf değeri: CB");
                }
                else if (average <= 69 && average >= 60)
                {
                    Console.WriteLine("Notunuzun harf değeri: CC");
                }
                else if (average <= 59 && average >= 55)
                {
                    Console.WriteLine("Notunuzun harf değeri: DC");
                }
                else if (average <= 54 && average >= 50)
                {
                    Console.WriteLine("Notunuzun harf değeri: DD");
                }
                else if (average < 50)
                {
                    Console.WriteLine("Notunuzun harf değeri: FF");
                }
            }

            Console.ReadLine();
            #endregion
        }
    }
}




    


