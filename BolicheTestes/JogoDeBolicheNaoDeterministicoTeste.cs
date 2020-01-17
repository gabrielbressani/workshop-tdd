using Boliche;
using Boliche.Api;
using Refit;
using Xunit;

namespace BolicheTestes
{
    public class JogoDeBolicheNaoDeterministicoTeste
    {
        private JogoDeBolicheNaoDeterministico jogoDeBoliche;

        public JogoDeBolicheNaoDeterministicoTeste()
        {
            IBolicheApi bolicheApi = RestService.For<IBolicheApi>("http://demo0654407.mockable.io");
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
        }

        [Fact]
        public void calculaAPontuacaoDeUmJogoInteiroNaSarjeta()
        {
            Assert.Equal(0, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuaDeUmJogoSimples()
        {
            Assert.Equal(20, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmSpare()
        {
            Assert.Equal(16, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmStrike()
        {
            Assert.Equal(24, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmJogoPerfeito()
        {
            Assert.Equal(300, jogoDeBoliche.CalcularPontuacao());
        }

    }
}
