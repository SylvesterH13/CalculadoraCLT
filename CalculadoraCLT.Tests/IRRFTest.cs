﻿using CalculadoraCLT.Tests.TestData;
using System;
using Xunit;

namespace CalculadoraCLT.Tests
{
    public class IRRFTest
    {
        private readonly IRRF _irrf = new IRRF();

        [Theory]
        [MemberData(nameof(IRRFTestData.IRRF_Deve_Calcular), MemberType = typeof(IRRFTestData))]
        public void IRRF_Deve_Calcular(double salarioBruto, double irrfEsperado)
        {
            var irrfCalculado = _irrf.Calcular(salarioBruto);
            Assert.Equal(irrfEsperado, irrfCalculado, precision: 2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5000)]
        public void IRRF_Calcular_Deve_Lancar_ArgumentException_Salario_Bruto_Menor_Igual_Zero(double salarioBruto)
        {
            Assert.Throws<ArgumentException>(() => _irrf.Calcular(salarioBruto));
        }
    }
}