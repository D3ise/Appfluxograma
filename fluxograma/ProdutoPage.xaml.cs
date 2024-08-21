using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class ProdutoPage : ContentPage
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }

        // Método para excluir um produto
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var grid = button.Parent as Grid;
            var row = Grid.GetRow(button);

            grid.RowDefinitions.RemoveAt(grid.RowDefinitions.Count - 1);
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
    }
}
