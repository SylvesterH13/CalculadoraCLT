﻿namespace CalculadoraCLT
{
    interface ISalario
    {
        double SalarioLiquido(double salarioBruto);
        double TaxaDescontos(double salarioBruto);
        double TotalDescontos(double salarioBruto);
    }
}