using Controles;
using Modelos;

namespace fluxograma
{
    public partial class CompraCadastroPage : ContentPage
    {

         public Compras compras { get; set; }
        Controles.ComprasControle comprasControle = new Controles.ComprasControle();

        public CompraCadastroPage()
        {
            InitializeComponent();  
        }
    protected override void OnAppearing()
        {
            base.OnAppearing();
            if (compras != null)
            {
                MateriaEntry.Text = compras.Matériaprima;
                QuantidadeEntry.Text = compras.Quantidade.ToString();
                FornecedorEntry.Text = compras.Fornecedor;
                LabelId.Text = compras.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var compras = new Modelos.Compras();

                compras.Id = 0;
                compras.Matériaprima = MateriaEntry.Text;
                compras.Quantidade = int.Parse(QuantidadeEntry.Text);
                compras.Fornecedor    = FornecedorEntry.Text;

                comprasControle.CriarOuAtualizar(compras);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
        }
       }

        private async Task<bool> VerificaDados()
        {
            if (String.IsNullOrEmpty(MateriaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
             if (String.IsNullOrEmpty(QuantidadeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            if (String.IsNullOrEmpty(FornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ComprasPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
             if (compras != null)
            {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar?", "SIM", "NÃO");
            if (resp)
            {
                comprasControle.Apagar(compras.Id);
                Application.Current.MainPage = new ComprasPage();
            }
            }
        }
       
    }

}