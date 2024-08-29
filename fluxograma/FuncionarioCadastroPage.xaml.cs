using Controles;
using Modelos;

namespace fluxograma
{
    public partial class FuncionarioCadastroPage : ContentPage
    {
        public Funcionarios funcionarios { get; set; }
       Controles.FuncionariosControle funcionariosControle = new Controles.FuncionariosControle();
        public FuncionarioCadastroPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (funcionarios != null)
            {
                NomeEntry.Text = funcionarios.Nome;
                SobrenomeEntry.Text = funcionarios.Sobrenome;
                TelefoneEntry.Text = funcionarios.Telefone;
                CpfEntry.Text = funcionarios.Cpf;
                EmailEntry.Text = funcionarios.Email;
                LabelId.Text = funcionarios.Id.ToString();

            }
        }

         async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
            {
            var funcionarios = new Modelos.Funcionarios();

            funcionarios.Id      = 0;
            funcionarios.Nome      = NomeEntry.Text;
            funcionarios.Sobrenome = SobrenomeEntry.Text;
            funcionarios.Telefone  = TelefoneEntry.Text;
            funcionarios.Cpf     = CpfEntry.Text;
            funcionarios.Email     = EmailEntry.Text;

            funcionariosControle.CriarOuAtualizar(funcionarios);

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
            Application.Current.MainPage = new FuncionarioPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                funcionariosControle.Apagar(funcionarios.Id);
                Application.Current.MainPage = new FuncionarioPage();
            }
        }
    }
}