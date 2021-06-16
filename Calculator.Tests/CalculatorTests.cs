using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_DeveRetornarASomaDosNumerosFornecidos()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            result.ShouldBe(3);
        }

        [Fact]
        public void Subtract_DeveRetornarASubtracaoDosNumerosFornecidos()
        {
            var calculator = new Calculator();

            var result = calculator.Subtract(2, 1);

            result.ShouldBe(1);
        }

        [Fact]
        public void Divide_DeveLancarExcecaoQuandoDividirPorZero()
        {
            var calculator = new Calculator();

            var exception = Should.Throw<Exception>(() => calculator.Divide(2, 0));
        }
    }
}
