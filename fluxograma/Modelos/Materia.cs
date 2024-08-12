using LiteDB;

namespace Modelos
{
   public class Materia : Registro
   {
   public string Nome {get; set;}
   public decimal Valor {get; set;}
   public string Matériaprima {get; set;}

   [BsonId]
   public int Id {get; set;}
   }
}