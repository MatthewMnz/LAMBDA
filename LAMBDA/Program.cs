namespace LAMBDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAMBDA Progra I");

            Func<int, int, int> suma = (a, b) => a + b;
            Console.WriteLine(suma(3, 4));

            Func<double, double> prod = x => x * x; 
            Console.WriteLine(prod(10));

            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(10, "Progra I"));

            Action<int> MayorEdad = n =>
            {
                Boolean ME = (n > 18) ? true : false;
                Console.WriteLine($"Es mayor de edad {ME} ");
            };

            MayorEdad(15);

            Action<string> saludar = _ => Console.WriteLine("Hola");
            saludar("Ignorado"); 
        }
    }
}
