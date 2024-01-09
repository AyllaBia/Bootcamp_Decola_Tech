using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
        // Horas de uso de eletrônicos por dia e o número de refeições com carne:
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite quantos quilômetros você percorre por dia: ");
        double quilometrosPorDia = double.Parse(Console.ReadLine());

        Console.Write("Digite quantas horas você passa usando eletrônicos: ");
        int horasDeEletronicos = int.Parse(Console.ReadLine());

        Console.Write("Digite quantas refeições por dia você consome carne: ");
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        // Exibe o resultado para o usuário
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // Método para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão
        double fatorTransporte = quilometrosPorDia * 365 * 0.2;
        double fatorEletronicos = horasDeEletronicos * 0.1;
        double fatorCarne = refeicoesComCarne * 0.5;

        // Calcula a pegada de carbono total
        double pegadaDeCarbonoTotal = fatorTransporte + fatorEletronicos + fatorCarne;

        return pegadaDeCarbonoTotal;
    }
}
