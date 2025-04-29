using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class MusicaDal:DAL<Musica>
    {
        private readonly ScreenSoundConnection _context;
        public MusicaDal(ScreenSoundConnection context)
        {
            _context = context;
        }

        public override IEnumerable<Musica> Listar()
        {
            var musicas = _context.Musicas.ToList();
            return musicas;
        }

        public override void Adicionar(Musica musica)
        {
            _context.Musicas.Add(musica);
            _context.SaveChanges();
        }


        public override void Atualizar(Musica musica)
        {
            _context.Musicas.Update(musica);
            _context.SaveChanges();
        }

        public override void Deletar(Musica musica)
        {
            _context.Musicas.Remove(musica);
            _context.SaveChanges(); 
        }

        public Musica? RecuperarPeloNome(string nomeMusica)
        {
            var musica = _context.Musicas.FirstOrDefault(m => m.Nome == nomeMusica);
            return musica;
        }
    }
}
