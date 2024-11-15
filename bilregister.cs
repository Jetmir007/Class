namespace Class
{
    class Bilregister
    {
        private List<Fordon> bilregister = new List<Fordon>();

        public void NyBil(){
            Console.WriteLine("Skriv tillverkaren");
            string nyTillverkare = Console.ReadLine();
            Console.WriteLine("Skriv årsmodellen");
            int nyÅr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv modellen");
            string nyModell = Console.ReadLine();
            Console.WriteLine("Skriv vikten");
            int nyVikt = Convert.ToInt32(Console.ReadLine());
            Fordon nyBil = new Fordon(nyTillverkare, nyÅr, nyModell, nyVikt);
            bilregister.Add(nyBil);
        }

        public void SkrivUt(){
            foreach(Fordon element in bilregister){
                Console.WriteLine("Tillverkaren är :"+ element.Tillverkare);
                Console.WriteLine("Årsmodellen är:" + element.År);
                Console.WriteLine("Modellen är: " + element.Modell);
                Console.WriteLine("Vikten är: " + element.Vikt);
                Console.WriteLine();
            }
            
        }
    }
}