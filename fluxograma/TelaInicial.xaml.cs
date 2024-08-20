using Fluxograma;

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
            Application.Current.MainPage = new ClientePage();
        }

         private void Fornecedor(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorPage();
        }

        private void Produto(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProdutoPage();
        }
    }
}
