
using Modelos;

namespace Controles;



public class UnidadeControle : ControleBase
{
  //----------------------------------------------------------------------------

  public UnidadeControle() : base()
  {
    NomeDaTabela = "Unidades";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idUnidade)
  {
    var collection = liteDB.GetCollection<Materia>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return new List<Unidade>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idUnidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Delete(idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidade unidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Upsert(unidade);
  }

  //----------------------------------------------------------------------------
}