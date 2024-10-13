namespace AbstractFactoryPattern.Ingredients;

public class ThinCrustDough(string name) : IDough
{
    public string Name { get; set; } = name;
}
