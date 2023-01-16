using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Leao : Mamifero
    {
        public Leao(string nome, DateTime dataNascimento, char sexo, bool carnivoro = true, bool peconhento = false, int qtdeMamas = 8, bool pelos = true, string corPelo = "Amarelo ocre") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
        {
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de rugidos");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu me movimento sob as quatro patas");
        }
    }
}