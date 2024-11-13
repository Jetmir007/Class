using Class;

static void Main(){
    Fordon f = new Fordon("VW", 2019, "Golf", 750);
    Console.WriteLine(f.Tillverkare);
    Console.WriteLine(f.År);
    Console.WriteLine(f.Modell);
    Console.WriteLine(f.Vikt);
}
Main();
