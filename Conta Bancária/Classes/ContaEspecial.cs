using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Bancária.Classes
{
    public class ContaEspecial : ContaBancaria
    {
        private decimal Limite = 10000;
        public ContaEspecial(string nome, decimal saldoInicial) : base(nome, saldoInicial)
        {
            this.setSaldo(Limite);
        }
    }
}
