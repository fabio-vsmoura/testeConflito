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
            string texto = "Lendy";
            MessageBox.Show("Bem-vindo ao GIT HUB");
            MessageBox.Show("E ai " + texto);
        }
    }
}
