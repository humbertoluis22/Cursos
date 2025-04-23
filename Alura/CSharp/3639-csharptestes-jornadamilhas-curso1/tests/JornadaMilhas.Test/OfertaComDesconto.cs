using JornadaMilhasV1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Test
{
    public class OfertaComDesconto
    {

        [Fact]
        public void RetornaPrecoAtualizadoQuandoAplicadoDesconto()
        {
            Rota rota = new Rota("OrigemTest", "DestinoTest");
            Periodo periodo = new Periodo
            (
                new DateTime(2025, 1, 5),
                new DateTime(2025, 2, 2)
            );

            double precoOriginal = 300.00;
            double valorDesconto = 30.00;
            double precoComDesconto = precoOriginal - valorDesconto; 

            OfertaViagem ofertaViagem = new OfertaViagem(rota, periodo, precoOriginal);
            ofertaViagem.Desconto = valorDesconto;


            Assert.Equal(precoComDesconto, ofertaViagem.Preco);
        }


        [Theory]
        [InlineData(330.00,90.00)]
        [InlineData(300.00, 90.00)]
        public void RetornaPrecoAtualizadoQuandoAplicadoDescontoMaximo(
            double valorDesconto,
            double precoComDesconto)
        {
            Rota rota = new Rota("OrigemTest", "DestinoTest");
            Periodo periodo = new Periodo
            (
                new DateTime(2025, 1, 5),
                new DateTime(2025, 2, 2)
            );

            double precoOriginal = 300.00;

            OfertaViagem ofertaViagem = new OfertaViagem(rota, periodo, precoOriginal);
            ofertaViagem.Desconto = valorDesconto;


            Assert.Equal(precoComDesconto, ofertaViagem.Preco,0.001);
        }
    }
}
