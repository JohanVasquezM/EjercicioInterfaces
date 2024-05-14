using EjercicioInterfaces;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }

        public double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return 0.5 * baseTriangulo * altura;
        }

        public double CalcularVolumenEsfera(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        public void Imprimir()
        {
            Console.WriteLine("Resultados de las operaciones:");

            // Área del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radioCirculo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Área del círculo: {CalcularAreaCirculo(radioCirculo)}");

            // Perímetro del rectángulo
            Console.Write("Ingrese el largo del rectángulo: ");
            double largoRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el ancho del rectángulo: ");
            double anchoRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Perímetro del rectángulo: {CalcularPerimetroRectangulo(largoRectangulo, anchoRectangulo)}");

            // Volumen del cilindro
            Console.Write("Ingrese el radio del cilindro: ");
            double radioCilindro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del cilindro: ");
            double alturaCilindro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Volumen del cilindro: {CalcularVolumenCilindro(radioCilindro, alturaCilindro)}");

            // Área del triángulo
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Área del triángulo: {CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");

            // Volumen de la esfera
            Console.Write("Ingrese el radio de la esfera: ");
            double radioEsfera = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Volumen de la esfera: {CalcularVolumenEsfera(radioEsfera)}");
        }
    }

}
