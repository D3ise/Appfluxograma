using LiteDB;

namespace Modelos
{
   public class Funcionarios : Pessoa 

   {
   public string Endereco{get; set;}
   public string Cargo {get; set;}

   [BsonId]
      public int Id {get; set;}
      
   }
}