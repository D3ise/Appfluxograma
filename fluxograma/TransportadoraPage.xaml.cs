using Modelos;

namespace fluxograma
{
    public partial class TransportadoraPage : ContentPage
    {
        Controles.TransportadoraControle transportadoraControle = new Controles.TransportadoraControle();
        public TransportadoraPage()
        {
            InitializeComponent();
            ListaTransportadora.ItemsSource = transportadoraControle.LerTodos();
        }

         void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new TransportadoraCadastroPage();
            page.transportadora = e.SelectedItem as Transportadora;
            Application.Current.MainPage = page;
        }
        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TransportadoraCadastroPage();
        }
    }
}