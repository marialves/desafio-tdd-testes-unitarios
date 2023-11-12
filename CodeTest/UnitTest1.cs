using Code;

namespace CodeTest;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        string data = "11/12/2023";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();
    
        // Act
    
        // Assert
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();
    
        // Act
        calc.Somar(1, 2);
        calc.Somar(2, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.Historico();
    
        // Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}