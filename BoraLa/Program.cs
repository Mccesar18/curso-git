using System;
using System.Globalization;

namespace BoraLa
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 38;
            double saldo = 10.35784;
            string nome = "César";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Placeholders {0} tempo de contagem para substituição ao final pelas variáveis, {2:F2} para utilização de 2 casas decimais
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture ) + " reais");//Concatenação
            Console.WriteLine("Configurando o Git");
            Console.WriteLine("Bom dia hoje?");
            Console.WriteLine("Terceira inserção");
        }
    }
}
