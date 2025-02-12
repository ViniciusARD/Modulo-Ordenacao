# Ordenação com Diferentes Algoritmos e Web Server

Este projeto demonstra o uso de diferentes algoritmos de ordenação em C#, com implementação de um servidor web para ordenar arrays via requisições HTTP. O código implementa uma variedade de algoritmos de ordenação e expõe esses algoritmos em um servidor web simples, permitindo que os usuários solicitem a ordenação de arrays diretamente via URL.

Além disso, o projeto inclui a geração de um array com números aleatórios (de 1 a 99) que são ordenados utilizando diferentes estratégias de ordenação, medindo o tempo de execução de cada uma delas. Em seguida, o código tenta se conectar a um banco de dados e realizar a ordenação de listas de alunos e livros em ordem alfabética, também medindo o tempo de execução para cada estratégia de ordenação.

## Funcionalidades

- Implementação de diversos algoritmos de ordenação: Cube Sort, Merge Sort, Radix Sort, Quick Sort, e Shell Sort.
- Um servidor web simples em C# que expõe os algoritmos de ordenação via requisição HTTP.
- Utilização de padrões de projeto como **Strategy**, **Adapter**, **Prototype**, **Singleton** e **Factory**.

## Padrões de Projeto Utilizados

1. **Strategy**:
   - O padrão Strategy é utilizado para encapsular diferentes algoritmos de ordenação. O código permite que qualquer algoritmo de ordenação seja facilmente substituído, oferecendo flexibilidade.
   - Cada algoritmo de ordenação (CubeSort, MergeSort, etc.) é implementado como uma classe que segue a interface `ISortImplementation`.

2. **Adapter**:
   - O padrão Adapter é utilizado para adaptar os algoritmos de ordenação para a interface esperada pela aplicação de web. A classe `CubeSortAdapter` é um exemplo, onde o algoritmo CubeSort é adaptado para seguir a interface `ISortAlgorithm`.

3. **Prototype**:
   - O padrão Prototype é utilizado para clonar arrays antes de ordená-los, garantindo que o array original não seja modificado. A interface `IPrototypeArray` é implementada por diferentes tipos de arrays (como `PrototypeInt` e `PrototypeAlunoArray`).

4. **Singleton**:
   - O servidor web utiliza o padrão Singleton para garantir que apenas uma instância do servidor seja criada durante a execução do programa.

5. **Factory**:
   - O padrão Factory pode ser observado na criação dos algoritmos de ordenação no servidor web, onde diferentes algoritmos são instanciados com base em parâmetros de URL.

## Como Usar

### Execução Local

1. Clone o repositório:
   ```bash
   git clone https://github.com/ViniciusARD/Modulo-Ordenacao.git
   ```

2. Abra o projeto em uma IDE como o Visual Studio.

3. Execute o projeto. O servidor web será iniciado na porta `5051` e ficará ouvindo por requisições.

### Requisições HTTP para Ordenação

Depois de iniciar o servidor, você pode acessar os algoritmos de ordenação via requisições HTTP, usando a URL com o formato:

```
http://localhost:5051/sort?algorithm=<nome_do_algoritmo>&array=<array_a_ser_ordenado>
```

Exemplo de URLs de ordenação:

- Ordenação usando **QuickSort**:
  ```
  http://localhost:5051/sort?algorithm=quicksort&array=4,2,7,1,3
  ```
  
- Ordenação usando **CubeSort**:
  ```
  http://localhost:5051/sort?algorithm=cubesort&array=4,2,7,1,3
  ```

- Ordenação usando **MergeSort**:
  ```
  http://localhost:5051/sort?algorithm=mergesort&array=4,2,7,1,3
  ```

Os resultados serão retornados diretamente na resposta HTTP.

## Estrutura de Arquivos

- **Program.cs**: Arquivo principal que contém a lógica de execução e ordenação.
- **WebServer.cs**: Implementação do servidor web que lida com requisições HTTP.
- **Adapter/CubeSortAdapter.cs**: Adaptação do algoritmo CubeSort para a interface de algoritmos de ordenação.
- **ModuloOrdenacao/Sort**: Contém as implementações dos algoritmos de ordenação.
- **ModuloOrdenacao/Prototype**: Contém a implementação de protótipos para clonagem de arrays.

## Dependências

Este projeto não tem dependências externas além do .NET Core.

