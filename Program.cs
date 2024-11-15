using Class;

static void Main(string[] args){
    int val = 1;
    Bilregister b = new Bilregister();
    while (val != 0){
        Console.WriteLine("Välj ett alternativ:");
        Console.WriteLine("1. Skapa ny bil");
        Console.WriteLine("2. Visa bilar");
        Console.WriteLine("0. Avsluta");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 1){
            b.NyBil();
        }
        else if(val == 2){
            b.SkrivUt();
        }
        else if(val == 0){
            break;
        }
}
}
Main(args);
  