namespace Course.Entities
{
    class Comment
    {
      public string Text { get; set; }

      public Comment() // Consutor
      {

      }

      public Comment(string text) // Consutor com argumentos
      {
        Text = text;
      }
    }
}