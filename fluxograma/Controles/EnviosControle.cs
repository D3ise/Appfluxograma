
using Modelos;

namespace Controles;

public class EnviosControle : ControleBase
{
  //----------------------------------------------------------------------------

  public EnviosControle() : base()
  {
    NomeDaTabela = "Envios";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEnvios)
  {
    var collection = liteDB.GetCollection<Envios>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEnvios);
  }

  //----------------------------------------------------------------------------

  public virtual List<Envios>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Envios>(NomeDaTabela);
    return new List<Envios>(tabela.FindAll().OrderBy(d => d.Quantidade));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEnvios)
  {
    var collection = liteDB.GetCollection<Envios>(NomeDaTabela);
    collection.Delete(idEnvios);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Envios envios)
  {
    var collection = liteDB.GetCollection<Envios>(NomeDaTabela);
    collection.Upsert(envios);
  }

  //----------------------------------------------------------------------------
}