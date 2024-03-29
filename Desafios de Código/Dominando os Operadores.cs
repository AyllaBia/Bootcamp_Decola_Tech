// Descrição
// Agora, focaremos em outro conceito fundamental de programação para desenvolver um algoritmo que possua como objetivo a simulação de um 
// Sistema de Gerenciamento de Tarefas. Dessa forma, crie variáveis como, titulo, descricao e dataVencimento para guardar as informações das tarefas, após isso, implemente uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres. Caso a descrição exceda 50 carateres, trataremos essa condição exibindo uma mensagem adequada. Lembrando que as estruturas condicionais são fundamentais para o controle de fluxo dos programas pois realizam verificações precisas com base em condições específicas predefinidas, neste caso, é o limite de 50 caracteres.

// Entrada
// A entrada será as Strings com o titulo da tarefa, a descrição e a data de vencimento.

// Saída
// Será exibido a tarefa que foi adicionada com o título, descrição e data de vencimento. Mas caso a descrição tenha mais de 50 caracteres deverá ser 
// informado: 'O Valor da descrica excede a quantidade de caracteres permitido'.

using System;

class Program
{
    static void Main() {

//  TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
    string titulo, descricao, dataVencimento;
        
 // Obtém o titulo e a descricao a partir da entrada do console  
    Console.Write("Digite o titulo da tarefa: ");
    titulo = Console.ReadLine();

    Console.Write("Digite a descrição da tarefa: ");
    descricao = Console.ReadLine();

//  TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
    if (descricao.Length > 50) {
      Console.WriteLine("Descrição ultrapassa o limite de caracteres.");
    }

    else {
//  Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
        Console.Write("Digite a data de vencimento da tarefa: ");
        dataVencimento = Console.ReadLine();

//  TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
        Console.WriteLine(descricao + " ate " + dataVencimento);
        }
    }

}