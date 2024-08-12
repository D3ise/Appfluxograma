using LiteDB;

namespace Modelos
{
   public class Produtos : Registro
   {
   public string Nome {get; set;}
   public int Unidade {get; set;}

   [BsonId]
   public int Id {get; set;}
   }
}