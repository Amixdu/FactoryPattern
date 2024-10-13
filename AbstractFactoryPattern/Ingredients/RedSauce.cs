using System;

namespace AbstractFactoryPattern.Ingredients;

public class RedSauce(string name) : ISauce
{
    public string Name { get; set; } = name;
}
