using System;
using System.Collections.Generic;
using System.Linq;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao EleitorAll!");
            InformacaoPessoa p = new InformacaoPessoa();
            p.setNome("Anakin Skywalker");
            Console.WriteLine("Digite seu numero de inscricao:");
            p.setInscricao(Console.ReadLine());
            Console.WriteLine("Digite sua idade:");
            p.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nome: {p.getNome()}");
            Console.WriteLine($"N° de inscricao: {p.getInscricao()}");
            Console.WriteLine($"Idade: {p.Idade} anos");

            Registro r1 = new Registro();
            r1.identificador = 1;
            r1.cidadaoRegistrado = p;
            Console.WriteLine(r1.cidadaoRegistrado.getNome());
        }
    }
}
