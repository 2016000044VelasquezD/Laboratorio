using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String Nom, Ape, Cla, Gra, Secc, Direc, Celu, NDM, CAA, Cumple, EA;
        // Declaracion de variables 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nom = textBox13.Text;  // Asigna el texto de textBox13 a la variable Nom
            Ape = textBox12.Text;  // Asigna el texto de textBox12 a la variable Ape
            Cla = textBox3.Text;   // Asigna el texto de textBox3 a la variable Cla
            Gra = textBox4.Text;    // Asigna el texto de textBox4 a la variable Gra
            Secc = textBox5.Text;   // Asigna el texto de textBox5 a la variable Secc
            Direc = textBox6.Text;  // Asigna el texto de textBox6 a la variable Dirrec
            Celu = textBox7.Text;   // Asigna el texto de textBox7 a la variable Celu
            NDM = textBox8.Text;   // Asigna el texto de textBox8 a la variable NDM
            CAA = textBox9.Text;  // Asigna el texto de textBox9 a la variable CAA
            Cumple = textBox10.Text;  // Asigna el texto de textBox10 a la variable Cumple
            EA = textBox11.Text;   // Asigna el texto de textBox11 a la variable EA

            dataGridView1.Rows.Add(Cla, Nom, Ape, Gra, Secc, Direc, Celu, NDM, CAA, Cumple, EA);
            // Agrega una nueva fila al DataGridView con los valores de las variables
            textBox13.Text = "";
            // Limpia el contenido de textBox13
            textBox12.Text = "";
            // Limpia el contenido de textBox12
            textBox3.Text = "";
            // Limpia el contenido de textBox3
            textBox4.Text = "";
            // Limpia el contenido de textBox4
            textBox5.Text = "";
            // Limpia el contenido de textBox5
            textBox6.Text = "";
            // Limpia el contenido de textBox6
            textBox7.Text = "";
            // Limpia el contenido de textBox7
            textBox8.Text = "";
            // Limpia el contenido de textBox8
            textBox9.Text = "";
            // Limpia el contenido de textBox9
            textBox10.Text = "";
            // Limpia el contenido de textBox10
            textBox11.Text = "";
            // Limpia el contenido de textBox11
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox13
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox11
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox3
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox4
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox5
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox6
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox7
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox8
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox9
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox10
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            // Asigna el valor de la celda seleccionada a textBox11
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value = textBox3.Text;
            // Asigna el valor de textBox13 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[1].Value = textBox13.Text;
            // Asigna el valor de textBox12 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[2].Value = textBox12.Text;
            // Asigna el valor de textBox3 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            // Asigna el valor de textBox4 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            // Asigna el valor de textBox5 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
            // Asigna el valor de textBox6 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
            // Asigna el valor de textBox7 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
            // Asigna el valor de textBox8 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
            // Asigna el valor de textBox9 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
            // Asigna el valor de textBox10 a la celda seleccionada
            dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
            // Asigna el valor de textBox11 a la celda seleccionada
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            // Elimina la fila seleccionada en el DataGridView
            textBox13.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // sirve para ir a otro formulario
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
