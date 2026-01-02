/*
Eliminar duplicados
Dado un array con números repetidos:
- Crea otro array sin duplicados
- Muéstralo

No uses Distinct()
*/
namespace Eliminar_Duplicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = { 1, 23, 20, 40, 9, 23, 20, 1 };

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        numeros[j] = -1; // Marcar como duplicado
                    }
                }
            }
            foreach (var numero in numeros)
            {
                if (numero != -1)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
