using JornadaMilhas.Dominio.Entidades;
using JornadaMilhas.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Integration.Test.API
{
    public class OfertaViagem_DELETE:IClassFixture<JornadaMilhasWebApplicationFactory>
    {
        private readonly JornadaMilhasWebApplicationFactory app;
        public OfertaViagem_DELETE(JornadaMilhasWebApplicationFactory app)
        {
            this.app = app;
        }

        [Fact]
        public async Task DeletarOfertaViagemPorId()
        {
            var ofertaExistente = app.Context.OfertasViagem.FirstOrDefault();

            if (ofertaExistente is null)
            {
                ofertaExistente = new OfertaViagem(
                    new Rota("Sao caitano", "São Paulo"),
                    new Periodo(new DateTime(2024, 2, 2),
                    new DateTime(2025, 2, 2)),
                    300.00
                    );

            }

            using var client = await app.GetClientWithAcessTokenAsync();

            var response = await client.DeleteAsync(
                "/ofertas-viagem/" + ofertaExistente.Id);

            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
