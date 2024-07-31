using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class Usuário : ContentPage
    {
        public Usuário()
        {
            InitializeComponent();
            // Initialize with actual user data
            UserNameLabel.Text = "Seu Nome";
            UserPhoneLabel.Text = "55 (99) 99999-9999";
            UserAddressLabel.Text = "Seu Endereço";
            UserEmailLabel.Text = "seuemail@dominio.com";
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete button click
            DisplayAlert("Delete", "Delete button clicked", "OK");
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FornecedorEditar();
        }

    }
}
