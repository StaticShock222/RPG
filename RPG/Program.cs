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
        var monstro = new Monstro();
        {
            monstro.NomeMonstro = "Balrog";
            monstro.PontosDeAtaque = 100;
            monstro.PontosDeVida = 200;
            monstro.RecompensaXP = 500;
            monstro.EstaVivo = true;
        }
        ;
        Console.WriteLine("Digite as informações do inimigo:");
        var monstro2 = new Monstro();
        Console.Write("Nome do monstro: ");
        monstro2.NomeMonstro = Console.ReadLine();
        Console.Write("Pontos de vida: ");
        monstro2.PontosDeVida = int.Parse(Console.ReadLine());
        monstro2.EstaVivo = monstro2.PontosDeVida > 0;
        Console.Write("Pontos de ataque: ");
        monstro2.PontosDeAtaque = int.Parse(Console.ReadLine());
        Console.Write("Recompensa em XP: ");
        monstro2.RecompensaXP = int.Parse(Console.ReadLine());
        Console.WriteLine($"Está vivo: {monstro2.EstaVivo}");
        Console.WriteLine($"Personagem: {personagem.Nome}, Classe: {personagem.Classe}, Nível: {personagem.Nivel}");
        Console.WriteLine($"Item: {item.Nome}, Tipo: {item.Tipo}, Raridade: {item.Raridade}");
        Console.WriteLine($"Monstro: {monstro.NomeMonstro}, Vida: {monstro.PontosDeVida}, Ataque: {monstro.PontosDeAtaque}, XP: {monstro.RecompensaXP}");
        Console.WriteLine($"Monstro 2: {monstro2.NomeMonstro}, Vida: {monstro2.PontosDeVida}, Ataque: {monstro2.PontosDeAtaque}, XP: {monstro2.RecompensaXP}");
    }
}