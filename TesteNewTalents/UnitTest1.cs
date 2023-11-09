using NewTalents;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(9, 5, 4)]
        public void TesteSubtrair(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(12, 3, 4)]
        public void TesteDividir(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Dividir(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TesteDivPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(8, 9);
            calc.Somar(10, 11);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}