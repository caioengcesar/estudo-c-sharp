﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais2.");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
