namespace Modelos
{
   public class Funcionarios : Pessoa 

   {
   string endereco;
   string cargo;

   public string GetEndereco ()
   {
      return endereco;
   }

   public void SetEndereco (string endereco)
   {
      this.endereco = endereco;
   }

   public string GetCargo ()
   {
      return cargo;
   }

   public void SetCargo (string cargo)
   {
      this.cargo = cargo;
   }
      
   }
}