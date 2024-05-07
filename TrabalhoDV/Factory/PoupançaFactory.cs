using System;
using System.Collections.Generic;
using TrabalhoDV.Classes;

namespace TrabalhoDV.Factory
{
    internal class PoupançaFactory
    {

        public Boolean Deposito(Conta conta, double valor)
        {

            if (valor == 0)
            {
                return false;
            }
            else
            {
                conta.saldo += valor;
                return true;

            }

        }

        public Boolean Saque(Conta conta, double valor)
        {

            if ((valor == 0) || (valor > conta.saldo))
            {
                return false;
            }
            else
            {
                conta.saldo -= valor;
                return true;
            }

        }

        public Boolean Transferencia(Conta conta_O, Conta conta_D, double valor)
        {

            if ((valor == 0) || (valor > conta_O.saldo))
            {
                return false;
            }
            else
            {
                conta_O.saldo -= valor;
                conta_D.saldo += valor;
                return true;
            }

        }
    }
}
