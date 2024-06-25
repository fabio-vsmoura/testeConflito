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
            string texto = "Vamos praticar mais";
            MessageBox.Show("Bem-vindo ao GIT HUB");
            MessageBox.Show($"Ol� {nome}");
            MessageBox.Show("E ai " + texto);

        }
    }
}
