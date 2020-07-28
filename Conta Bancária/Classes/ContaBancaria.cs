using Conta_Bancária.Classes;
using System;
using System.Collections.Generic;

namespace Conta_Bancária
{
	public class ContaBancaria
	{
		public string Numero { get; }
		public string Nome { get; set; }
		private decimal Saldo { get; set; }
		
		private static int NumeroContaSequencia = 123456;

		private List<Transacao> Extrato = new List<Transacao>();


		public ContaBancaria(string nome, decimal saldoInicial)
		{
			this.Numero = NumeroContaSequencia.ToString();
			NumeroContaSequencia++;
			this.Nome = nome;
			this.setSaldo(saldoInicial);

		}

		public void Deposito(decimal valor, DateTime date, string anotacao)
		{
			this.Saldo += valor;
			var deposito = new Transacao(valor, date, anotacao);
			Extrato.Add(deposito);
		}

		public void Saque(decimal valor, DateTime date, string anotacao)
		{
			this.Saldo -= valor;
			var saque = new Transacao(-valor, date, anotacao);
			Extrato.Add(saque);
		}

		public decimal getSaldo() => Saldo;
		public decimal setSaldo(decimal valor) => Saldo += valor;

	}

}