using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_E_Interface.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;

            CPF = cpf;
            Salario = salario;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            //if (_tipo == 1)
                //return Salario;

            return Salario * 0.10;
        }
    }
}
