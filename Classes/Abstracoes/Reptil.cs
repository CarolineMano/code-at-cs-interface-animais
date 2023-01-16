using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public abstract class Reptil : Animal
    {
        protected Reptil(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }

        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
    }
}