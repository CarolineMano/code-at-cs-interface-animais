using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Coruja : Ave, IOviparo, IVoar
    {
        public Coruja(string nome, DateTime dataNascimento, char sexo, int altitudeMaximaEmMetros = 100, double velocidadeDoVoo = 15, bool carnivoro = true, bool peconhento = false, bool rapina = true, string corPena = "Marrom") : base(nome, dataNascimento, sexo, carnivoro, peconhento, rapina, corPena)
        {
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
            VelocidadeDoVoo = velocidadeDoVoo;
        }

        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDoVoo { get; init; }

        public void Botar()
        {
            Console.WriteLine("Eu posso botar de 2 a 18 ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu choco meus ovos por volta de 33 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico sons e movimentos corporais.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando e voo.");
        }
    }
}