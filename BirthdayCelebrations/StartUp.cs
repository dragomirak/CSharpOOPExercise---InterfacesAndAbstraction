namespace BirthdayCelebrations;

public class StartUp
{
    static void Main()
    {
        IBirthable birthable;
        List<IBirthable> list = new List<IBirthable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = tokens[0];
            if (tokens[0] == "Citizen")
            {
                birthable = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                list.Add(birthable);
            }
            else if (tokens[0] == "Pet")
            {
                birthable = new Pet(tokens[1], tokens[2]);
                list.Add(birthable);
            }
            else
            {
                continue;
            }
        }

        string birthYear = Console.ReadLine();
        foreach (IBirthable item in list)
        {
            if (item.Birthdate.EndsWith(birthYear))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}

