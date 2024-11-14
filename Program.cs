using Class;

static void Main(){
    int val = 1;
    Fordon f = new Fordon();
    while (val != 0){
        Console.WriteLine("Välj ett alternativ:");
        Console.WriteLine("1. Skapa ny bil");
        Console.WriteLine("2. Visa bilar");
        Console.WriteLine("3. Avsluta");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 1){
            f.NyBil();
        }
        else if(val == 2){
            f.SkrivUt();
        }
        else if(val == 3){
            break;
        }
}
}
  