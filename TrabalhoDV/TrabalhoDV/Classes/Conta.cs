using System;
using System.Collections.Generic;


namespace TrabalhoDV.Classes
{
    internal class Conta
    {
        public double saldo;
        public double agencia;
        public int numero_C;

        public Conta(double saldo, double agencia, int numero_C)
        {
            this.saldo = saldo;
            this.agencia = agencia;
            this.numero_C = numero_C;
        }

        
    }

    
}
