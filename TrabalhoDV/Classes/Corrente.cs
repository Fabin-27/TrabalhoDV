using System;
using System.Collections.Generic;

namespace TrabalhoDV.Classes
{
    internal class Corrente : Conta
    {
        public Corrente(double saldo, double agencia, int numero_C) : base(saldo, agencia, numero_C)
        {
        }
    }
}
