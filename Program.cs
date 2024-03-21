namespace Ejer21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se requiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
           - Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
           - Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable.
           - Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso.
           - Si el IMC es mayor de 29.9 entonces tiene obesidad.
           Mostrar en pantalla la categoría de cada uno de los pacientes. 
           La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcularlo */

            bool calcAgain = true;

            while (calcAgain)
            {
                Console.Write("Ingrese los datos del paciente: ");
                Console.Write("Ingrese el peso en kg: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la altura en metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);
                string categoria = "";

                if (imc < 18.5)
                    categoria = "Peso insuficiente";
                else if (imc <= 24.9)
                    categoria = "Peso saludable";
                else if (imc <= 29.9)
                    categoria = "Sobrepeso";
                else
                    categoria = "Obesidad";

                Console.Write($"El IMC del paciente es: {imc:F2}");
                Console.Write($"Categoría: {categoria}");



                Console.Write("\n¿Quieres calcular el IMC de otro paciente? (s/n)");
                string respuesta = Console.ReadLine().ToLower();
                calcAgain = respuesta == "s";
            }
    }
}
