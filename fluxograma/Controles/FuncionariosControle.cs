
using Modelos;

namespace Controles;

public class FuncionariosControle : ControleBase
{
  //----------------------------------------------------------------------------

  public FuncionariosControle() : base()
  {
    NomeDaTabela = "Funcionarios";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFuncionarios)
  {
    var collection = liteDB.GetCollection<Funcionarios>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFuncionarios);
  }

  //----------------------------------------------------------------------------

  public virtual List<Funcionarios>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Funcionarios>(NomeDaTabela);
    return new List<Funcionarios>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFuncionarios)
  {
    var collection = liteDB.GetCollection<Funcionarios>(NomeDaTabela);
    collection.Delete(idFuncionarios);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Funcionarios funcionarios)
  {
    var collection = liteDB.GetCollection<Funcionarios>(NomeDaTabela);
    collection.Upsert(funcionarios);
  }

  //----------------------------------------------------------------------------
}