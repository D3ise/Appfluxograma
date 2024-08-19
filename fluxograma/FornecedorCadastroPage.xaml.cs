using Controles;
using Modelos;

namespace fluxograma
{
    public partial class FornecedorCadastroPage : ContentPage
    {
        public Fornecedor fornecedor { get; set; }
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        public FornecedorCadastroPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (fornecedor != null)
            {
                NomeEntry.Text = fornecedor.Nome;
                SobrenomeEntry.Text = fornecedor.Sobrenome;
                TelefoneEntry.Text = fornecedor.Telefone;
                CpfEntry.Text = fornecedor.Cpf;
                EmailEntry.Text = fornecedor.Email;
                LabelId.Text = fornecedor.Id.ToString();

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
            if (await VerificaDados())
            {
                var fornecedor = new Modelos.Fornecedor();

                fornecedor.Id = 0;
                fornecedor.Nome = NomeEntry.Text;
                fornecedor.Sobrenome = SobrenomeEntry.Text;
                fornecedor.Telefone = TelefoneEntry.Text;
                fornecedor.Cpf = CpfEntry.Text;
                fornecedor.Email = EmailEntry.Text;

                fornecedorControle.CriarOuAtualizar(fornecedor);

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
            Application.Current.MainPage = new FornecedorPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                fornecedorControle.Apagar(fornecedor.Id);
                Application.Current.MainPage = new FornecedorPage();
            }
        }
    }
}