
using Modelos;

namespace Controles;

public class ComprasControle : ControleBase
{
  //----------------------------------------------------------------------------

  public ComprasControle() : base()
  {
    NomeDaTabela = "Compras";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCompras)
  {
    var collection = liteDB.GetCollection<Compras>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCompras);
  }

  //----------------------------------------------------------------------------

  public virtual List<Compras>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Compras>(NomeDaTabela);
    return new List<Compras>(tabela.FindAll().OrderBy(d => d.Quantidade));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCompras)
  {
    var collection = liteDB.GetCollection<Compras>(NomeDaTabela);
    collection.Delete(idCompras);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Compras compras)
  {
    var collection = liteDB.GetCollection<Compras>(NomeDaTabela);
    collection.Upsert(compras);
  }

  //----------------------------------------------------------------------------
}