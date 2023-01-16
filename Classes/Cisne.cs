using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Cisne : Ave, IVoar, IOviparo, IAquatico
    {
        public Cisne(string nome, DateTime dataNascimento, char sexo, int altitudeMaximaEmMetros = 2000, double velocidadeDoVoo = 45, bool viveEmTerra = true, bool mergulho = true, bool aguaDoce = true, bool carnivoro = true, bool peconhento = false, bool rapina = false, string corPena = "Branca") : base(nome, dataNascimento, sexo, carnivoro, peconhento, rapina, corPena)
        {
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
            VelocidadeDoVoo = velocidadeDoVoo;
            ViveEmTerra = viveEmTerra;
            Mergulho = mergulho;
            AguaDoce = aguaDoce;
        }

        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDoVoo { get; init; }
        public bool ViveEmTerra { get; init; }
        public bool Mergulho { get; init; }
        public bool AguaDoce { get; init; }

        public void Botar()
        {
            Console.WriteLine("Eu posso botar 6 ou mais ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu choco meus ovos por volta de 35 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de diversos cantos. Possuo 8 vezes mais cordas vocais do que outras espécies de pássaros!");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu nado, ando e voo.");
        }
    }
}