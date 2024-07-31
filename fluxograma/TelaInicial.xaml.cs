namespace fluxograma
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

         private void Cliente(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Fornecedor();
        }

         private void Fornecedor(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Fornecedor();
        }
    }
}
