using Controles;
using Modelos;


namespace fluxograma
{
    public partial class ProdutoCadastroPage : ContentPage
    {
       public Produtos produto { get; set; }
        Controles.ProdutosControle produtoControle = new Controles.ProdutosControle();

        public ProdutoCadastroPage()
        {
            InitializeComponent();
        }

                protected override void OnAppearing()
        {
            base.OnAppearing();
            if (produto != null)
            {
                NomeEntry.Text = produto.Nome;
                ValorEntry.Text = produto.Valor.ToString();
                //UnidadeEntry.Text = produto.Unidade.ToString();
                LabelId.Text = produto.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var produto = new Modelos.Produtos();

                produto.Id = 0;
                produto.Nome = NomeEntry.Text;
                produto.Valor = int.Parse(ValorEntry.Text);
                //produto.Unidade = UnidadeEntry.Text;

                produtoControle.CriarOuAtualizar(produto);

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
            else if (String.IsNullOrEmpty(ValorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Preço é obrigatório", "OK");
                return false;
            }
            
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProdutoPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                produtoControle.Apagar(produto.Id);
                Application.Current.MainPage = new MateriaPrimaPage();
            }
        }
    }
}