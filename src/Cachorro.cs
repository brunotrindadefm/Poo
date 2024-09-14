using System;

// Herança: classe Cachorro herda da classe Animal
public class Cachorro : Animal
{
    // Construtor
    // base é usada na subclasse para invocar o construtor da superclasse
    public Cachorro(string name, int age, string characteristics) : base(name, age, characteristics) { }

    // Polimorfismo, método sendo subescrito na subclasse
    public override void EmitirSom()
    {
        Console.WriteLine($"{Name} está latindo!");
    }

    public override void Caracteristica()
    {
        Console.WriteLine($"{Name} é bem {Characteristics}");
    }
}