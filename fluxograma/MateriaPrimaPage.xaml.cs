using Modelos;


namespace fluxograma
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public Materia materia { get; set; }
        Controles.MateriaControle materiaControle = new Controles.MateriaControle();

        public MateriaPrimaPage()
        {
            InitializeComponent();
            ListaMateria.ItemsSource = materiaControle.LerTodos();
        }

        void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new MateriaPrimaCadastroPage();
            page.materia = e.SelectedItem as Materia;
            Application.Current.MainPage = page;
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MateriaPrimaCadastroPage();
        }



}
}
    


