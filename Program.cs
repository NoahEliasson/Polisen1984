
namespace Polisen1984;

class Program
{
    static void Main(string[] args)
    {
        List<string> Brott = new List<string>();
        System.Console.WriteLine("1. REGESTRERING AV UTRYCKNINGAR");

        switch(Console.ReadLine())
        {

            case "1":
            System.Console.WriteLine("Vad är det för brott?");
            string brottlista = Console.ReadLine().ToLower();
            Brott.Add(brottlista);
            System.Console.WriteLine("Vilken plats?");
            string platslista = Console.ReadLine().ToLower();
            Brott.Add(platslista);
            System.Console.WriteLine("Vilken tidpunkt?");
            string tidlista = Console.ReadLine().ToLower();
            Brott.Add(tidlista);
            string datumlista = Console.ReadLine().ToLower();
            System.Console.WriteLine("vilket datum?");
            Brott.Add(datumlista);
            foreach(string item in Brott)
            System.Console.WriteLine(item);
            break;
        }
   

            
        
    }
    
}
class Systemkrav
{

    static void Utryckningar()
    {
        
    }






}

