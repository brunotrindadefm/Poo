using System;

class Program
{
    public static void Main(string[] args)
    {
        // Criação de instâncias das subclasses com atributos específicos
        Cachorro cachorro = new Cachorro("Rex", 5, "saudável");
        Gato gato = new Gato("Lua", 3, "dócil");
        Gato gato2 = new Gato("Meiry", 2, "charmoso");
        Cabra cabra = new Cabra("George", 10, "feliz");
        BeijaFlor beijaFlor = new BeijaFlor("João", 2, "encantador");

        cachorro.Apresentar();
        cachorro.EmitirSom();
        cachorro.Caracteristica();

        Console.WriteLine();

        gato.Apresentar();
        gato.EmitirSom();
        gato.Caracteristica();

        Console.WriteLine();

        gato2.Apresentar();
        gato2.EmitirSom();
        gato2.Caracteristica();

        Console.WriteLine();

        cabra.Apresentar();
        cabra.EmitirSom();
        cabra.Caracteristica();
        cabra.SabeMuito();

        Console.WriteLine();

        beijaFlor.Apresentar();
        beijaFlor.EmitirSom();
        beijaFlor.Caracteristica();
    }
}