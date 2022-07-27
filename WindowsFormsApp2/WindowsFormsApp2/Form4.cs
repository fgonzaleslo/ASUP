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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2SJEGK1;Initial Catalog=ASUP_BD_TEST;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet8.Lista_docente_matricula' Puede moverla o quitarla según sea necesario.
            this.lista_docente_matriculaTableAdapter.Fill(this.aSUP_BD_TESTDataSet8.Lista_docente_matricula);
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet4.Lista_curso_ASUP' Puede moverla o quitarla según sea necesario.
            this.lista_curso_ASUPTableAdapter.Fill(this.aSUP_BD_TESTDataSet4.Lista_curso_ASUP);
            GetListaCurso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cursoid = textBox1.Text;
            string nombrecurso = textBox2.Text;
            string horariocurso = textBox3.Text;
            string docenteid = textBox4.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec Insertar_curso_ASUP '" + cursoid + "','" + nombrecurso + "','" + horariocurso + "','" + docenteid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Insertado Correctamente");
            GetListaCurso();
        }

        void GetListaCurso()
        {
            SqlCommand c = new SqlCommand("exec Lista_curso_ASUP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cursoid = textBox1.Text;
            string nombrecurso = textBox2.Text;
            string horariocurso = textBox3.Text;
            string docenteid = textBox4.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec Insertar_curso_ASUP '" + cursoid + "','" + nombrecurso + "','" + horariocurso + "','" + docenteid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Insertado Correctamente");
            GetListaCurso();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
