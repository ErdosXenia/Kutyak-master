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

            int fid = 0;
            int nid = 0;
            int id = 0;

            for (int i = 0; i < KutyaLista.Count; i++)
            {
                if (max < KutyaLista[i].Eletkor)
                {
                    max = KutyaLista[i].Eletkor;

                    fid = KutyaLista[i].Fajtaid - 1;
                    nid = KutyaLista[i].Nevid - 1;
                    id = KutyaLista[i].ID;
                }
            }
            
            Console.WriteLine($"7.Feladat: A legidősebb kutya neve és fajtája: " +
                $"{KutyaNevek[nid].Nev}, {KutyaFajtak[fid].Nev}");
        }

        static void feladat8()
        {
            Dictionary<string,int> hany = new Dictionary<string,int>();

            foreach (var k in KutyaLista)
            {
                if (k.Vizsgalat == "2018.01.10")
                {
                    if (!hany.ContainsKey(KutyaFajtak[k.Fajtaid].Nev))
                    {
                        hany.Add(KutyaFajtak[k.Fajtaid].Nev, 1);
                    }
                    else
                    {
                        hany[KutyaFajtak[k.Fajtaid].Nev]++;
                    }
                    
                }
            }
            Console.WriteLine("8. Feladat: Január 10-én vizsgált kutya fajták:");
            foreach (var h in hany)
            {
                Console.WriteLine($"    {h.Key}: {h.Value}");
            }
            
        }

        static void feladat9()
        {
            Dictionary<string, int> napok = new Dictionary<string, int>();
            foreach (var k in KutyaLista)
            {
                if (!napok.ContainsKey(k.Vizsgalat))
                {
                    napok.Add(k.Vizsgalat, 1);
                }
                else
                {
                    napok[k.Vizsgalat]++;
                }
            }

            int maxKutya = 0;
            string datum = "";

            foreach (var n in napok)
            {
                if (n.Value > maxKutya)
                {
                    maxKutya = n.Value;
                    datum = n.Key;
                }
            }
            Console.WriteLine($"9. feladat: Legjobban leterhelt nap: {datum}. : {maxKutya} kutya");
        }

        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            feladat3();
            KutyaFajtakBeolvasas();
            KutyaBeolvasas();
            feladat6();
            feladat7();
            feladat8();
            feladat9();

           
            Console.ReadKey();
        }
    }
}
