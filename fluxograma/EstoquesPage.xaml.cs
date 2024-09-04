using Microsoft.Maui.Controls;
using Modelos;

namespace fluxograma
{
    public partial class EstoquesPage : ContentPage
    {

        public Estoque estoque { get; set; }
        Controles.EstoqueControle estoqueControle = new Controles.EstoqueControle();

        public EstoquesPage()
        {
            InitializeComponent(); 
            ListaEstoque.ItemsSource = estoqueControle.LerTodos(); 
        }

        void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new EstoquesCadastroPage();
            page.estoque = e.SelectedItem as Estoque;
            Application.Current.MainPage = page;
        }

          private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquePage();
        }

         private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquesCadastroPage();
        }
       
    }

}