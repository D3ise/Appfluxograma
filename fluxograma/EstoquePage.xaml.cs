using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class EstoquePage : ContentPage
    {
        public EstoquePage()
        {
            InitializeComponent();
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Compra(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ComprasPage();
        }

        private void Envios(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnviosPage();
        }
         private void Estoque(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquesPage();
        }
    }
}
