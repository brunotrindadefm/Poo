using System;

// Herança: classe BeijaFlor herda da classe Animal
public class BeijaFlor : Animal {
    // Constructor 
    public BeijaFlor(string name, int age, string characteristics) : base( name, age, characteristics) { }

    // Polimorfismo, método sendo subescrito na subclasse
    public override void EmitirSom() {
        Console.WriteLine($"{Name} está cantando, enquanto poliniza plantas");
    }

    public override void Caracteristica() {
        Console.WriteLine($"{Name} é muito {Characteristics}");
    }
}