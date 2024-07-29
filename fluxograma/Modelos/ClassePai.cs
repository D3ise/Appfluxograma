namespace Modelos
{
   public class ClassePai : Registro
   {
   string matériaprima;
   int quantidade;
   string fornecedor;
   int id;

   public string GetMatériaPrima ()
   {
      return matériaprima;
   }

   public void SetMatériaPrima (string matériaprima)
   {
      this.matériaprima = matériaprima;
   }

   public int GetQuantidade ()
   {
      return quantidade;
   }

   public void SetQuantidade (int quantidade)
   {
      this.quantidade = quantidade;
   }

   public string GetFornecedor ()
   {
      return fornecedor;
   }

   public void SetFornecedor (string fornecedor)
   {
      this.fornecedor = fornecedor;
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