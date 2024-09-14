using System;

// Superclasse
public class Animal
{
    // Encapsulamento
    private string name;
    private int age;

    // Propriedades públicas para acesso controlado
    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Characteristics { get; set; }

    // Constructor  
    public Animal(string name, int age, string characteristics)
    {
        this.name = name;
        this.age = age;
        this.Characteristics = characteristics;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {name} e eu tenho {age} anos de idade, prazer!");
    }

    // virual para permitir o polimorfismo, podendo ser sobrescrito nas subclasses
    public virtual void EmitirSom()
    {
        Console.WriteLine($"O {name} está emitindo algum som.");
    }

    // Abstração, foca em que o objeto faz, não como faz. É sobrescrito nas subclasses, fazendo como faz.
    // Por padrão, este método não faz nada, mas deve ser implementado em classes derivadas para fornecer detalhes relevantes.
    public virtual void Caracteristica() { }
}
