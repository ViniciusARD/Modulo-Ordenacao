using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Implementação do RadixSort
    class RadixSortStrategy : ISortStrategy
    {
        public void Sort(int[] array) // Método da interface ISortStrategy para iniciar o RadixSort no array
        {
            RadixSort(array); // Chama o método privado RadixSort
        }

        private void RadixSort(int[] array) // Método privado que implementa o algoritmo RadixSort
        {
            int max = GetMax(array); // Obtém o valor máximo no array
            for (int exp = 1; max / exp > 0; exp *= 10) // Loop para cada dígito, começando pelo menos significativo
                CountSort(array, exp); // Chama o método CountSort para classificar o array pelo dígito atual
        }

        private int GetMax(int[] array) // Método privado para encontrar o valor máximo no array
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++) // Loop para encontrar o maior elemento no array
                if (array[i] > max)
                    max = array[i];
            return max; // Retorna o valor máximo
        }

        private void CountSort(int[] array, int exp) // Método privado para classificar o array com base no dígito atual (exp)
        {
            int n = array.Length;
            int[] output = new int[n]; // Array de saída para armazenar os elementos ordenados
            int[] count = new int[10]; // Array para contar a ocorrência de cada dígito (de 0 a 9)
            Array.Fill(count, 0); // Inicializa o array de contagem com zeros

            for (int i = 0; i < n; i++) // Conta ocorrências de cada dígito
                count[(array[i] / exp) % 10]++; // Calcula o dígito atual e incrementa o contador correspondente

            for (int i = 1; i < 10; i++) // Calcula as posições finais de cada elemento no array de saída
                count[i] += count[i - 1]; // Acumula as contagens para determinar as posições finais

            for (int i = n - 1; i >= 0; i--) // Preenche o array de saída de forma ordenada com base nas posições calculadas
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i]; // Coloca o elemento na posição correta no array de saída
                count[(array[i] / exp) % 10]--; // Decrementa o contador após cada inserção
            }

            for (int i = 0; i < n; i++) // Copia o array de saída ordenado de volta para o array original
                array[i] = output[i];
        }
    }

}
