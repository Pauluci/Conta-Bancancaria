using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Bancária.Classes
{
    class Transacao
    {
        public decimal Valor { get; }
        public DateTime Date { get; }
        public string Anotacao { get; }

        public Transacao(decimal valor, DateTime date, string anotacao)
        {
            this.Valor = valor;
            this.Date = date;
            this.Anotacao = anotacao;
        }
    }
}
