using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class KutyaFajta
    {
        private int id;
        private string nev;
        private string eredetiNev;

        public int ID { get { return id; } }
        public string Nev { get { return nev; } }
        public string EredetiNev { get { return eredetiNev; } }

        public KutyaFajta(int id, string nev, string eredetnev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetnev;

        }
    }
}
