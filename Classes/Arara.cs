using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Arara : Ave, IVoar, IOviparo
    {
        public Arara(string nome, DateTime dataNascimento, char sexo, int altitudeMaximaEmMetros = 2000, double velocidadeDoVoo = 45, bool carnivoro = false, bool peconhento = false, bool rapina = false, string corPena = "Vermelha") : base(nome, dataNascimento, sexo, carnivoro, peconhento, rapina, corPena)
        {
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
            VelocidadeDoVoo = velocidadeDoVoo;
        }

        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDoVoo { get; init; }

        public void Botar()
        {
            Console.WriteLine("Eu posso botar 2 ou mais ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu choco meus ovos por volta de 25 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de grasnidos e gritos.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando e voo.");
        }
    }
}