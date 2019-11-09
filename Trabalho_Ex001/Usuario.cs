using System;

namespace Trabalho_Ex001
{
    public class Usuario : Pessoa
    {
        public void ExibirNiveisDeJogo()
        {
            Console.WriteLine
                (
                    "================================== \n" +
                    $"{Nome}, digite 1 ou 2 de acordo o nível de jogo que gostaria de jogar: \n" +
                      $"Nível 1 - números de 1 a 20, com 5 chances para acertar. \n" +
                      $"Nível 2 - números de 1 a 40, com 10 chances para acertar. \n " +
                    "================================== \n" 
                );
        }

        public void SolicitarNome()
        {
            Console.Write("Informe o nome do usuario: ");
        }

        public void SolicitarNumerosNivelUm()
        {
            Console.WriteLine("==================================");
            Console.Write($"{Nome}, informe um número de 1 a 20: ");
        }
        public void SolicitarNumerosNivelDois()
        {
            Console.WriteLine("==================================");
            Console.Write($"{Nome}, informe um número de 1 a 40: ");
        }

        public void InformarNumeroMaior()
        {
            Console.WriteLine($"{Nome}, o número digitado é maior do que o número sorteado");
        }

        public void InformarNumeroMenor()
        {
            Console.WriteLine($"{Nome}, o número digitado é menor do que o número sorteado");
        }

        public void InformarNumeroGanhador()
        {
            Console.WriteLine($"Parabéns {Nome}, você acertou o número!");

        }

        public void JogarNovamente()
        {
            Console.WriteLine($"Deseja jogar novamente? (Sim ou Não)");
        }

        public void InformarJogadasRestantes(int jogadasRestantes)
        {
            Console.WriteLine($"Jogadas restantes: {jogadasRestantes}");
        }
    }
}
