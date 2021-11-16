﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_E_Interface.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
