namespace Modelos
{
   public class Cliente : Pessoa 
   {
   string cnpj;

   public string GetCnpj ()
   {
      return cnpj;
   }

   public void SetCnpj (string cnpj)
   {
      this.cnpj = cnpj;
   }
      
   }
}