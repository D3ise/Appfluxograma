using fluxograma;

namespace Fluxograma
{
    public partial class Cliente : ContentPage
    {
        public Cliente()
        {
            InitializeComponent();
        }
         private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
