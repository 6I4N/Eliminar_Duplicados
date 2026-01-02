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
            int[] numeros = { 1, 23, 20, 40, 9, 23, 20, 1 };
            int[] sinDuplicados = new int[numeros.Length];
            int count = 0;

            for (int i = 0; i < numeros.Length; i++) 
            {
                bool repetido = false;

                for (int j = 0; j < count; j++)
                {
                    if (numeros[i] == sinDuplicados[j])
                    {
                        repetido = true;
                        break;
                    }
                }

                if (!repetido)
                {
                    sinDuplicados[count] = numeros[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sinDuplicados[i]);
            }

        }
    }
}
