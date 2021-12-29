using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] idades = new int[5];

            ////idades[0] = 15;
            ////idades[1] = 28;
            ////idades[2] = 35;
            ////idades[3] = 50;
            ////idades[4] = 28;

            //int[] idades = new int[] { 15, 28, 35, 50, 28 };

            //for (int indice = 0; indice < idades.Length; indice++)
            //{
            //    int idade = idades[indice];
            //    Console.WriteLine($"Valor no índice {indice}: {idade}");
            //}

            //int acumulador = 0;
            //for(int indice = 0; indice < idades.Length; indice++)
            //{
            //    acumulador += idades[indice];
            //}
            //int media = acumulador / idades.Length;
            //Console.WriteLine(media);

            //-----------------------------------------------------------------------------

            //ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));

            //-----------------------------------------------------------------------------

            //ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            //lista.Adicionar(new ContaCorrente(100, 40010));
            //lista.Adicionar(new ContaCorrente(101, 40011));
            //lista.Adicionar(new ContaCorrente(102, 40012));
            //lista.Adicionar(new ContaCorrente(103, 40013));

            //-----------------------------------------------------------------------------

            //ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            //ContaCorrente[] contas = new ContaCorrente[]
            //{
            //    new ContaCorrente(100, 40010),
            //    new ContaCorrente(101, 40011),
            //    new ContaCorrente(102, 40012),
            //    new ContaCorrente(103, 40013)
            //};
            //lista.AdicionarVarios(contas);

            //-----------------------------------------------------------------------------

            //ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            //lista.AdicionarVarios(
            //    new ContaCorrente(100, 40010),
            //    new ContaCorrente(101, 40011)
            //);

            //for (int i = 0; i < lista.Tamanho; i++)
            //{
            //    ContaCorrente conta = lista[i];
            //    Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            //}

            //-----------------------------------------------------------------------------

            //MinhaClasse<int>.ContadorEstatico++;
            //MinhaClasse<int>.ContadorEstatico++;
            //MinhaClasse<int>.ContadorEstatico++;

            //Console.WriteLine(MinhaClasse<int>.ContadorEstatico);
            //Console.WriteLine(MinhaClasse<string>.ContadorEstatico);

            //-----------------------------------------------------------------------------

            //ListaDeObject listaDeIdades = new ListaDeObject();

            //listaDeIdades.AdicionarVarios(12, 42, 15, "ops, não deveria estar aqui");

            //for (int i = 0; i < listaDeIdades.Tamanho; i++)
            //{
            //    int idade = (int)listaDeIdades[i];
            //    Console.WriteLine(idade);
            //}

            //-----------------------------------------------------------------------------

            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int itemAtual = idades[i];
                Console.WriteLine($"Valor no índice {i}: {itemAtual}");
            }

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(
                new ContaCorrente(124, 54354),
                new ContaCorrente(201, 44354)
            );

            Console.ReadLine();
        }
    }
}
