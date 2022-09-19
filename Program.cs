using Module2HM3;

public class Program
{
    public string Name { get; set; }
    public static void Main(string[] args)
    {
        Cat_family cat = new House_cat(name: "Tosha") ;
        string name = cat.Name;
        string breed = cat.Breed;
        string colour = cat.Colour;
        string typeoffur = cat.TypeOfFur;
        cat.Breed = "Scotish fold";
        cat.Colour = "Grey";
        cat.TypeOfFur = "Extremely soft";
        cat.Run();
        cat.Sleep();
        cat.Eat();
        cat.Purr();

    }

    public string Name1 { get; set; }
    public static void Main1(string[] args)
    {
        Creature dog = new Doggy(name1: "Bieber");
        string name1 = dog.Name1;
        dog.Run();
        dog.Sleep();
        dog.Eat();
        dog.Purr();
    }
}