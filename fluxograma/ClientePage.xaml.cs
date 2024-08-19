using fluxograma;

namespace fluxograma
{
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }
        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorCadastroPage();
        }
    }
}
