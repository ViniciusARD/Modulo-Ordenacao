using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Implementação do CubeSort
    class CubeSortStrategy : ISortStrategy
    {
        public void Sort(int[] array) // Método da interface ISortStrategy para iniciar o CubeSort no array
        {
            CubeSort(array); // Chama o método privado CubeSort
        }

        private void CubeSort(int[] array) // Método privado que implementa o algoritmo CubeSort
        {
            int n = array.Length;
            int gap = 1;

            // Encontra o maior gap
            while (gap < n / 3)
                gap = gap * 3 + 1;

            for (; gap > 0; gap /= 3)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap) // Insere o elemento array[i] no lugar correto para o gap atual
                    {
                        array[j] = array[j - gap]; // Coloca o elemento temp no lugar correto
                    }

                    array[j] = temp;
                }
            }
        }
    }

}
