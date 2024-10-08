using Microsoft.Maui.Controls;
using Modelos;

namespace fluxograma
{
    public partial class ComprasPage : ContentPage
    {

        public Compras compras { get; set; }
        Controles.ComprasControle comprasControle = new Controles.ComprasControle();

        public ComprasPage()
        {
            InitializeComponent(); 
            ListaCompra.ItemsSource = comprasControle.LerTodos(); 
        }

        void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CompraCadastroPage();
            page.compras = e.SelectedItem as Compras;
            Application.Current.MainPage = page;
        }

          private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquePage();
        }

         private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CompraCadastroPage();
        }
       
    }

}
