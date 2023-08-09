namespace AplicacionDemo
{
    class Programa1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo!!!");
            int num1 = 5;
            int num2 = 6;
            double numero3 = 2.57;
            double suma;
            suma = num1 + num2;

            Console.WriteLine("El resultado de la suma és: " + suma);

            string valor1 = Console.ReadLine();
            Console.WriteLine("El valor introducido es " + valor1);
            int valorint = Convert.ToInt32(valor1);
        }
    }
}