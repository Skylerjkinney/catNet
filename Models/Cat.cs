namespace catNet.Models;

public class Cat{

    public string Id {get; set;} = Guid.NewGuid().ToString();

    public string Name {get; set;}

    public string Breed {get; set;}

    public string Color {get; set;}

    public bool IsFuzzy {get; set;}

    public double MeowsPerMinute {get; set;}

    public Cat( string name, string breed, string color, bool isFuzzy, double meowsPerMinute){
        Name = name;
        Breed = breed;
        Color = color;
        IsFuzzy = isFuzzy;
        MeowsPerMinute = meowsPerMinute;
    }
}