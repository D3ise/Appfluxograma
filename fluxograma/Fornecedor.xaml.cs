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
        void Delete(object sender, EventArgs args)
	    {
		    frameDelete.IsVisible = true;
	    }
        void Back(object sender, EventArgs args)
	    {
		   frameDelete.IsVisible =  false;
	    }
         void Volta(object sender, EventArgs args)
	    {
		   frameDelete.IsVisible =  false;
	    }
    }
}