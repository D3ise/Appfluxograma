using Modelos;

namespace fluxograma
{
    public partial class ProdutoPage : ContentPage
    {
        public Produtos produto { get; set; }
        Controles.ProdutosControle produtoControle = new Controles.ProdutosControle();
        public ProdutoPage()
        {
            InitializeComponent();
            ListaProduto.ItemsSource = produtoControle.LerTodos();
        }

       void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new ProdutoCadastroPage();
            page.produto = e.SelectedItem as Produtos;
            Application.Current.MainPage = page;
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProdutoCadastroPage();
        }
    }
}
