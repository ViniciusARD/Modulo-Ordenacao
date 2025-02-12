using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_ModuloOrdenacao
{
    // Interface para os algoritmos de ordenação
    interface ISortStrategy
    {
        // Declaração do método Sort, que será implementado pelas classes concretas
        // Este método recebe um array de inteiros como parâmetro e o ordena de acordo com o algoritmo específico
        void Sort(int[] array);
    }
}
