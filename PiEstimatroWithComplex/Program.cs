using System.Numerics;

public class Program
{
    public static void Main()
    {
        Estimator();
    }

    private static void Estimator()
    {
        Console.WriteLine("Lancement de l'estimation");
        int interationCount = int.Parse(Console.ReadLine());
        for (var t = 0; t < interationCount; t++)
        {
            double theta = 2 * Math.PI / t;
            Complex z = Complex.Exp(Complex.ImaginaryOne * theta);
            Complex sum = 1 - z;
            double operation = (t * sum.Magnitude)/2;
            Console.WriteLine(operation);
        }
    }
}