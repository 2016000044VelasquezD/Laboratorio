namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // se crea una condicion para verificar si el usuario y
            // la contraseña son correctos
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                // Si está bien, abrir nueva ventana
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                // Si está mal, mostrar mensaje
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
