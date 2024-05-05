

namespace Programa2._2.Class
{
    using System;

    public class Alumno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Alumno(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularPromedio()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }

    public class VerificadorPromocion
    {
        public static string VerificarPromocion(double promedio)
        {
            if (promedio >= 7)
            {
                return "Promocionado";
            }
            else
            {
                return "No promocionado";
            }
        }
    }

}
