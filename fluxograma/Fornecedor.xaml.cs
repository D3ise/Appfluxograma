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
    }
}