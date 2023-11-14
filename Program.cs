namespace PracticaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 80, 90, 100, 200, 300, 400, 500, 600, 700 };

            var numerosFiltrados = numeros.Where(numero => numero > 30 && numero < 100).ToList();
            
            foreach (var numero in numerosFiltrados)
            {
                Console.WriteLine(numero);
            }

            // Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas

            List<string> palabras = new List<string> { "hola", "mundo", "como", "estas", "bien", "mal", "regular", "excelente", "ventilador", "reloj" };       

            var palabrasFiltradas = palabras.Where(palabra => palabra.Length >= 5).Select(palabra => palabra.ToUpper()).ToList();

            foreach (var palabra in palabrasFiltradas)
            {
                Console.WriteLine(palabra);
            }

            // Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r"

            var palabrasFiltradas2 = palabras.Where(palabra => palabra.StartsWith("b") || palabra.EndsWith("r")).ToList();

            // Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente

            var numerosOrdenados = numeros.OrderByDescending(numero => numero).Take(5).ToList();

            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }

            //Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20

            var numerosAlCuadrado = numeros.Where(numero => numero * numero > 20).Select(numero => numero + " - " + numero * numero).ToList();

            foreach (var numero in numerosAlCuadrado)
            {
                Console.WriteLine(numero);
            }

            // Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.

            List<string> palabrasConIa = new List<string> { "dia", "estudiar", "cantaria", "pedo" }; 

            List<string> palabrasSinIa = palabrasConIa.Select(palabra => palabra.Replace("ia", "*")).ToList();

            foreach (var palabra in palabrasSinIa)
            {
                Console.WriteLine(palabra);
            }

            // Implementar la función que devuelva sólo las palabras en mayúsculas de la cadena

            string cadena = "HOLA Mundo COMO ESTAS Bien Mal REGULAR";

            foreach (var palabra in DevolverPalabrasCapitales(cadena))
            {
                Console.WriteLine(palabra);
            }

        }
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            return cadena.Split(' ').Where(palabra => palabra == palabra.ToUpper()).ToList();
        }

    }
}