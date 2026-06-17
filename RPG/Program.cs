using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Heroi;
class Program
{
    static void Main(string[] args)
    {
        var personagem = new Personagem()
        {
            Nome = "Gandalf",
            Classe = "Mago",
            Nivel = 10,
        };
        var item = new Item()
        {
            Nome = "Cajado de madeira",
            Tipo = "Arma",
            Raridade = "Comum",
            BonusAtaque = 50,
            BonusDefesa = 10,
            Preco = 100.0
        };
        var monstro = new Monstro()
        {
            NomeMonstro = "Goblin",
            PontosDeVida = 15,
            PontosDeAtaque = 20,
            RecompensaXP = 50

        };
        Console.WriteLine($"Personagem: {personagem.Nome}, Classe: {personagem.Classe}, Nível: {personagem.Nivel}");
        Console.WriteLine($"Item: {item.Nome}, Tipo: {item.Tipo}, Raridade: {item.Raridade}");
        Console.WriteLine($"Monstro: {monstro.NomeMonstro}, Vida: {monstro.PontosDeVida}, Ataque: {monstro.PontosDeAtaque}, XP: {monstro.RecompensaXP}");
    }
}