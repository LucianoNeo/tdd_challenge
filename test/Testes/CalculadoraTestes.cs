using tdd_challenge.App;

namespace tdd_challenge.Testes
{
    public class CalculadoraTestes
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 5)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(10, 5, 50)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = new();

            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(5, 6);
            calc.Somar(7, 8);
            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}