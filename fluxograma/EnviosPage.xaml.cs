using Microsoft.Maui.Controls;
using Modelos;

namespace fluxograma
{
    public partial class EnviosPage : ContentPage
    {

        public Envios envios { get; set; }
        Controles.EnviosControle enviosControle = new Controles.EnviosControle();

        public EnviosPage()
        {
            InitializeComponent(); 
            ListaEnvios.ItemsSource = enviosControle.LerTodos(); 
        }

        void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new EnviosCadastroPage();
            page.envios = e.SelectedItem as Envios;
            Application.Current.MainPage = page;
        }

          private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquePage();
        }

         private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnviosCadastroPage();
        }
       
    }

}