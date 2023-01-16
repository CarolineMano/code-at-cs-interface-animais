using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public interface IAquatico
    {
        public bool ViveEmTerra { get; init; }
        public bool Mergulho { get; init; }
        public bool AguaDoce { get; init; }
    }
}