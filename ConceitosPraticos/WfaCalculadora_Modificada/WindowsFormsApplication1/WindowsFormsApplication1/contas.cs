using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalculadora_Melhorada
{
    public class contas
    {
		//propfull
		private double num1;

		public double Num1
		{
			get { return num1; }
			set { num1 = value; }
		}

		private double num2;

		public double Num2
		{
			get { return num2; }
			set { num2 = value; }
		}

		public contas()
		{
			Num1 = 0;
			Num2 = 0;
		}

		public contas(double num1, double num2)
		{
			Num1 = num1;
			Num2 = num2;
		}

		public string Somar()
        {
			return "A adição é " + (Num1 + Num2) + ".";
        }

		public string Subtrair()
		{
			return "A subtração é " + (Num1 - Num2) + ".";
		}

		public string Multiplicar()
		{
			return "A multiplicação é " + (Num1 * Num2) + ".";
		}

		public string Dividir()
		{
			return "A divisão é " + (Num1 / Num2) + ".";
		}

		public string Potenciar()
		{
			return "A potenciação de " + Num1 + " por " + Num2 + " é: " + Math.Pow(Num1, Num2) + ".";
		}
	}
}