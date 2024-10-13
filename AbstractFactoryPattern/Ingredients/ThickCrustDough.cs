using System;

namespace AbstractFactoryPattern.Ingredients;

public class ThickCrustDough(string name) : IDough
{
    public string Name { get; set; } = name;
}
