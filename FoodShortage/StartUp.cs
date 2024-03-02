namespace FoodShortage;

public class StartUp
{
    static void Main()
    {
        
        IBuyer buyer;
        List<IBuyer> buyers = new List<IBuyer>();

        int peopleCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < peopleCount; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 4)
            {
                buyer = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                buyers.Add(buyer);
            }
            else if (tokens.Length == 3)
            {
                buyer = new Rebel(tokens[0], int.Parse(tokens[1]));
                buyers.Add(buyer);
            }
        }

        string name;
        while ((name = Console.ReadLine()) != "End")
        {
            IBuyer buyerToFind = buyers.FirstOrDefault(b => b.Name == name);
            if (buyerToFind != null)
            {
                buyerToFind.BuyFood();
                
            }
        }

        Console.WriteLine(buyers.Sum(b => b.Food));
    }
}
