using Modelos;

namespace fluxograma
{
    public partial class FornecedorPage : ContentPage
    {
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        public FornecedorPage()
        {
            InitializeComponent();
            ListaClientes.ItemsSource = fornecedorControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new FornecedorCadastroPage();
            page.fornecedor = e.SelectedItem as Fornecedor;
            Application.Current.MainPage = page;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorCadastroPage();
        }
        private void ButtonUser(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UsuarioPage();
        }
        private void User(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UsuarioPage();
        }
    }
}