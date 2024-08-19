namespace fluxograma
{
    public partial class ClienteCadastro : ContentPage
    {
        public ClientePage cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public ClienteCadastro()
        {
            InitializeComponent();
        }
         async void Button_Clicked(object sender, EventArgs args)
        {
            {
            var cliente = new Modelos.Cliente();

            cliente.Id      = 0;
            cliente.Nome      = NomeEntry.Text;
            //cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone  = TelefoneEntry.Text;
             cliente.Cpf     = CpfEntry.Text;
             cliente.Email     = EmailEntry.Text;

            clienteControle.CriarOuAtualizar(cliente);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }
    }
}