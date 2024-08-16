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
                TelefoneEntry.Text = fornecedor.Telefone;
                CpfEntry.Text = fornecedor.Cpf;
                EmailEntry.Text = fornecedor.Email;
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {

            var fornecedor = new Modelos.Fornecedor();

            fornecedor.Id = 0;
            fornecedor.Nome = NomeEntry.Text;
            //fornecedor.Sobrenome = SobrenomeEntry.Text;
            fornecedor.Telefone = TelefoneEntry.Text;
            fornecedor.Cpf = CpfEntry.Text;
            fornecedor.Email = EmailEntry.Text;

            fornecedorControle.CriarOuAtualizar(fornecedor);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert ("APAGAR" , "Certeza que deseja apagar este usuário?" , "SIM" , "NÃO"); 
          // if (resp == "SIM")
           {

           }
        }
    }
}