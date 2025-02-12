using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Implementação do ShellSort

    class ShellSortStrategy : ISortStrategy
    {
        public void Sort(int[] array) // Método da interface ISortStrategy para iniciar o ShellSort no array
        {
            ShellSort(array); // Chama o método privado ShellSort
        }

        private void ShellSort(int[] array) // Método privado que implementa o algoritmo ShellSort
        {
            int n = array.Length; // Obtém o comprimento do array
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1) // Loop sobre os diferentes gaps
                {
                    int temp = array[i]; // Armazena o elemento atual em temp
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap) // Inicia um loop para comparar e trocar elementos com gap
                        array[j] = array[j - gap]; // Move os elementos
                    array[j] = temp; // Insere o elemento na posição correta
                }
            }
        }
    }
}
