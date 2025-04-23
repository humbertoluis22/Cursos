using JornadaMilhasV1.Modelos;
using Microsoft.EntityFrameworkCore.Query;

namespace JornadaMilhas.Test
{
    public class OfertaViagemConstrutor
    {
        [Theory]
        [InlineData("OrigemTest", "DestinoTest","2025-01-01", "2025-01-01",true)]
        [InlineData(null, "DestinoTest", "2025-01-01", "2024-01-01", false)]
        [InlineData(null, "DestinoTest", "2025-01-01", "2026-01-01", false)]
        [InlineData("DestinoEntrada", null, "2025-01-01", "2026-01-01", false)]
        [InlineData("SaoPaulo", "RJ","2024-02-01", "2025-01-01",true)]
        [InlineData("CidadeOrigem", "DestinoTest", "2025-01-01", "2025-01-02", true)]
        public void RetornarOfertaValidaDeAcordoComDadosDeEntrada
         (
            string origem,
            string destino, 
            string dataInicio, 
            string dataFinal , 
            bool validacao
           )
        {
            // cenario 
            Rota rota = new Rota(origem,destino);
            Periodo periodo = new Periodo
            (
                DateTime.Parse(dataInicio),
                DateTime.Parse(dataFinal)
            );

            // criacao 
            OfertaViagem ofertaViagem = new OfertaViagem( rota, periodo,123.32 );

            // validacao 
            Assert.Equal(validacao , ofertaViagem.EhValido);

            // triplo aaa
        }



        [Fact]
        public void RetornaMensagemDeErrorQuandoRotaInvalida()
        {
            Rota rota = new Rota("","");
            Periodo periodo = new Periodo
            (
                new DateTime(2025, 1, 5),
                new DateTime(2025, 2, 2)
            );

            OfertaViagem ofertaViagem = new OfertaViagem(rota, periodo, 123.32);

            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", ofertaViagem.Erros.Sumario);
            Assert.False(ofertaViagem.EhValido);

        }




        [Fact]
        public void RetornaMensagemDeErrorQuandoRotaNull()
        {
            Rota rota = null;
            Periodo periodo = new Periodo
            (
                new DateTime(2025, 1, 5),
                new DateTime(2025, 2, 2)
            );

            OfertaViagem ofertaViagem = new OfertaViagem(rota, periodo, 123.32);

            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", ofertaViagem.Erros.Sumario);
            Assert.False(ofertaViagem.EhValido);

        }

        [Theory]
        [InlineData(-300)]
        [InlineData(0)]
        public void RetornaMensagemDeErrorQuandoValorInvalida(double valor)
        {
            Rota rota = new Rota("OrigemTest", "DestinoTest");
            Periodo periodo = new Periodo
            (
                new DateTime(2025, 1, 5),
                new DateTime(2025, 2, 2)
            );

            OfertaViagem ofertaViagem = new OfertaViagem(rota, periodo, valor);

            Assert.Contains("O preço da oferta de viagem deve ser maior que zero.", ofertaViagem.Erros.Sumario);


        }


        [Fact]
        public void RetornaErrosDeValidacaoQuandoRotaPeriodoEPrecoSaoInvalidos()
        {
            //arrange

            Rota rota = new Rota("","");
            Periodo periodo = new Periodo(
                new DateTime(2024, 6, 1), 
                new DateTime(2023, 1, 1));

            double preco = -100.00;
            //adction

            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);
            // assert

            int qtdDeErros = 3;

            Assert.Equal(qtdDeErros, oferta.Erros.Count());
        }
    
    }
}