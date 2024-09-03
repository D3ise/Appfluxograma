using LiteDB;

namespace Modelos
{
public class Unidade : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome {get; set ;}
}
}