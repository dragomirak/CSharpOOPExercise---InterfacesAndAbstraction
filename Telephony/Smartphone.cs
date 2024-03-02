namespace Telephony;

public class Smartphone : ICallable, IBrowseable
{
    public string Browse(string website)
    {
        return $"Browsing: {website}!";
    }

    public string Call(string number)
    {
        return $"Calling... {number}";
    }
}
