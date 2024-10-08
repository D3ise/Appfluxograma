using LiteDB;
using Modelos;

namespace Modelos
{
   public class Materia : Registro
   {
      public string Nome { get; set; }
      public decimal Valor { get; set; }
      public Unidade Unidade { get; set; }

      [BsonId]
      public int Id { get; set; }
   }
}