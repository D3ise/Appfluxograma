using Controles;
using Modelos;

namespace fluxograma
{
    public partial class EstoquesCadastroPage : ContentPage
    {

         public Estoque estoque { get; set; }
        Controles.EstoqueControle estoqueControle = new Controles.EstoqueControle();

        public EstoquesCadastroPage()
        {
            InitializeComponent();  
        }
    protected override void OnAppearing()
        {
            base.OnAppearing();
            if (estoque != null)
            {
                ProdutoEntry.Text = estoque.Produto;
                QuantidadeEntry.Text = estoque.Quantidade.ToString();
                LabelId.Text = estoque.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var estoque = new Modelos.Estoque();

                estoque.Id = 0;
                estoque.Produto = ProdutoEntry.Text;
                estoque.Quantidade = int.Parse(QuantidadeEntry.Text);

                estoqueControle.CriarOuAtualizar(estoque);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
        }
       }

        private async Task<bool> VerificaDados()
        {
            if (String.IsNullOrEmpty(ProdutoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
             if (String.IsNullOrEmpty(QuantidadeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquesPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
             if (estoque != null)
            {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar?", "SIM", "NÃO");
            if (resp)
            {
                estoqueControle.Apagar(estoque.Id);
                Application.Current.MainPage = new EstoquesPage();
            }
            }
        }
       
    }

}