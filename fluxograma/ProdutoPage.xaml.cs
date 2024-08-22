using Controles;
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
        }

        // Método para excluir um produto
       async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                produtoControle.Apagar(produto.Id);
                Application.Current.MainPage = new ProdutoPage();
            }
        }

        // Método para adicionar um novo produto
        private void OnAddProductButtonClicked(object sender, EventArgs e)
        {
            var grid = this.FindByName<Grid>("ProductGrid");
            var row = grid.RowDefinitions.Count;

            // Adiciona uma nova linha na Grid
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            // Exemplo de novo produto
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
