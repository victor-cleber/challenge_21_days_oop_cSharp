using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12 {
    class Program {
        static void Main(string[] args) {
        //Console.WriteLine("Hello World!");
        new Fisica() { Nome = "Victor", Endereco = "Rua A", Id = 1 }().Salvar();
        new Juridica() { Nome = "Cleber", Endereco = "Rua B", Id = 1 }().Salvar();

        var listaFisica = Service.Buscar(new Fisica());
        var listaJuridica = Service.Buscar(new Juridica());

        //casting
        foreach(IPessoa pessoa in listaFisica){
            Console.WriteLine((Fisica) IPessoa.CPF);
            Console.WriteLine((Fisica) IPessoa.Nome);
        }

        foreach (Juridica juridica in listaJuridica) {
            Console.WriteLine(juridica.CNPJ);
            Console.WriteLine(juridica.Nome);
        }

        //usando T - define tipo de retorno na chamada
        //var fisica = Service.Procurar<Fisica>();
        var fisicas = Service.Procurar<Pessoa>().ToList();
        var juridicas = Service.Procurar<Juridica>().ToList();

        Console.ReadLine();
        }
    }
}