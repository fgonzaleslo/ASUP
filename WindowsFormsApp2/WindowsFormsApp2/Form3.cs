using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2SJEGK1;Initial Catalog=ASUP_BD_TEST;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet3.Lista_docente_ASUP_test' Puede moverla o quitarla según sea necesario.
            this.lista_docente_ASUP_testTableAdapter.Fill(this.aSUP_BD_TESTDataSet3.Lista_docente_ASUP_test);
            GetListaDocente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docenteid = textBox1.Text;
            string nombredoc = textBox2.Text;
            string apellidodoc = textBox3.Text;
            string direcdoc = textBox4.Text, sex = "";
            string contacdoc = textBox5.Text;
            DateTime fecnacdoc = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { sex = "Masculino"; } else { sex = "Femenino"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec dbo.Insertar_docente_ASUP_test '" + docenteid + "','" + nombredoc + "','" + apellidodoc + "','" + direcdoc + "','" + sex + "','" + fecnacdoc + "','" + contacdoc + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Insertado Correctamente");
            GetListaDocente();
            con.Close();
        }

        void GetListaDocente()
        {
            SqlCommand c = new SqlCommand("exec dbo.Lista_docente_ASUP_test", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string docenteid = textBox1.Text;
            string nombredoc = textBox2.Text;
            string apellidodoc = textBox3.Text;
            string direcdoc = textBox4.Text, sex = "";
            string contacdoc = textBox5.Text;
            DateTime fecnacdoc = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { sex = "Masculino"; } else { sex = "Femenino"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec dbo.Editar_docente_ASUP_test '" + docenteid + "','" + nombredoc + "','" + apellidodoc + "','" + direcdoc + "','" + sex + "','" + fecnacdoc + "','" + contacdoc + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado Correctamente");
            GetListaDocente();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿De acuerdo con eliminar?", "Eliminar docente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string docenteid = textBox1.Text;
                con.Open();
                SqlCommand c = new SqlCommand("exec dbo.Eliminar_docente_ASUP_test '" + docenteid + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado Correctamente");
                GetListaDocente();
                con.Close();
            }
        }
    }
}
