using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12 {
    class Fisica : Pessoa {
        public Fisica() {
        }

        public string CPF {
            get; set;
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }
        public List<Fisica> ToList() {
            throw new NotImplementedException();
        }
    }
}

