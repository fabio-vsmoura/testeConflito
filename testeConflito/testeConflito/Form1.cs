namespace testeConflito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Lendy";
            MessageBox.Show("Bem-vindo ao GIT HUB");
            MessageBox.Show($"Olá {nome}");
        }
    }
}
