namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1- Skapa ett objekt av BoxCollection och lägga till 5 objekt i Colliction

            BoxCollection boxcoll = new BoxCollection();

            boxcoll.Add(new Box(10, 10, 10));
            boxcoll.Add(new Box(20, 20, 20));
            boxcoll.Add(new Box(30, 30, 30));
            boxcoll.Add(new Box(40, 40, 40));
            boxcoll.Add(new Box(50, 50, 50));


            // 2- Lägga till ett objekt med samma höjd, längd, bredd (exempel : 10,10,10)
            // för att testa om vi kan lägga till två lådar med samma dimension

            Console.WriteLine("SameValueBox\n");

            boxcoll.Add(new Box(10, 10, 10));

            Console.WriteLine("----------------------------------------------------------------------");

            // 3- Testa Remove metod och sen visa listan efter du tagit bort ett objekt

            Console.WriteLine("\n\nRemoveMethod and DisplayList\n");

            boxcoll.Remove(new Box(10 , 10, 10));

            Box.DisplayData(boxcoll);

            Console.WriteLine("----------------------------------------------------------------------");


            // 4- Kolla om vår Collection contains en specifikt objekt

            Console.WriteLine("\n\nContainsMethod\n");

            Box boxCheck = new Box(20, 20, 20);
            Console.WriteLine("Contains: Height {0}, Length {1}, Width {2} : {3}"
                , boxCheck.height.ToString(), boxCheck.length.ToString(), boxCheck.width.ToString(),
                boxcoll.Contains(boxCheck).ToString());

            Console.WriteLine("----------------------------------------------------------------------");


            Console.WriteLine("\n\nDisplaydata\n");

            Console.WriteLine("----------------------------------------------------------------------");


            // 5- Dispaly metod ska loopa genom alla objekt som finns i Collection och skriva ut dem

            Box.DisplayData(boxcoll);

            Console.ReadKey();

            
        }
    }
}