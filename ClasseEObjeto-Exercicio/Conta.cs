using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEObjeto_Exercicio
{
    internal class Conta
    {
        public int Numero;
        public string? Titular;
        public double Saldo;

        //Sobrecarga
        public Conta(int numero, string titular)
        {
            Titular = titular;
            Numero = numero;
            
        }
        public Conta(int numero, string titular, double saldo) {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }
        public void Transferir(double valor, Conta destino) {
            this.Saldo = this.Saldo - valor;

            //destino.saldo = destino.saldo + valor
            destino.Saldo += valor;
        }
        public void Depositar(double valor) {
            this.Saldo = this.Saldo + valor;
        }

        public void Sacar(double valor) {
            if (valor < this.Saldo)
            {
                this.Saldo = this.Saldo - valor;
            }
            else {
                Console.WriteLine("Saldo Insuficiente...");
            }
            
        }

        public double ConsultaSaldo() {
            return this.Saldo; 
        }

        public override string ToString()
        {
            return Numero + ", $"+ Titular ;
        }

    }
}
