using System;

// Herança: classe Cabra herda da classe Animal
public class Cabra : Animal 
{
    private string Goat = "Messi";

 // Constructor 
    public Cabra(string name, int age, string characteristics) : base(name, age, characteristics) { }

    // Polimorfismo, método sendo subescrito na subclasse
    public override void EmitirSom() {
        Console.WriteLine($"{Name} está fazendo béééééé");
    }

    public override void Caracteristica() {
        Console.WriteLine($"{Name} é muito {Characteristics}");
    }

    public void SabeMuito() {
        Console.WriteLine($"{Name} é uma Cabra, cabra em inglês é goat, goat em futebol é {Goat}");
    }

}