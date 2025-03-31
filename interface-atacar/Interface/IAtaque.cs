using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

interface IAtaque {
    void Atacar();
}

class Guerreiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}

class Mago : IAtaque {
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
}

class Arqueiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
}