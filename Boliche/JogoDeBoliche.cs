namespace Boliche
{
    public class JogoDeBoliche
    {
        private const int NUMERO_MAXIMO_DE_LANCES = 10;

        private int[] arremessos = new int[21];
        private int arremessoAtual = 0;

        public void Derrubar(int pinos)
        {
            this.arremessos[arremessoAtual] = pinos;
            arremessoAtual++;
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