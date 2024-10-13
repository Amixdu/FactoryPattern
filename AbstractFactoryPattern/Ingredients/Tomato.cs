using System;

namespace AbstractFactoryPattern.Ingredients;

public class Tomato(string name) : IVeggie
{
    public string Name { get; set; } = name;
}
