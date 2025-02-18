using Xunit;

namespace Calculadora.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestearSuma()
        {
            // Crea las variables necesarias para la prueba
            var calc = new Calculadora();
            int a = 5;
            int b = 3;

            // Ejecuta el método a probar
            int resultado = calc.Sumar(a, b);

            // Verifica el resultado
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void TestearResta()
        {
            // Crea las variables necesarias para la prueba
            var calc = new Calculadora();
            int a = 5;
            int b = 3;

            // Ejecuta el método a probar
            int resultado = calc.Restar(a, b);

            // Verifica el resultado
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void TestearMultiplicacion()
        {   
            // Crea las variables necesarias para la prueba
            var calc = new Calculadora();
            int a = 5;
            int b = 3;

            // Ejecuta el método a probar
            int resultado = calc.Multiplicar(a, b);

            // Verifica el resultado
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void TestearDivision()
        {
            // Crea las variables necesarias para la prueba
            var calc = new Calculadora();
            int a = 6;
            int b = 3;

            // Ejecuta el método a probar
            int resultado = calc.Dividir(a, b);

            // Verifica el resultado
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void TestearDivisionPorCero()
        {
            // Crea las variables necesarias para la prueba
            var calc = new Calculadora();
            int a = 6;
            int b = 0;

            // Comprueba si hay algun error al dividir por cero
            Assert.Throws<System.DivideByZeroException>(() => calc.Dividir(a, b));
        }
    }
}