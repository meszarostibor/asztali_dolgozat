using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class Cellovo
    {
        public string nev {  get;private set; }
        public int loves1 { get;private set; }
        public int loves2 { get;private set; }
        public int loves3 { get;private set; }
        public int loves4 { get;private set; }


        public int legnagyobb() {
            int l = 0;
            if (this.loves1 > l) { l = this.loves1; }
            if (this.loves2 > l) { l = this.loves2; }
            if (this.loves3 > l) { l = this.loves3; }
            if (this.loves4 > l) { l = this.loves4; }
            return l;
        }

        public int atlag() {
            int a;
            a = (this.loves1 + this.loves2 + this.loves3 + this.loves4) / 4;
            return a;
        }


        public Cellovo(string sor) {
            string[] x = sor.Split(";");
            this.nev = x[0];    
            this.loves1 = int.Parse(x[1]);
            this.loves2 = int.Parse(x[2]);
            this.loves3 = int.Parse(x[3]);
            this.loves4 = int.Parse(x[4]);         
        }


        public override string ToString() {
            return $"{nev} {loves1} {loves2} {loves3} {loves4}";
        }


    }

    
}
