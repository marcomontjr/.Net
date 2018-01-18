using ExercicioRelatorios.Templates;
using System;
using System.Collections.Generic;

namespace ExercicioRelatorios
{
    class Simples : TRelatorio
    {      
        Console.WriteLine("----------------------------");
        Console.WriteLine("Relatório Banco " + conta.banco);

        public void Corpo(Conta conta)
        {
            foreach (var item in conta)
            {

            }
            Console.WriteLine("-" +  );
        };            
    }
}
