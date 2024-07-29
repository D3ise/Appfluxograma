using System;
using Microsoft.Maui.Controls;

namespace Fluxograma
{
    public partial class ClienteEditar : ContentPage
    {
        public ClienteEditar()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nome = entryNome.Text;
            string telefone = entryTelefone.Text;
            string endereco = entryEndereco.Text;
            string email = entryEmail.Text;

            DisplayAlert("Sucesso", "Perfil atualizado com sucesso!", "OK");
        }
    }
}
