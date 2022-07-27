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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2SJEGK1;Initial Catalog=ASUP_BD_TEST;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            int estudianteid = int.Parse(textBox1.Text);
            string nombreestu = textBox2.Text;
            string apellidoestu = textBox3.Text;
            string direcestu = textBox4.Text, sex = "";
            string contacestu = textBox5.Text;
            int estudiantecicloid = int.Parse(textBox6.Text);
            DateTime fecnacestu = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { sex = "Masculino"; } else { sex = "Femenino"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec dbo.Insertar_estudiante_ASUP '" + estudianteid + "','" + nombreestu + "','" + apellidoestu + "','" + direcestu + "','" + sex + "','" + fecnacestu + "','" + contacestu + "','" + estudiantecicloid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Insertado Correctamente");
            GetListaEstudiante();
            con.Close();
        }

        void GetListaEstudiante()
        {
            SqlCommand c = new SqlCommand("exec dbo.Lista_estudiante_ASUP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aSUP_BD_TESTDataSet2.GDI_ASUP_ESTUDIANTE' Puede moverla o quitarla según sea necesario.
            this.gDI_ASUP_ESTUDIANTETableAdapter.Fill(this.aSUP_BD_TESTDataSet2.GDI_ASUP_ESTUDIANTE);
            GetListaEstudiante();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int estudianteid = int.Parse(textBox1.Text);
            string nombreestu = textBox2.Text;
            string apellidoestu = textBox3.Text;
            string direcestu = textBox4.Text, sex = "";
            string contacestu = textBox5.Text;
            int estudiantecicloid = int.Parse(textBox6.Text);
            DateTime fecnacestu = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { sex = "Masculino"; } else { sex = "Femenino"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec dbo.Modificar_estudiante_ASUP '" + estudianteid + "','" + nombreestu + "','" + apellidoestu + "','" + direcestu + "','" + sex + "','" + fecnacestu + "','" + contacestu + "','" + estudiantecicloid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro modificado Correctamente");
            GetListaEstudiante();
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int estudianteid = int.Parse(textBox1.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec dbo.Eliminar_estudiante_ASUP '" + estudianteid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Correctamente");
            GetListaEstudiante();
            con.Close();
        }
    }
}
