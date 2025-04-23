using JornadaMilhas.API.DTO.Auth;
using JornadaMilhas.Dados;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Integration.Test.API
{
    public class JornadaMilhasWebApplicationFactory: WebApplicationFactory<Program>
    {
        
        public JornadaMilhasContext Context { get; }

        // recuperar o novo contexto  da area de teste
        public IServiceScope scope { get; }

        public JornadaMilhasWebApplicationFactory()
        {
            this.scope = Services.CreateScope();
            Context = scope.ServiceProvider.GetRequiredService<JornadaMilhasContext>(); 
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services => {
                services.RemoveAll(typeof
                    (DbContextOptions<JornadaMilhasContext>));
                services.AddDbContext<JornadaMilhasContext>(options =>
                options.UseLazyLoadingProxies()
                .UseSqlServer("Server=localhost,11433;Database=JornadaMilhasV3;" +
                "User Id=sa;" +
                "Password=Alura#2024;" +
                "Encrypt=false;" +
                "TrustServerCertificate=true;" +
                "MultipleActiveResultSets=true;")
                );
            });
            base.ConfigureWebHost(builder);
        }

        public async Task<HttpClient> GetClientWithAcessTokenAsync()
        {
            var client = this.CreateClient();


            var user = new UserDTO
            {
                Email = "tester@email.com",
                Password = "Senha123@"
            };

            var resultado = await client.PostAsJsonAsync("/auth-login",user);

            resultado.EnsureSuccessStatusCode();

            var result = await
               resultado.Content.ReadFromJsonAsync<UserTokenDTO>();

            client.DefaultRequestHeaders.Authorization = new
                AuthenticationHeaderValue("Bearer", result!.Token);

            return client;

        }
    }
}
