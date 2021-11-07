﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_E_Interface.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
