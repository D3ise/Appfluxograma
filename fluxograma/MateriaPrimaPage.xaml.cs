using System.Collections.ObjectModel;
using Controles;
using Modelos;


namespace fluxograma
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public Materia materia { get; set; }
        Controles.MateriaControle materiaControle = new Controles.MateriaControle();
        public ObservableCollection<Materia> MateriaPrimaItems { get; set; }

        public MateriaPrimaPage()
        {
            InitializeComponent();
            ListaClientes.ItemsSource = materiaControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new FornecedorCadastroPage();
            page.fornecedor = e.SelectedItem as Fornecedor;
            Application.Current.MainPage = page;
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            frameAdiciona.IsVisible = true;
        }

        private void OnAddConfirmClicked(object sender, EventArgs e)
        {
            frameConfirma.IsVisible = true;
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            frameAdiciona.IsVisible = false;
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
           frameApagado.IsVisible = true;
        }

        private void OnDeleteConfirmClicked(object sender, EventArgs e)
        {
            // Delete item logic
            frameApagado.IsVisible = true;
        }

        private void OnDeleteCancelClicked(object sender, EventArgs e)
        {
            frameSucesso.IsVisible = true;
        }

        private void OnSuccessOkClicked(object sender, EventArgs e)
        {
            frameSucesso.IsVisible = true;
        }

        private void OnDeleteSuccessOkClicked(object sender, EventArgs e)
        {
            frameApagar.IsVisible = true;
        }

        private void OnReplaceConfirmClicked(object sender, EventArgs e)
        {
            // Logic to replace existing item
        }

        private void OnReplaceCancelClicked(object sender, EventArgs e)
        {
           frameApagado.IsVisible = true;
        }
    

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (materia != null)
            {
                NomeEntry.Text = materia.Nome;
                //ValorEntry.Text = materia.Valor;
                EntryUnidade.Text = materia.Unidade.ToString();
                

            }
        }
        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
         {
                var materia = new Modelos.Materia();

                materia.Id = 0;
                materia.Nome = NomeEntry.Text;
                //materia.Valor = ValorEntry.Text;
                //materia.Unidade = EntryUnidade.Text;

                materiaControle.CriarOuAtualizar(materia);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
        }
       }

       void Adiciona(object sender, EventArgs args)
	   {
		  frameAdiciona.IsVisible = true;
	   }

       void Confirma(object sender, EventArgs args)
	   {
		  frameConfirma.IsVisible = true;
	   }

       void Sucesso(object sender, EventArgs args)
	   {
		  frameSucesso.IsVisible = true;
	   }

       void Apagar(object sender, EventArgs args)
	   {
		  frameApagar.IsVisible = true;
	   }

       void Apagado(object sender, EventArgs args)
	   {
		  frameApagado.IsVisible = true;
	   }

}
}
    


