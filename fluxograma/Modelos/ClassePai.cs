using LiteDB;
using Modelos;

namespace Modelos
{
   public class ClassePai : Registro
   {
   public string Matériaprima {get; set;}
   public int Quantidade {get; set;}
   public string Fornecedor {get; set;}
   public string Produto {get; set;}

   [BsonId]
   public int Id {get; set;}
   }
}