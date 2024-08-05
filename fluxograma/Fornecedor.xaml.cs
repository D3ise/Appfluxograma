namespace fluxograma
{
    public partial class Fornecedor : ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
         private void ButtonUser(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Usuário();
        }
        private void User(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Usuário();
        }
    }
}