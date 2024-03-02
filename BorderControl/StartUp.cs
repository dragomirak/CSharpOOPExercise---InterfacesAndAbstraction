namespace BorderControl;

public class StartUp
{
    static void Main()
    {
        string input;
        IIdentifiable identifiable;
        List<IIdentifiable> list = new List<IIdentifiable>();

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 2)
            {
                identifiable = new Robot(tokens[0], tokens[1]);
                list.Add(identifiable);
            }
            else if (tokens.Length == 3) 
            {
                identifiable = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                list.Add(identifiable);
            }
                
        }

        string stringToCheck = Console.ReadLine();
        foreach (IIdentifiable item in list)
        {
            if (item.Id.EndsWith(stringToCheck))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
