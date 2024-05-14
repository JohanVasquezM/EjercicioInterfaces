using EjercicioInterfaces;

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double CalcularAreaCirculo(double radio);
        double CalcularPerimetroRectangulo(double largo, double ancho);
        double CalcularVolumenCilindro(double radio, double altura);
        double CalcularAreaTriangulo(double baseTriangulo, double altura);
        double CalcularVolumenEsfera(double radio);
    }
}
