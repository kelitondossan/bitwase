using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitwase_Praticando
{
    class Program
    {
        static void Main(string[] args)
        {  //PROGRAMA SIMPLES PARA ESTUDOS DE OPERADORES BITWASE 
            //NOÇÃO PARA QUEM QUER CRIAR SOFTWARE QUE TRABALHAM COM MINI CONTROLADORES EM SEUS PROGRAMS]
            int op1 = 0;
            int op2 =0;
            Console.WriteLine("OPERADORES BITWASE\n");
            Console.WriteLine("DIGITE UM NUMERO INYEIRO");
            int.TryParse(Console.ReadLine(), out op1);
            Console.WriteLine("Digite mais um numero inteiro");
            int.TryParse(Console.ReadLine(), out op2);
      
            Console.WriteLine($" o valor de {op1} & {op2} = {op1 & op2} ");
            Console.WriteLine($" o valor de {op1} | {op2} = {op1 | op2} ");
            Console.WriteLine($" o valor de {op1} ^ {op2} = {op1 ^ op2} ");
            Console.WriteLine($" o valor de {op1} ~ {op2} = {~ op1 } ");

            Console.WriteLine($" o valor de {op1} << {op2} = {op1 << op2} ");
            Console.WriteLine($" o valor de {op1} >> {op2} = {op1 >> op2} ");

            Console.ReadKey();

        }
    }
}
