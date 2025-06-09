using System;

namespace FigurasGeometricas
{
    // La clase Circulo representa un círculo con un radio encapsulado.
    class Circulo
    {
        private double radio;

        // Constructor para inicializar el radio del círculo.
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea devuelve el área del círculo.
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro (circunferencia) del círculo.
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // La clase Rectangulo representa un rectángulo con base y altura encapsuladas.
    class Rectangulo
    {
        private double baseRect;
        private double altura;

        // Constructor para inicializar base y altura del rectángulo.
        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // CalcularArea devuelve el área del rectángulo.
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // CalcularPerimetro devuelve el perímetro del rectángulo.
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    // Clase principal para probar las figuras.
    class Programa
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo(5); // Círculo con radio 5
            Rectangulo r = new Rectangulo(4, 6); // Rectángulo de base 4 y altura 6

            Console.WriteLine("Círculo - Área: " + c.CalcularArea());
            Console.WriteLine("Círculo - Perímetro: " + c.CalcularPerimetro());

            Console.WriteLine("Rectángulo - Área: " + r.CalcularArea());
            Console.WriteLine("Rectángulo - Perímetro: " + r.CalcularPerimetro());
        }
    }
}
