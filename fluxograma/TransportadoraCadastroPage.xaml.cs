using Controles;
using Modelos;

namespace fluxograma
{
    public partial class TransportadoraCadastroPage : ContentPage
    {
        public Transportadora transportadora { get; set; }
        Controles.TransportadoraControle transportadoraControle = new Controles.TransportadoraControle();
        public TransportadoraCadastroPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (transportadora != null)
            {
                NomeEntry.Text = transportadora.Nome;
                TelefoneEntry.Text = transportadora.Telefone;
                EmailEntry.Text = transportadora.Email;
                LabelId.Text = transportadora.Id.ToString();

            }
        }

         async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
            {
            var transportadora = new Modelos.Transportadora();

            transportadora.Id      = 0;
            transportadora.Nome      = NomeEntry.Text;
            transportadora.Telefone  = TelefoneEntry.Text;
            transportadora.Email     = EmailEntry.Text;

            transportadoraControle.CriarOuAtualizar(transportadora);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

         private async Task<bool> VerificaDados()
        {
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EmailEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TransportadoraPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                transportadoraControle.Apagar(transportadora.Id);
                Application.Current.MainPage = new TransportadoraPage();
            }
        }
    }
}
    
