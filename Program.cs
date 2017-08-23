using System;

namespace Lista21082017ex04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			decimal valorReais, cotacaoDolar, valorDolares;

			Console.Write("Digite o valor em Reais: ");
			valorReais = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Digite a cotação do dólar: ");
			cotacaoDolar = Convert.ToDecimal(Console.ReadLine());

			valorDolares = valorReais * cotacaoDolar;
            Console.Write("O valor em dólares é US$ {0:##,##0.00}", valorDolares);
			
			Console.ReadLine();
        }
    }
}
