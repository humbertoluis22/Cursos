using JornadaMilhas.Dados;
using JornadaMilhasV1.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Xunit.Abstractions;

namespace JornadaMilhas.Test.Integracao
{
    // ta criando uma nova instacia da classe, o que era pra evitar isso 

    //public class OfertaViagemDalAdicionar : IClassFixture<ContextoFixture>
    [Collection(nameof(ContextoCollection))]
    public class OfertaViagemDalAdicionar 
    {
        private readonly JornadaMilhasContext context;
        public OfertaViagemDalAdicionar(ITestOutputHelper output, ContextoFixture fixture)
        {
            context = fixture.Context;
            output.WriteLine(context.GetHashCode().ToString());

        }

        [Fact]
        public void RegistaOfertaNoBanco()
        {
            Rota rota = new Rota("São Paulo", "Fortaleza");
            Periodo periodo = new Periodo(
                new DateTime(2024,2,2),
            new DateTime(2025,2,3));
            double preco = 350;

            var oferta = new OfertaViagem(rota, periodo, preco);
            
            var dal = new OfertaViagemDAL(context);

            dal.Adicionar(oferta);
            var ofertaIncluida = dal.RecuperarPorId(oferta.Id);
            Assert.NotNull(ofertaIncluida);
            Assert.Equal(ofertaIncluida.Preco, oferta.Preco, 0.0001);
                

        }


        [Fact]
        public void RegistaOfertaEValidarSeTodosOsCamposEstaoCorreto()
        {
            Rota rota = new Rota("São Paulo", "Fortaleza");
            Periodo periodo = new Periodo(
                new DateTime(2024, 2, 2),
            new DateTime(2025, 2, 3));
            double preco = 350;

            var oferta = new OfertaViagem(rota, periodo, preco);

            var dal = new OfertaViagemDAL(context);

            dal.Adicionar(oferta);
            var ofertaIncluida = dal.RecuperarPorId(oferta.Id);

            Assert.NotNull(ofertaIncluida);
            Assert.Equal(ofertaIncluida.Periodo, oferta.Periodo);
            Assert.Equal(ofertaIncluida.Ativa, oferta.Ativa);
            Assert.Equal(ofertaIncluida.Preco, oferta.Preco, 0.0001);

        }
    }
}
