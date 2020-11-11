using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak
{

    class Program
    {
        static List<KutyaNev> KutyaNevek = new List<KutyaNev>();
        static List<KutyaFajta> KutyaFajtak = new List<KutyaFajta>();
        static List<Kutya> KutyaLista = new List<Kutya>();

        static void KutyaNevekBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaNevek.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            sr.Close();
        }

        static void feladat3()
        {
            Console.WriteLine($"3. Feladat: Kutyanevek száma: {KutyaNevek.Count()}");
        }

        static void KutyaFajtakBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaFajtak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaFajtak.Add(new KutyaFajta(Convert.ToInt32(adat[0]), adat[1], adat[2]
                ));
            }

            sr.Close();
        }

        static void KutyaBeolvasas()
        {
            StreamReader sr = new StreamReader("Kutyak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaLista.Add(new Kutya(Convert.ToInt32(adat[0]), Convert.ToInt32(adat[1]), 
                    Convert.ToInt32(adat[2]), Convert.ToInt32(adat[3]), adat[4]));
            }

            sr.Close();
        }

        static void feladat6()
        {
            int sum = 0;
            foreach (var k in KutyaLista)
            {
                sum += k.Eletkor;
            }

            Console.WriteLine($"6. Feladat: Kotyák átlag életkora: " +
                $"{(double)sum / KutyaLista.Count:N2}");
        }

        static void feladat7()
        {
            int max = KutyaLista[0].Eletkor;
            for (int i = 0; i < KutyaLista.Count; i++)
            {
                if (max < KutyaLista[i].Eletkor)
                {
                    max = KutyaLista[i].Eletkor;
                }
            }
            
            Console.WriteLine($"7.Feladat: {max}");
        }

        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            feladat3();
            KutyaFajtakBeolvasas();
            KutyaBeolvasas();
            feladat6();
            feladat7();

           
            Console.ReadKey();
        }
    }
}
