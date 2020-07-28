using Conta_Bancária.Classes;
using System;

namespace Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma Conta Nova passando o nome e o valor inicail
            var conta1 = new ContaBancaria("Zé das couve", 0);
            //printando o acontecimento
            Console.WriteLine($"A nova conta de  {conta1.Nome} é o numero  {conta1.Numero}");

            //REaliso um deposito
            conta1.Deposito(100, Convert.ToDateTime("01-04-2020") , "Deposito em Cheque");
            //print o acontecimento
            Console.WriteLine($"Deposito de 100 com Saldo {conta1.getSaldo()}");

            //REaliso um deposito
            conta1.Deposito(500, Convert.ToDateTime("02-04-2020"), "Deposito em Dinheiro");
            //print o acontecimento
            Console.WriteLine($"Deposito de 500 com Saldo {conta1.getSaldo()}");

            conta1.Saque(300, Convert.ToDateTime("02-04-2020"), "Deposito em Dinheiro");
            //print o acontecimento
            Console.WriteLine($"Saque de 300 com Saldo {conta1.getSaldo()}");

            var contaEspecial = new ContaEspecial("João Bacana", 0);
            //print o acontecimento
            Console.WriteLine($"A nova conta de  {contaEspecial.Nome} é o numero  {contaEspecial.Numero} {contaEspecial.getSaldo()}");

        }
    }
}
