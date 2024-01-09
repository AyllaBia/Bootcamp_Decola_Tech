using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        Console.Write("Digite a quantidade de jogos que deseja adicionar: ");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa o array com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];

        // Loop para adicionar jogos conforme a quantidade especificada:
        for (int i=0; i < quantidadeJogos; i++)
        {
            AdicionarJogo(i, nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        Console.Write("Digite o nome do jogo: ");
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.Write($"Foi adicionado '{quantidadeJogos}' jogos: ");
        Console.Write(string.Join(", ", nomes) + " ao catalogo.");
    }
}
