using System;

namespace UD5E1
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "";
      
            double resultado = 0;
            String eleccion = "Introduce una figura: circulo, triangulo o cuadrado";
            switch (eleccion)
            {
                //Segun la figura realizamos una serie de acciones
                case "circulo":
                    texto = "Introduce el radio";
                    int radio = Convert.ToInt32(texto);
                    resultado = areaCirculo(radio);
                    break;
                case "triangulo":
                    texto = "Introduce la base";
                    int _base = Convert.ToInt32(texto);
                    texto = "Introduce la altura";
                    int altura = Convert.ToInt32(texto);
                    resultado = areaTriangulo(_base, altura);
                    break;
                case "cuadrado":
                    texto = "Introduce la medida de un lado";
                    int lado = Convert.ToInt32(texto);
                    resultado = areaCuadrado(lado);
                    break;
                default:
                    Console.WriteLine("No has introducido una figura correcta");
                    break;
            }
            Console.WriteLine("El area del " + eleccion + " es " + resultado);
        }
        public static double areaCirculo(int radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
        public static double areaTriangulo(int _base, int altura)
        {
            return _base * altura / 2;
        }
        public static double areaCuadrado(int lado)
        {
            return lado * lado;
        }
    }
}
