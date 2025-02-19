using System;
using CalculadoraNamespace;

class Program
{
    static void Main()
    {
        // Crear instancia de la Calculadora
        var calc = new Calculadora();

        // Ejecutar operaciones
        int suma = calc.Sumar(5, 3);
        int resta = calc.Restar(10, 4);
        int multiplicacion = calc.Multiplicar(6, 2);
        double division = calc.Dividir(8, 2);

        // Mostrar resultados en la consola
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}
