namespace Class
{
    public class Fordon
    {
        private string tillverkare;
        private int år;
        private string modell;
        private int vikt;

        public void setTillverkare(string T){
            tillverkare = T;
        }  
        public string getTillverkare() {
            return tillverkare;
        }
        public void setÅr(int å){
            år =å;
        } 
        public int getÅr() {
            return år;
        }
        public void setModell(string m) {
            modell = m;
        }
        public string getModell(){
            return modell;
        }
        public void setVikt(int v) {
            vikt = v;
        }
        public int getVikt() {
            return vikt;
        }
    }
}