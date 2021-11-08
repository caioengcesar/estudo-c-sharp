using ByteBank_Heranca_E_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_E_Interface.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
