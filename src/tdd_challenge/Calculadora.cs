namespace tdd_challenge.App;

public class Calculadora
{
    private List<string> listaHistorico;

    public Calculadora()
    {
        listaHistorico = new List<string>();
    }

    public int Somar(int num1, int num2)
    {
        var resultado = num1 + num2;

        listaHistorico.Insert(0, $"Res: {resultado}");

        return resultado;
    }

    public int Subtrair(int num1, int num2)
    {
        var resultado = num1 - num2;

        listaHistorico.Insert(0, $"Res: {resultado}");

        return resultado;
    }

    public int Multiplicar(int num1, int num2)
    {
        var resultado = num1 * num2;

        listaHistorico.Insert(0, $"Res: {resultado}");

        return resultado;
    }

    public int Dividir(int num1, int num2)
    {
        var resultado = num1 / num2;

        listaHistorico.Insert(0, $"Res: {resultado}");

        return resultado;
    }

    public List<string> Historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

        return listaHistorico;
    }
}