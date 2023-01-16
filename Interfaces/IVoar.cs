using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDoVoo { get; init; }

        public void Voar()
        {
            Console.WriteLine($"Eu posso chegar a uma altitude de {AltitudeMaximaEmMetros} metros com velocidade de até {VelocidadeDoVoo} km/h.");
        }
    }
}