using System;

// Herança: classe Gato herda da classe Animal
public class Gato : Animal
{
    // Constructor 
    public Gato(string name, int age, string characteristics) : base(name, age, characteristics) { }

    // Polimorfismo, método sendo subescrito na subclasse
    public override void EmitirSom()
    {
        Console.WriteLine($"{Name} está miando!");
    }

    public override void Caracteristica()
    {
        Console.WriteLine($"{Name} é bem {Characteristics}");
    }

}