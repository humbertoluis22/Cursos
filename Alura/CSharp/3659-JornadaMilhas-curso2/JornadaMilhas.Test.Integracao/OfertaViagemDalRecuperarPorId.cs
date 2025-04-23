using JornadaMilhas.Dados;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace JornadaMilhas.Test.Integracao
{

    //public class OfertaViagemDalRecuperarPorId: IClassFixture<ContextoFixture>
    [Collection(nameof(ContextoCollection))]
    public class OfertaViagemDalRecuperarPorId 
    {
        private readonly JornadaMilhasContext context;

        public OfertaViagemDalRecuperarPorId(
            ITestOutputHelper output,
            ContextoFixture fixture)
        {
            context = fixture.Context;
            output.WriteLine(context.GetHashCode().ToString());
        }

        [Fact]
        public void RetornaNuloQuandoIdInexistente()
        {
            var dal = new OfertaViagemDAL(context);

            var oferta = dal.RecuperarPorId(-2);

            Assert.Null(oferta);
        }


    }
}
