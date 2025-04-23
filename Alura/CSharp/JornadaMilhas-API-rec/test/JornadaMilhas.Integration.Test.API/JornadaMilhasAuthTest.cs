using JornadaMilhas.API.DTO.Auth;
using Microsoft.Identity.Client;
using System.Net;
using System.Net.Http.Json;

namespace JornadaMilhas.Integration.Test.API
{
    public class JornadaMilhasAuthTest
    {
        [Fact]
        public  async Task POSTEfeturaLoginComSucesso()
        {
            var app = new JornadaMilhasWebApplicationFactory(); 

            var user = new UserDTO
            {
                Email = "tester@email.com",
                Password = "Senha123@"
            };

            using var client = app.CreateClient();

            var resultado = await client.PostAsJsonAsync("/auth-login", user);

            Assert.Equal(HttpStatusCode.OK , resultado.StatusCode);
        }
    }
}