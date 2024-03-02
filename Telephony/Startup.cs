namespace Telephony;

public class Startup
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] websites = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Smartphone smartphone = new Smartphone();
        StationaryPhone phone = new StationaryPhone();

        for (int i = 0; i < phoneNumbers.Length; i++)
        {
            string phoneNumber = phoneNumbers[i];
            if (phoneNumber.All(char.IsDigit))
            {
                if (phoneNumber.Length == 7)
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                else
                {
                    Console.WriteLine(smartphone.Call(phoneNumber));
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
                continue;
            }
        }

        for (int i = 0; i < websites.Length; i++)
        {
            string website = websites[i];
            if (website.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
                continue;
            }
            else
            {
                Console.WriteLine(smartphone.Browse(website));
            }
        }
    }
}
