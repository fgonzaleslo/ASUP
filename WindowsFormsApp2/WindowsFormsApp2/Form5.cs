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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2SJEGK1;Initial Catalog=ASUP_BD_TEST;Integrated Security=True");

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet9.Lista_estudiante_matricula' Puede moverla o quitarla según sea necesario.
            this.lista_estudiante_matriculaTableAdapter.Fill(this.aSUP_BD_TESTDataSet9.Lista_estudiante_matricula);
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet7.Lista_docente_matricula' Puede moverla o quitarla según sea necesario.
            this.lista_docente_matriculaTableAdapter.Fill(this.aSUP_BD_TESTDataSet7.Lista_docente_matricula);
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet6.Lista_curso_matricula' Puede moverla o quitarla según sea necesario.
            this.lista_curso_matriculaTableAdapter.Fill(this.aSUP_BD_TESTDataSet6.Lista_curso_matricula);
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet5.Lista_matricula_ASUP' Puede moverla o quitarla según sea necesario.
            this.lista_matricula_ASUPTableAdapter.Fill(this.aSUP_BD_TESTDataSet5.Lista_matricula_ASUP);
            GetListaMatricula();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matriculaid = textBox1.Text;
            string matricularesponsable = textBox2.Text;
            string matriculamodalidad = comboBox1.Text;
            string cicloacademico = textBox3.Text;
            string cursoid = textBox4.Text;
            string docenteid = textBox5.Text;
            DateTime matriculafecha = DateTime.Parse(dateTimePicker1.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec Insertar_matricula_ASUP '" + matriculaid + "','" + matricularesponsable + "','" + matriculafecha + "','" + matriculamodalidad + "','" + cicloacademico + "','" + cursoid + "','" + docenteid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Matricula exitosa");
            GetListaMatricula();
        }

        void GetListaMatricula()
        {
            SqlCommand c = new SqlCommand("exec Lista_matricula_ASUP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
