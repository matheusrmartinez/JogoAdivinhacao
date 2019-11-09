using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex001
{
    public class Jogada
    {
        public int NivelDoJogo { get; set; }
        public int NumeroAleatorio { get; set; }
        public int TentativasDeAcerto { get; set; }

        public Jogada GerarNumeroAleatorio(int opcaoEscolhida)
        {
            Random random = new Random();

            switch (opcaoEscolhida)
            {
                case 1:
                    NumeroAleatorio = random.Next(1, 20 + 1);
                    TentativasDeAcerto = 5;
                    NivelDoJogo = 1;
                    break;

                case 2:
                    NumeroAleatorio = random.Next(1, 40 + 1);
                    TentativasDeAcerto = 10;
                    NivelDoJogo = 2;
                    break;

            }
            return this;
        }

        public string AdivinharNumero(Jogada jogada, Usuario interacoesUsuario)
        {
            int numeroDigitado = 0, tentativasRestantes = 0, numeroDeTentativas = 0;
            string jogarNovamente = "Sim";

            #region Jogada Nível 1

            if (jogada.NivelDoJogo == 1)
            {
                while (numeroDeTentativas < jogada.TentativasDeAcerto)
                {
                    interacoesUsuario.SolicitarNumerosNivelUm();
                    numeroDigitado = int.Parse(Console.ReadLine());

                    if (numeroDigitado < jogada.NumeroAleatorio)
                    {
                        interacoesUsuario.InformarNumeroMenor();
                        tentativasRestantes = jogada.TentativasDeAcerto - (numeroDeTentativas + 1);
                        interacoesUsuario.InformarJogadasRestantes(tentativasRestantes);
                    }

                    else if (numeroDigitado > jogada.NumeroAleatorio)
                    {
                        interacoesUsuario.InformarNumeroMaior();
                        tentativasRestantes = jogada.TentativasDeAcerto - (numeroDeTentativas + 1);
                        interacoesUsuario.InformarJogadasRestantes(tentativasRestantes);
                    }

                    else
                    {
                        interacoesUsuario.InformarNumeroGanhador();
                        numeroDeTentativas = 5;
                    }
                    numeroDeTentativas++;
                }

                interacoesUsuario.JogarNovamente();
                jogarNovamente = Console.ReadLine();
            }

            #endregion

            #region Jogada Nível 2

            if (jogada.NivelDoJogo == 2)
            {
                while (numeroDeTentativas < jogada.TentativasDeAcerto)
                {
                    interacoesUsuario.SolicitarNumerosNivelDois();
                    numeroDigitado = int.Parse(Console.ReadLine());

                    if (numeroDigitado < jogada.NumeroAleatorio)
                    {
                        interacoesUsuario.InformarNumeroMenor();
                        tentativasRestantes = jogada.TentativasDeAcerto - (numeroDeTentativas + 1);
                        interacoesUsuario.InformarJogadasRestantes(tentativasRestantes);
                    }

                    else if (numeroDigitado > jogada.NumeroAleatorio)
                    {
                        interacoesUsuario.InformarNumeroMaior();
                        tentativasRestantes = jogada.TentativasDeAcerto - (numeroDeTentativas + 1);
                        interacoesUsuario.InformarJogadasRestantes(tentativasRestantes);
                    }

                    else
                    {
                        interacoesUsuario.InformarNumeroGanhador();
                        numeroDeTentativas = 10;
                    }
                    numeroDeTentativas++;
                }
                interacoesUsuario.JogarNovamente();
                jogarNovamente = Console.ReadLine();

            }

            return jogarNovamente;
            #endregion
        }
    }
}
