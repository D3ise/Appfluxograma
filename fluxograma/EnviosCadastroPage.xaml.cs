using Controles;
using Modelos;

namespace fluxograma
{
    public partial class EnviosCadastroPage : ContentPage
    {

         public Envios envios { get; set; }
        Controles.EnviosControle enviosControle = new Controles.EnviosControle();

        public EnviosCadastroPage()
        {
            InitializeComponent();  
        }
    protected override void OnAppearing()
        {
            base.OnAppearing();
            if (envios != null)
            {
                MateriaEntry.Text = envios.Matériaprima;
                QuantidadeEntry.Text = envios.Quantidade.ToString();
                FornecedorEntry.Text = envios.Fornecedor;
                LabelId.Text = envios.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var envios = new Modelos.Envios();

                envios.Id = 0;
                envios.Matériaprima = MateriaEntry.Text;
                envios.Quantidade = int.Parse(QuantidadeEntry.Text);
                envios.Fornecedor    = FornecedorEntry.Text;

                enviosControle.CriarOuAtualizar(envios);

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
            Application.Current.MainPage = new EnviosPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
             if (envios != null)
            {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar?", "SIM", "NÃO");
            if (resp)
            {
                enviosControle.Apagar(envios.Id);
                Application.Current.MainPage = new EnviosPage();
            }
            }
        }
       
    }

}