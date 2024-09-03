using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class ComprasPage : ContentPage
    {

        public ComprasPage()
        {
            InitializeComponent();  
        }

          private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquePage();
        }
       
    }

}
