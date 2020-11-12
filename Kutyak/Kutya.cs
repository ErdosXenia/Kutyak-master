using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Kutya
    {
        private int id;
        private int fajta_id;
        private int nev_id;
        private int eletkor;
        private string vizsgalat;

        public string Vizsgalat { get { return vizsgalat; } }

        public int ID { get { return id; } }
        public int Fajtaid { get { return fajta_id; } }

        public int Nevid { get { return nev_id; } }

        public int Eletkor { get { return eletkor; } }

        public Kutya(int i, int f,int n, int e, string v)
        {
            id = i;
            fajta_id = f;
            nev_id = n;
            eletkor = e;
            vizsgalat = v;
        }
    }
}
