// Descrição
// Neste desafio, aplicaremos conceitos essenciais de programação, seu objetivo é desenvolver uma solução simulando o registro de usuário em uma aplicação. Assegure que o código tenha uma sintaxe clara e organizada, com nomenclaturas significativas para variáveis como email, nomeUsuario, senha que será o local de armazenamento das informações de registro. Escolha tipos de dados apropriados, como o String para representar o email, nomeUsuario e senha. Certifique-se de tratar senha como strings para operações específicas.

// Entrada
// Como entrada receberemos três informações referente ao emailCadastro(String), nomeUsuario(String) e senha(String).

// Saída
// Construa uma mensagem de saída formatada corretamente, como nessa estrutura: ' registroNome + ", verifique o email: " + registroEmail + " para ativar." '

using System;

class Program {
    static void Main(string[] args) {

//  TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string nome, email, senha;

//  Obtém o email e nome do usuário a partir da entrada do console
    Console.Write("Digite seu email: ");
    email = Console.ReadLine();

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine();

//  TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine(nome + ", verifique o email: " + email + " para ativar.");
    }
}