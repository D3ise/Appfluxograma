using LiteDB;
using Modelos;

namespace Modelos
{
   public class Pessoa : Registro
   {
      public string Nome { get; set; }
      public string Sobrenome { get; set; }
      public string Telefone { get; set; }
      public string Cpf { get; set; }
      public string Email { get; set; }

      [BsonId]
      public int Id { get; set; }
   }
}