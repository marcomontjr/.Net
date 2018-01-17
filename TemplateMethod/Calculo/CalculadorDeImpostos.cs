﻿using System;

namespace TemplateMethod
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
                double valor = imposto.Calcula(orcamento);
                Console.WriteLine(valor);       
        }
    }
}
