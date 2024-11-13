namespace Class
{
    public class Bilregister
    {
        private List<Fordon> bilregister = new List<Fordon>();

        public void nyBil(){
            Console.WriteLine("Skriv tillverkaren");
            string nyTillverkare = Console.ReadLine();
            Console.WriteLine("Skriv årsmodellen");
            int nyÅr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv modellen");
            string nyModell = Console.ReadLine();
            Console.WriteLine("Skriv vikten");
            int nyVikt = Convert.ToInt32(Console.ReadLine());
            Fordon nyBil = new Fordon(nyTillverkare, nyÅr, nyModell, nyVikt);
        }

        public void skrivUt(){
            foreach(Fordon element in bilregister){
                Console.WriteLine(element.Tillverkare);
                Console.WriteLine(element.År);
                Console.WriteLine(element.Modell);
                Console.WriteLine(element.Vikt);
            }
        }
    }
}