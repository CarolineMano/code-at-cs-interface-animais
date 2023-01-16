using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Morcego : Mamifero, IVoar
    {
        public Morcego(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, int altitudeMaximaEmMetros = 10, double velocidadeDoVoo = 160, int qtdeMamas = 4, bool pelos = true, string corPelo = "Preto") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
        {
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
            VelocidadeDoVoo = velocidadeDoVoo;
        }

        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDoVoo { get; init; }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de ruídos de alta frequência");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu uso ondas ultrassônicas para me orientar enquanto eu vôo.");
        }
    }
}