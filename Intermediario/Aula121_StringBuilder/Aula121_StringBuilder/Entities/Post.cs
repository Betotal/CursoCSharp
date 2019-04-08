using System;
using System.Collections.Generic;
using System.Text;

namespace Aula121_StringBuilder.Entities
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comentarios { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void addComment (Comment comment)
        {
            Comentarios.Add(comment);
        }

        public void removeComment(Comment comment)
        {
            Comentarios.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder StringBD = new StringBuilder();
            StringBD.AppendLine(Titulo);
            StringBD.Append(Likes);
            StringBD.Append(" Likes - ");
            StringBD.AppendLine(Momento.ToString("dd/MM/yy HH:mm:ss"));
            StringBD.AppendLine(Conteudo);
            StringBD.AppendLine("Comentários: ");
            foreach(Comment C in Comentarios)
            {
                StringBD.AppendLine(C.Text);
            }
            return StringBD.ToString();
        }
    }
}
