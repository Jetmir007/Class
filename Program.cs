using Class;

static void Main(){
    Fordon f1 = new Fordon();
    Fordon f2 = new Fordon();
    Console.WriteLine("Skriv modellen");
    string a = Console.ReadLine();
    f1.setModell(a);
    Console.WriteLine("Skriv tillverkaren");
    string b = Console.ReadLine();
    f1.setTillverkare(b);
    Console.WriteLine("Skriv årsmodell");
    int c = int.Parse(Console.ReadLine());
    f1.setÅr(c);
    Console.WriteLine("Skriv vikten");
    int d = int.Parse(Console.ReadLine());
    f1.setVikt(d);
    Console.WriteLine(f1.getModell() +)

    Console.WriteLine("Skriv modellen av andra bilen");
    string e = Console.ReadLine();
    f2.setModell(e);
    Console.WriteLine("Skriv tillverkaren av andra bilen");
    string f = Console.ReadLine();
    f2.setTillverkare(f);
    Console.WriteLine("Skriv årsmodellen av andra bilen");
    int g = int.Parse(Console.ReadLine());
    f2.setÅr(g);
    Console.WriteLine("Skriv vikten av andra bilen");
    int h = int.Parse(Console.ReadLine());
    f2.setVikt(h);
}
Main();
