using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- CÁLCULO DA IDADE EM MESES E DIAS -----");

            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int meses = idade * 12;
            int dias = meses * 30;

            Console.WriteLine(" A sua idade em meses totaliza: " + (meses) + " " + "meses.");
            Console.WriteLine(" Já em dias totaliza: " + (dias) + " " + "dias.");
        }
    }
}
