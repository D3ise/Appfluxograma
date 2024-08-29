using Modelos;

namespace fluxograma
{
    public partial class FuncionarioPage : ContentPage
    {
        Controles.FuncionariosControle funcionariosControle = new Controles.FuncionariosControle();
        public FuncionarioPage()
        {
            InitializeComponent();
            ListaFuncionarios.ItemsSource = funcionariosControle.LerTodos();
        }

         void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new FuncionarioCadastroPage();
            page.funcionarios = e.SelectedItem as Funcionarios;
            Application.Current.MainPage = page;
        }
        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FuncionarioCadastroPage();
        }
    }
}