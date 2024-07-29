namespace Modelos
{
   public class Produtos : Registro
   {
   string nome;
   int unidade;
   int id;

   public string GetNome ()
   {
      return nome;
   }

   public void SetNome (string nome)
   {
      this.nome = nome;
   }

   public int GetUnidade ()
   {
      return unidade;
   }

   public void SetUnidade (int unidade)
   {
      this.unidade = unidade;
   }

   public int GetId ()
   {
      return id;
   }

   public void SetId (int id)
   {
      this.id = id;
   }
   }
}