using Controles;
using Modelos;

namespace fluxograma
{
    public partial class ClienteCadastroPage : ContentPage
    {
        public Cliente cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public ClienteCadastroPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (cliente != null)
            {
                NomeEntry.Text = cliente.Nome;
                SobrenomeEntry.Text = cliente.Sobrenome;
                TelefoneEntry.Text = cliente.Telefone;
                CpfEntry.Text = cliente.Cpf;
                EmailEntry.Text = cliente.Email;
                LabelId.Text = cliente.Id.ToString();

            }
        }

         async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
            {
            var cliente = new Modelos.Cliente();

            cliente.Id      = 0;
            cliente.Nome      = NomeEntry.Text;
            cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone  = TelefoneEntry.Text;
             cliente.Cpf     = CpfEntry.Text;
             cliente.Email     = EmailEntry.Text;

            clienteControle.CriarOuAtualizar(cliente);

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
            else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
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
            else if (String.IsNullOrEmpty(CpfEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClientePage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)

        {
            if (cliente != null)
            {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                clienteControle.Apagar(cliente.Id);
                Application.Current.MainPage = new ClientePage();
            }
            }
        }
    }
}
    
