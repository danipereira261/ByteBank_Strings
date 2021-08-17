using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string cpf) : base(3000, cpf)
        {
        }


        public override void AumentarSalario()
        {
        }

        protected override double GetBonificacao()
        {
            return Salario;
        }
    }
}
