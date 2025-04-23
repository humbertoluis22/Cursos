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
    public class OfertaViagem_Post:IClassFixture<JornadaMilhasWebApplicationFactory>
    {
        private readonly JornadaMilhasWebApplicationFactory app;
        public OfertaViagem_Post(JornadaMilhasWebApplicationFactory app)
        {
             this.app = app;
        }


        [Fact]
        public async Task Cadastrar_OfertaViagem()
        {

            using var client = await app.GetClientWithAcessTokenAsync();

            var ofertaViagem = new OfertaViagem()
            {
                Preco = 300,
                Rota = new Rota("Curitiba", "São Paulo"),
                Periodo = new Periodo(new DateTime(2024,3,2),new DateTime(2025,3,2))
            };

            var response = await client.PostAsJsonAsync("/ofertas-viagem", ofertaViagem);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
               
        }


        [Fact]
        public async Task Cadastrar_OfertaViagem_SemAuth()
        {

            using var client =  app.CreateClient();

            var ofertaViagem = new OfertaViagem()
            {
                Preco = 300,
                Rota = new Rota("Curitiba", "São Paulo"),
                Periodo = new Periodo(new DateTime(2024, 3, 2), new DateTime(2025, 3, 2))
            };

            var response = await client.PostAsJsonAsync("/ofertas-viagem", ofertaViagem);

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);

        }
    }
}
