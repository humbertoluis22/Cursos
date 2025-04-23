using Bogus;
using JornadaMilhasV1.Gerencidor;
using JornadaMilhasV1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Test
{
    public class GerenciadorDeOfertasRecuperaMaiorDesconto
    {
        [Fact]
        public void RetornaOfertaNulaQuandoListaVazia()
        {
            var lista = new List<OfertaViagem>();
            var gerenciador = new GerenciadorDeOfertas(lista);
            Func<OfertaViagem, bool> filtro = o => o.Rota.Destino.Equals("São Paulo");

            var ofertas = gerenciador.RecupeMaiorDesconto(filtro);

            Assert.Null(ofertas);
        }



        [Fact]
        public void RetornaOfertaEspecificaQuandoDestinoSaoPauloEDesconto40()
        {
            // arrange 
            // faker 
            var fakerPeriodo = new Faker<Periodo>()
                .CustomInstantiator(f => {
                    var periodo = f.Date.Soon();
                    return new Periodo(periodo, periodo.AddDays(30));
                    });

            Rota rota = new Rota("Curitiba", "São Paulo");

            var fakerOferta = new Faker<OfertaViagem>().
                CustomInstantiator(f =>
                    new OfertaViagem(
                    rota,
                    fakerPeriodo.Generate(),
                    100 * f.Random.Int(1, 100)
                    ))
                    .RuleFor(o => o.Desconto , f => 40)
                    .RuleFor(o => o.Ativa,f => true);

            var ofertaEscolhida = new OfertaViagem(
                rota,
                fakerPeriodo.Generate(),
                80
                )
            {
                Desconto = 40,
                Ativa = true,
            };


            var ofertaInativa = new OfertaViagem(
                rota,
                fakerPeriodo.Generate(),
                70
                )
            {
                Desconto = 40,
                Ativa = false,
            };

            var lista = fakerOferta.Generate(200);
            lista.Add(ofertaEscolhida);
            lista.Add(ofertaInativa);

            var gerenciador = new GerenciadorDeOfertas(lista);
            Func<OfertaViagem, bool> filtro = o => o.Rota.Destino.Equals("São Paulo");

            var oferta = gerenciador.RecupeMaiorDesconto(filtro);
            var valorProcurado = 40;

            Assert.Equal(valorProcurado, oferta.Preco,0.0001);

        }
    }
}
