using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDal
    {
        private readonly ScreenSoundConnection context;
        public ArtistaDal(ScreenSoundConnection context)
        {
            this.context = context;
        }


        public IEnumerable<Artista> Listar()
        {

            var artistas = context.Artistas.ToList();
            return artistas;

            // deixando comentado para fins didaticos

            //    var lista = new List<Artista>();

            //    using var connection = new ScreenSoundConnection().ObterConexao();
            //    connection.Open();

            //    string query = "SELECT * FROM Artistas";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    using SqlDataReader dataReader = command.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        string nome = Convert.ToString(dataReader["Nome"]);
            //        string bioArtista = Convert.ToString(dataReader["Bio"]);
            //        int idArtista = Convert.ToInt32(dataReader["Id"]);

            //        Artista artista = new Artista(nome, bioArtista)
            //        {
            //            Id = idArtista
            //        };
            //        lista.Add(artista);
            //    }
            //    return lista;
        }


        public void Adicionar(Artista artista)
        {
            context.Artistas.Add(artista);  
            context.SaveChanges();
            //using var connection = new ScreenSoundConnection().ObterConexao();
            //connection.Open();

            //string query = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@nome", artista.Nome);
            //command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            //command.Parameters.AddWithValue("@bio", artista.Bio);

            //int retorno = command.ExecuteNonQuery();
            //Console.WriteLine($"Linhas afetadas : {retorno}");
        }


        public void Deletar(Artista artista)
        {
            context.Artistas.Remove(artista);   
            context.SaveChanges();
            //using var connection = new ScreenSoundConnection().ObterConexao();
            //connection.Open();

            //string query = $"DELETE FROM Artistas WHERE Id = @id";
            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@id", artista.Id);
            //int retorno = command.ExecuteNonQuery();
            //if (retorno > 0)
            //{
            //    Console.WriteLine("Arista foi deletado com sucesso");
            //}
            //else
            //{
            //    Console.WriteLine("Artista não encontrado");
            //}

        }

        public void atualizar(Artista artista)
        {

            context.Artistas.Update(artista);
            context.SaveChanges();  
            //using var connection = new ScreenSoundConnection().ObterConexao();
            //connection.Open();

            //string query = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@nome", artista.Nome);
            //command.Parameters.AddWithValue("@bio", artista.Bio);
            //command.Parameters.AddWithValue("@id", artista.Id);

            //int retorno = command.ExecuteNonQuery();
            //if (retorno > 0)
            //{
            //    Console.WriteLine("Usuaario atualizado com sucesso !");
            //}
            //else
            //{
            //    Console.WriteLine("Usuario não encontrado !");
            //}

        }


        public Artista? BuscarPorNome(string nomeArtista)
        {
            var artista_encontrado  = context.Artistas.FirstOrDefault(x => x.Nome.ToUpper() == nomeArtista.ToUpper().Trim());
            return artista_encontrado;
        }
    }
}
