using Controles;
using Modelos;


namespace fluxograma
{
    public partial class MateriaPrimaCadastroPage : ContentPage
    {
        public Materia materia { get; set; }
        Controles.MateriaControle materiaControle = new Controles.MateriaControle();

        public MateriaPrimaCadastroPage()
        {
            InitializeComponent();
        }

                protected override void OnAppearing()
        {
            base.OnAppearing();
            if (materia != null)
            {
                NomeEntry.Text = materia.Nome;
                //ValorEntry.Text = materia.Valor;
                UnidadeEntry.Text = materia.Unidade;
                LabelId.Text = materia.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var materia = new Modelos.Materia();

                materia.Id = 0;
                materia.Nome = NomeEntry.Text;
                //materia.Valor = ValorEntry.Text;
                materia.Unidade = UnidadeEntry.Text;

                materiaControle.CriarOuAtualizar(materia);

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
            else if (String.IsNullOrEmpty(UnidadeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Unidade é obrigatório", "OK");
                return false;
            }
            
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MateriaPrimaPage();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                materiaControle.Apagar(materia.Id);
                Application.Current.MainPage = new MateriaPrimaPage();
            }
        }
    }
}





    
