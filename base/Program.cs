using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            teste();
        }
        static void teste()
        {
            var cliente = new cliente();
            cliente.codigo = 10;
            cliente.nome = "teste";

            var email = new email();
            email.emailprincipal = "teste@aaa.com";



            var telefone = new telefone();
            telefone.celular = "11 4444 4224 0044";



            var endereco = new endereco();
            endereco.logradouro = "rua teste222";
            endereco.numero = "c44";
            endereco.bairro = "vila lobos";
            endereco.cidade = "desteny";
            endereco.estado = "sao paulo";
            endereco.cep = "2434324-424322";

            cliente.endereco = endereco;
            cliente.telefone = telefone;
            cliente.email = email;

            Console.ReadKey();
        }
    }
}


