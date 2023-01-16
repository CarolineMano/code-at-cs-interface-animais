using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Elefante : Mamifero
    {
        public Elefante(string nome, DateTime dataNascimento, char sexo, bool carnivoro = false, bool peconhento = false, int qtdeMamas = 6, bool pelos = true, string corPelo = "Cinza") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
        {
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu sou altamente sociável e utilizo todos os meus sentidos para me comunicar. Também sou excelente em detectar vibrações.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando, mas também sou um excelente nadador. ");
        }
    }
}