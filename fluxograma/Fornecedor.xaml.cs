namespace fluxograma
{
    public partial class Fornecedor : ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorEditar();
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        async void Delete(object sender, EventArgs args)
	    {
		   var resp = await DisplayAlert ("APAGAR" , "Certeza que deseja apagar este usuário?" , "SIM" , "NÃO"); 
          // if (resp == "SIM")
           {

           }
	    }
    }
}