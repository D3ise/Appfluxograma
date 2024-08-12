using LiteDB;

namespace Modelos
{
   public class Cliente : Pessoa 
   {
       [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Sobrenome { get; set; }

  public string Telefone { get; set; }
   }
}