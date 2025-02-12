using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Implementação do QuickSort
    class QuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] array) // Método da interface ISortStrategy para iniciar o QuickSort no array
        {
            Quicksort(array, 0, array.Length - 1); // Chama o método privado Quicksort com os índices inicial e final
        }

        private void Quicksort(int[] array, int left, int right) // Método privado que implementa o algoritmo QuickSort
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right); // Encontra o índice do pivô
                Quicksort(array, left, pivotIndex - 1); // Classifica recursivamente os elementos menores que o pivô
                Quicksort(array, pivotIndex + 1, right); // Classifica recursivamente os elementos maiores que o pivô
            }
        }

        private int Partition(int[] array, int left, int right) // Método privado para encontrar o índice do pivô e particionar o array
        {
            int pivot = array[right]; // Escolhe o elemento mais à direita como pivô
            int i = left - 1; // Inicializa o índice do menor elemento

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++; // Incrementa o índice do menor elemento
                    Swap(array, i, j); // Troca os elementos menores com os maiores encontrados
                }
            }

            Swap(array, i + 1, right); // Coloca o pivô na posição correta no array ordenado
            return i + 1; // Retorna o índice do pivô
        }

        private void Swap(int[] array, int i, int j) // Método privado para trocar dois elementos no array
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
