namespace Modelos
{
   public class Materia : Registro
   {
   string nome;
   decimal valor;
   string matériaprima;
   int id;

   public string GetNome ()
   {
      return nome;
   }

   public void SetNome (string nome)
   {
      this.nome = nome;
   }

   public decimal GetValor ()
   {
      return valor;
   }

   public void SetValor (decimal valor)
   {
      this.valor = valor;
   }

   public string GetMatériaPrima ()
   {
      return matériaprima;
   }

   public void SetMatériaPrima (string matériaprima)
   {
      this.matériaprima = matériaprima;
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