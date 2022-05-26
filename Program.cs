using System;
using ProjetoDioGame.src.Modes;

class Program
{
    static void Main(string[] args)
    {
        Knight Prank = new Knight("Arus", 1, "Knight", 25, 100);
        Wizard Bandin = new Wizard("Jennica", 1, "White Wizard");
        Assassin Painkiller = new Assassin("Morpheus", "Ninja", 1, 25, 90);
        Wizard Hellfire = new Wizard("Kratos", 1, "Black Wizard!");


        Console.WriteLine();
        Console.WriteLine(Prank);
        Console.WriteLine("Vamos derrotar nosso inimigo! Irei utilizar minha espada!");
        Console.WriteLine();
        Console.WriteLine(Bandin);
        Console.WriteLine("Vou usar minhas melhores técnicas e magias para poder derrota-lo, sou uma bruxa muito poderosa");
        Console.WriteLine();
        Console.WriteLine(Painkiller);
        Console.WriteLine(@"Sou como o silêncio de uma floresta virgem! Atacarei sem piedade e sem que o inimigo perceba!");
        Console.WriteLine();
        Console.WriteLine(Hellfire);
        Console.WriteLine(@"Venho das profundezas mais obscuras para ajudar-los, sou o maior e melhor Magico Negro!");
        Console.WriteLine();
        Console.WriteLine(Prank.Attack());
        Console.WriteLine();
        Console.WriteLine(Bandin.Attack(10));
        Console.WriteLine();
        Console.WriteLine(Painkiller.Attack());
        Console.WriteLine();
        Console.WriteLine(Hellfire.Attack());
        Console.WriteLine();
        Console.WriteLine(@"Após uma batalha dura e sangrenta o inimigo é derrotado por nossos melhores heróis!");

    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}

