using System.Drawing;
using TrabalhoDV.Classes;
using TrabalhoDV.Conexoes;
using TrabalhoDV.Factory;



Console.WriteLine("Bem vindo ao Banco Pitagoras");
Console.WriteLine();

Banco banco  = new Banco();
Menu menu = new Menu(banco);
menu.Inicializar();

