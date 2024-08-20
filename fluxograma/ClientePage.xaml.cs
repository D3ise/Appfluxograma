using Modelos;

namespace fluxograma
{
    public partial class ClientePage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public ClientePage()
        {
            InitializeComponent();
            ListaClientes.ItemsSource = clienteControle.LerTodos();
        }

         void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new ClienteCadastroPage();
            page.cliente = e.SelectedItem as Cliente;
            Application.Current.MainPage = page;
        }
        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClienteCadastroPage();
        }
    }
}
