using LambdasAndDelegates;
using System;
using Xunit;

namespace UnitTesting
{
   
    public class LambdasAndDelegates
    {
        [Fact]
        public void DeberiaSumarCorrectamente()
        {
            // Arrange
            int esperado = 15;
            Delegados delegados = new Delegados();

            // Act
            int resultado = delegados.suma(10, 5);

            // Assert
            Assert.Equal(esperado, resultado);

        }
    }
}
