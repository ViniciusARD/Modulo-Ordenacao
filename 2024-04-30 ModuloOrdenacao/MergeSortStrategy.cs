using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Implementação do MergeSort
    class MergeSortStrategy : ISortStrategy
    {
        public void Sort(int[] array) // Método da interface ISortStrategy para iniciar o MergeSort no array
        {
            MergeSort(array, 0, array.Length - 1); // Chama o método privado MergeSort com os índices inicial e final
        } 

        private void MergeSort(int[] array, int left, int right) // Método privado que implementa o algoritmo MergeSort
        {
            if (left < right)
            {
                int mid = (left + right) / 2; // Calcula o ponto médio do array
                MergeSort(array, left, mid); // Classifica recursivamente a metade esquerda do array
                MergeSort(array, mid + 1, right); // Classifica recursivamente a metade direita do array
                Merge(array, left, mid, right); // Combina as duas metades ordenadas
            }
        }

        private void Merge(int[] array, int left, int mid, int right) // Método privado para combinar duas metades ordenadas do array
        {
            int n1 = mid - left + 1; // Tamanho da primeira metade
            int n2 = right - mid; // Tamanho da segunda metade

            int[] leftArray = new int[n1]; // Array temporário para a primeira metade
            int[] rightArray = new int[n2]; // Array temporário para a segunda metade

            // Copia os elementos para os arrays temporários
            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2) // Combina os elementos dos arrays temporários de volta ao array original de forma ordenada
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1) // Copia os elementos restantes da primeira metade (se houver)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            
            while (j < n2) // Copia os elementos restantes da segunda metade (se houver)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
