using System;

namespace AbstractFactoryPattern.Ingredients;

public class Mushroom(string name) : IVeggie
{
    public string Name { get; set; } = name;
}
