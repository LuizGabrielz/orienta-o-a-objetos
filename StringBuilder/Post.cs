using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); // Para muitos que vai receber uma lista de comentario

        public Post()
        {   
        }

        public Post(DateTime momment, string title, string content, int likes)
        {
            Moment = Moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) // Operação para adiconar um comentário na lista
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) // Operação para remover um comentário na lista
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Responsável por fazer a montagem do string e depois que tiver pronto vc pega isso na forma de string
            sb.AppendLine(Title); // Adicona um texto no final e da uma quebra de linha no final tb 
            sb.Append(Likes); // Adicona um texto no fim do StringBuilder
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) // Pecorrer a lista para cada comentário c ele vai adicionar um texo
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}