using JornadaMilhas.Dominio.Entidades;
using JornadaMilhas.Dominio.ValueObjects;
using System.Net.Http.Json;

using JornadaMilhas.Integration.Test.API.DataBuilders;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhas.Integration.Test.API
{
    public class OfertaViagem_GET: IClassFixture<JornadaMilhasWebApplicationFactory>
    {
        private readonly JornadaMilhasWebApplicationFactory app;

        public OfertaViagem_GET(JornadaMilhasWebApplicationFactory app)
        {
            this.app = app;
        }

        [Fact]
        public async Task RecuperaOfertaViagemPorId()
        {
            var ofertaExistente = app.Context.OfertasViagem.FirstOrDefault();

            if(ofertaExistente is null)
            {
                ofertaExistente = new OfertaViagem(
                    new Rota("Sao caitano","São Paulo"),
                    new Periodo( new DateTime(2024,2,2),
                    new DateTime(2025,2,2)),
                    300.00
                    );

            }

            using var client = await app.GetClientWithAcessTokenAsync();

            var response = await client.GetFromJsonAsync<OfertaViagem>(
                "/ofertas-viagem/"+ ofertaExistente.Id);

            Assert.NotNull( response );
            Assert.Equal(response.Preco, ofertaExistente.Preco, 0.001);
            Assert.Equal(response.Rota.Origem, ofertaExistente.Rota.Origem);
        }


        [Fact]
        public async Task RecuperarOfertasViagensNaConsultaPaginada()
        {

            var ofertaDataBuilder = new OfertaViagemDataBuilder();
            var listaDeOfertas = ofertaDataBuilder.Generate(80);
            app.Context.OfertasViagem.AddRange(listaDeOfertas);
            app.Context.SaveChanges();

            using var client = await  app.GetClientWithAcessTokenAsync();

            int pagina = 1;
            int tamanhoPorPagina = 80;

            var response = await client.GetFromJsonAsync<ICollection<OfertaViagem>>(
                $"/ofertas-viagem?pagina={pagina}&tamanhoPorPagina={tamanhoPorPagina}" 
                );


            Assert.True(response != null);
            Assert.Equal(tamanhoPorPagina, response.Count());
        }



        [Fact]
        public async Task RecuperarOfertasViagensNaConsultaUltimaPaginada()
        {
            app.Context.Database.ExecuteSqlRaw("Delete from ofertasViagem");

            var ofertaDataBuilder = new OfertaViagemDataBuilder();
            var listaDeOfertas = ofertaDataBuilder.Generate(80);
            app.Context.OfertasViagem.AddRange(listaDeOfertas);
            app.Context.SaveChanges();

            using var client = await app.GetClientWithAcessTokenAsync();

            int pagina = 4;
            int tamanhoPorPagina = 25;

            var response = await client.GetFromJsonAsync<ICollection<OfertaViagem>>(
                $"/ofertas-viagem?pagina={pagina}&tamanhoPorPagina={tamanhoPorPagina}"
                );


            Assert.True(response != null);
            Assert.Equal(5, response.Count());
        }


        [Fact]
        public async Task RecuperarOfertasViagensNaConsultaDeUmaPaginaInexistente()
        {
            app.Context.Database.ExecuteSqlRaw("Delete from ofertasViagem");

            var ofertaDataBuilder = new OfertaViagemDataBuilder();
            var listaDeOfertas = ofertaDataBuilder.Generate(80);
            app.Context.OfertasViagem.AddRange(listaDeOfertas);
            app.Context.SaveChanges();

            using var client = await app.GetClientWithAcessTokenAsync();

            int pagina = 6;
            int tamanhoPorPagina = 25;

            var response = await client.GetFromJsonAsync<ICollection<OfertaViagem>>(
                $"/ofertas-viagem?pagina={pagina}&tamanhoPorPagina={tamanhoPorPagina}"
                );


            Assert.True(response != null);
            Assert.Equal(0, response.Count());
        }



        [Fact]
        public async Task RecuperarOfertasViagensNaConsultaDeUmaPaginaComValorNegativo()
        {
            app.Context.Database.ExecuteSqlRaw("Delete from ofertasViagem");

            var ofertaDataBuilder = new OfertaViagemDataBuilder();
            var listaDeOfertas = ofertaDataBuilder.Generate(80);
            app.Context.OfertasViagem.AddRange(listaDeOfertas);
            app.Context.SaveChanges();

            using var client = await app.GetClientWithAcessTokenAsync();

            int pagina = -6;
            int tamanhoPorPagina = 25;

            // act = Assert 
            // trabalhando com exceções
            await Assert.ThrowsAsync<HttpRequestException>(async () =>
            {
                var response = await client.GetFromJsonAsync<ICollection<OfertaViagem>>(
                $"/ofertas-viagem?pagina={pagina}&tamanhoPorPagina={tamanhoPorPagina}"
                );

            });

        }
    }
}
