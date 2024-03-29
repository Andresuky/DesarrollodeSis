namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Visible = true;

            // Enfoca el TextBox
            textBox2.Focus();
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            // Cuando el TextBox pierde el foco, oculta el TextBox y restaura el PasswordChar
            textBox2.Visible = false;
            textBox2.UseSystemPasswordChar = false;

            // Aqu� puedes realizar alguna acci�n adicional, si es necesario
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia de Form2
            Form2 form2 = new Form2();

            // Mostrar Form2
            form2.Show();

            // Opcionalmente, puedes cerrar el formulario actual si deseas
            // this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia de Form3
            Form3 form3 = new Form3();

            // Mostrar Form3
            form3.Show();

        }
    }
}
