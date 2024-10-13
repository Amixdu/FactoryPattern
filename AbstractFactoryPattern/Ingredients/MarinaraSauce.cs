using System;

namespace AbstractFactoryPattern.Ingredients;

public class MarinaraSauce(string name) : ISauce
{
    public string Name { get; set; } = name;
}
