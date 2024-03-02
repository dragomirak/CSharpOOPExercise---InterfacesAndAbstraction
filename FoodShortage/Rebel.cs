﻿namespace FoodShortage;

public class Rebel : IBuyer
{
    public Rebel(string name, int age)
    {
        Name = name;
        Age = age;
        Food = 0;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public int Food { get; set; }

    public void BuyFood()
    {
        Food += 5;
    }
}
