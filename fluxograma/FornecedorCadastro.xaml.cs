using Controles;

namespace fluxograma
{
    public partial class FornecedorCadastro : ContentPage
    {
        public Fornecedor fornecedor { get; set; }
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        public FornecedorCadastro()
        {
            InitializeComponent();
        }
          async void Button(object sender, EventArgs args)
        {
            {
            var fornecedor = new Modelos.Fornecedor();

            fornecedor.Id      = 0;
            fornecedor.Nome      = NomeEntry.Text;
            //cliente.Sobrenome = SobrenomeEntry.Text;
            fornecedor.Telefone  = TelefoneEntry.Text;
            fornecedor.Cpf     = CpfEntry.Text;
            fornecedor.Email     = EmailEntry.Text;

            fornecedorControle.CriarOuAtualizar(fornecedor);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Fornecedor();
        }
    }
}