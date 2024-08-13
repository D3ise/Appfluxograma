
using Modelos;

namespace Controles;

public class MateriaControle : ControleBase
{
  //----------------------------------------------------------------------------

  public MateriaControle() : base()
  {
    NomeDaTabela = "Materia";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateria)
  {
    var collection = liteDB.GetCollection<Materia>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateria);
  }

  //----------------------------------------------------------------------------

  public virtual List<Materia>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Materia>(NomeDaTabela);
    return new List<Materia>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateria)
  {
    var collection = liteDB.GetCollection<Materia>(NomeDaTabela);
    collection.Delete(idMateria);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Materia materia)
  {
    var collection = liteDB.GetCollection<Materia>(NomeDaTabela);
    collection.Upsert(materia);
  }

  //----------------------------------------------------------------------------
}