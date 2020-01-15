using Boliche;
using Xunit;

namespace BolicheTestes
{
    public class JogoDeBolicheTeste
    {
        private JogoDeBoliche jogoDeBoliche;

        public JogoDeBolicheTeste()
        {
            this.jogoDeBoliche = new JogoDeBoliche();
        }


        [Fact]
        public void calculaAPontuacaoDeUmJogoInteiroNaSarjeta()
        {
            Derrubar(0, 20);

            Assert.Equal(0, jogoDeBoliche.CalcularPontuacao());
        }


        [Fact]
        public void calculaAPontuaDeUmJogoSimples()
        {
            Derrubar(4, 2);
            Derrubar(1, 18);

            Assert.Equal(26, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmSpare()
        {
            jogoDeBoliche.Derrubar(4);
            jogoDeBoliche.Derrubar(6);
            jogoDeBoliche.Derrubar(3);
            Derrubar(0, 18);

            Assert.Equal(16, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmStrike()
        {
            jogoDeBoliche.Derrubar(10);
            jogoDeBoliche.Derrubar(6);
            jogoDeBoliche.Derrubar(1);
            Derrubar(0, 18);

            Assert.Equal(24, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmJogoPerfeito()
        {
            Derrubar(10, 12);
            Assert.Equal(300, jogoDeBoliche.CalcularPontuacao());
        }

        private void Derrubar(int pinos, int arremessos)
        {
            for (int i = 0; i < arremessos; i++)
            {
                jogoDeBoliche.Derrubar(pinos);
            }
        }
    }
}
