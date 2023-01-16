using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public abstract class Ave : Animal
    {
        protected Ave(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        {
            Rapina = rapina;
            CorPena = corPena;
        }

        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine("Estou ciscando...");
        }
    }
}