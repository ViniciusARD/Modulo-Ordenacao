using System;
using System.Diagnostics;
using _2024_04_30_ModuloOrdenacao;

class Program
{
    static void Main()
    {
        Random random = new Random(); // Inicializa um objeto Random para gerar números aleatórios

        int[] sizes = { 256, 512, 1024, 2048, 4096 }; // Tamanhos dos arrays que serão gerados e ordenados

        // Array de estratégias de ordenação a serem testadas
        ISortStrategy[] strategies = {
            new CubeSortStrategy(),
            new MergeSortStrategy(),
            new QuickSortStrategy(),
            new RadixSortStrategy(),
            new ShellSortStrategy()
        };

        // Para cada estratégia de ordenação
        foreach (ISortStrategy strategy in strategies)
        {
            // Para cada tamanho de array
            foreach (int size in sizes)
            {
                int[] randomNumbers = GenerateRandomArray(random, size); // Gera um novo array de números aleatórios
                Console.WriteLine($"\nArray de tamanho {size} gerado com sucesso.");

                Console.WriteLine("\nNúmeros desorganizados:");
                PrintArray(randomNumbers);

                Console.WriteLine($"\nOrdenando com {strategy.GetType().Name}..."); // Executa a estratégia de ordenação no array gerado e mede o tempo de execução
                int[] sortedArray = (int[])randomNumbers.Clone();
                MeasureTime(() => strategy.Sort(sortedArray));

                Console.WriteLine("\nNúmeros organizados:");
                PrintArray(sortedArray);

                Console.WriteLine();
            }
        }
    }

    // Método para gerar um array de números aleatórios
    static int[] GenerateRandomArray(Random random, int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 100000); // Gera um número aleatório no intervalo de 0 a 100000
        }
        return array;
    }

    // Método para medir o tempo de execução de uma ação
    static void MeasureTime(Action action)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedTicks} ticks");
    }

    // Método para imprimir um array na tela
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
