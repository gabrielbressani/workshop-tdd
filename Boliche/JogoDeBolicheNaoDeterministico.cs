using Boliche.Api;

namespace Boliche
{
    public class JogoDeBolicheNaoDeterministico
    {
        private const int NUMERO_MAXIMO_DE_LANCES = 10;

        private int[] arremessos = new int[21];

        public JogoDeBolicheNaoDeterministico(IBolicheApi bolicheApi)
        {
            ArremessosResponse response = bolicheApi.ObterArremessos().Result;
            this.arremessos = response.Arremessos;
        }

        public int CalcularPontuacao()
        {
            int soma = 0;

            int arremesso = 0;
            for (int i = 0; i < NUMERO_MAXIMO_DE_LANCES; i++)
            {

                if (arremessos[arremesso] + arremessos[arremesso + 1] == 10)
                {
                    soma += 10 + arremessos[arremesso + 2];
                    arremesso += 2;
                }
                else if (arremessos[arremesso] == 10)
                {
                    soma += 10 + arremessos[arremesso + 1] + arremessos[arremesso + 2];
                    arremesso++;
                }
                else
                {
                    soma += arremessos[arremesso] + arremessos[arremesso + 1];
                    arremesso += 2;
                }

            }

            return soma;
        }
    }
}