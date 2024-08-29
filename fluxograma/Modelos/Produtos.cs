using LiteDB;
using Modelos;

namespace Modelos
{
   public class Produtos : Registro
   {
   public string Nome {get; set;}
   public int Unidade {get; set;}
   public int Valor {get; set;}

   [BsonId]
   public int Id {get; set;}
   }
}