using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12 {
    public abstract class Pessoa: IPessoa {

        public abstract void Excluir();

        public List<IPessoa> Buscar() {
            return null;
        }
    }
}

