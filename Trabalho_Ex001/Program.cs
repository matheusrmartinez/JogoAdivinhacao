using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoEscolhida;
            string jogarNovamente, nomeUsuario;
            Usuario interacoesUsuario = new Usuario();
            Jogada jogada;

            interacoesUsuario.SolicitarNome();
            nomeUsuario = Console.ReadLine();
            interacoesUsuario.Nome = nomeUsuario;

            interacoesUsuario.ExibirNiveisDeJogo();
            opcaoEscolhida = int.Parse(Console.ReadLine());

            jogada = new Jogada();
            jogada.GerarNumeroAleatorio(opcaoEscolhida);
            jogarNovamente = jogada.AdivinharNumero(jogada, interacoesUsuario);

            while (jogarNovamente == "Sim")
            {
                Console.Clear();
                interacoesUsuario = new Usuario();
                interacoesUsuario.SolicitarNome();
                nomeUsuario = Console.ReadLine();
                interacoesUsuario.Nome = nomeUsuario;
                interacoesUsuario.ExibirNiveisDeJogo();
                opcaoEscolhida = int.Parse(Console.ReadLine());

                jogada = new Jogada();
                jogada.GerarNumeroAleatorio(opcaoEscolhida);
                jogarNovamente = jogada.AdivinharNumero(jogada, interacoesUsuario);
            }
        }
    }
}
