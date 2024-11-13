namespace Class
{
    public class Fordon
    {
        private string tillverkare;

        public string Tillverkare{
            get{ return tillverkare;}
            set{ tillverkare = value;}
        }
        private int år;

        public int År{
            get{ return år;}
            set{år = value;}
        }
        private string modell;

        public string Modell{
            get{return modell;}
            set{modell = value;}
        }
        private int vikt;

        public int Vikt{
            get{return vikt;}
            set{vikt = value;}
        }

        public Fordon(string t, int å, string m, int v){
            tillverkare = t;
            år = å;
            modell = m;
            vikt = v;
        }
    }
}