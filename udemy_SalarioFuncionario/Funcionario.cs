using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_SalarioFuncionario
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = porcentagem * 0.01;
            porcentagem = porcentagem + 1;
            salarioBruto = salarioBruto * porcentagem;
        }
    }
}
