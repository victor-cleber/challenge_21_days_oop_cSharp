using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12 {
    class Service {
        public static List<IPessoa> TabelaFisica;
        public static List<IPessoa> TabelaJuridica;

        public static void Salvar(IPessoa iPessoa) {
            //if (IPessoa.GetType() == typeOf(Fisica))
            if (iPessoa.GetType().Name == "Fisica") {
                Service.TabelaFisica.Add((Fisica)iPessoa);
            }else if (iPessoa.GetType().Name == "Juridica") {
                Service.TabelaJuridica.Add((Juridica)iPessoa);
            }
        }

        public static List<IPessoa> Buscar(IPessoa iPessoa) {
            if (iPessoa.GetType().Name == "Fisica") {
                return Service.TabelaFisica;

            }else if (iPessoa.GetType().Name == "Juridica") {
                return Service.TabelaJuridica;
            }
            return null;
        }

        public static T Procurar<T>() {
            //List<IPessoa> lista = new List<IPessoa>();
            var lista = Service.TabelaFisica;
            return (T)Convert.ChangeType(lista, typeof(T));

            /*
            if (iPessoa.GetType().Name == 'Fisica'){
                return Service.TabelaFisica;

            }else if(iPessoa.GetType().Name == "Juridica"){
                return Service.TabelaJuridica;
            }
            return null;*/
        }

    }
}

