using Programa2._2.Class;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese las notas
        Console.WriteLine("Ingrese la primera nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        // Crear una instancia de la clase Alumno
        Alumno alumno = new Alumno(nota1, nota2, nota3);

        // Calcular el promedio
        double promedio = alumno.CalcularPromedio();

        // Verificar si el alumno está promocionado utilizando la clase VerificadorPromocion
        string resultado = VerificadorPromocion.VerificarPromocion(promedio);

        // Mostrar el resultado
        Console.WriteLine(resultado);
    }
}
