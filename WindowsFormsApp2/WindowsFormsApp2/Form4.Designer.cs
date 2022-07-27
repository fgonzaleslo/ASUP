namespace WindowsFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aSUP_BD_TESTDataSet4 = new WindowsFormsApp2.ASUP_BD_TESTDataSet4();
            this.listacursoASUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_curso_ASUPTableAdapter = new WindowsFormsApp2.ASUP_BD_TESTDataSet4TableAdapters.Lista_curso_ASUPTableAdapter();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horariocursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidodocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aSUP_BD_TESTDataSet8 = new WindowsFormsApp2.ASUP_BD_TESTDataSet8();
            this.listadocentematriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_docente_matriculaTableAdapter = new WindowsFormsApp2.ASUP_BD_TESTDataSet8TableAdapters.Lista_docente_matriculaTableAdapter();
            this.iddocenteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSUP_BD_TESTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listacursoASUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSUP_BD_TESTDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadocentematriculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURSO ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CURSO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HORARIO ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID DOCENTE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(563, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcursoDataGridViewTextBoxColumn,
            this.nombrecursoDataGridViewTextBoxColumn,
            this.horariocursoDataGridViewTextBoxColumn,
            this.iddocenteDataGridViewTextBoxColumn,
            this.nombredocenteDataGridViewTextBoxColumn,
            this.apellidodocenteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listacursoASUPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 143);
            this.dataGridView1.TabIndex = 12;
            // 
            // aSUP_BD_TESTDataSet4
            // 
            this.aSUP_BD_TESTDataSet4.DataSetName = "ASUP_BD_TESTDataSet4";
            this.aSUP_BD_TESTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listacursoASUPBindingSource
            // 
            this.listacursoASUPBindingSource.DataMember = "Lista_curso_ASUP";
            this.listacursoASUPBindingSource.DataSource = this.aSUP_BD_TESTDataSet4;
            // 
            // lista_curso_ASUPTableAdapter
            // 
            this.lista_curso_ASUPTableAdapter.ClearBeforeFill = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // nombrecursoDataGridViewTextBoxColumn
            // 
            this.nombrecursoDataGridViewTextBoxColumn.DataPropertyName = "nombre_curso";
            this.nombrecursoDataGridViewTextBoxColumn.HeaderText = "nombre_curso";
            this.nombrecursoDataGridViewTextBoxColumn.Name = "nombrecursoDataGridViewTextBoxColumn";
            // 
            // horariocursoDataGridViewTextBoxColumn
            // 
            this.horariocursoDataGridViewTextBoxColumn.DataPropertyName = "horario_curso";
            this.horariocursoDataGridViewTextBoxColumn.HeaderText = "horario_curso";
            this.horariocursoDataGridViewTextBoxColumn.Name = "horariocursoDataGridViewTextBoxColumn";
            // 
            // iddocenteDataGridViewTextBoxColumn
            // 
            this.iddocenteDataGridViewTextBoxColumn.DataPropertyName = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn.HeaderText = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn.Name = "iddocenteDataGridViewTextBoxColumn";
            // 
            // nombredocenteDataGridViewTextBoxColumn
            // 
            this.nombredocenteDataGridViewTextBoxColumn.DataPropertyName = "nombre_docente";
            this.nombredocenteDataGridViewTextBoxColumn.HeaderText = "nombre_docente";
            this.nombredocenteDataGridViewTextBoxColumn.Name = "nombredocenteDataGridViewTextBoxColumn";
            // 
            // apellidodocenteDataGridViewTextBoxColumn
            // 
            this.apellidodocenteDataGridViewTextBoxColumn.DataPropertyName = "apellido_docente";
            this.apellidodocenteDataGridViewTextBoxColumn.HeaderText = "apellido_docente";
            this.apellidodocenteDataGridViewTextBoxColumn.Name = "apellidodocenteDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddocenteDataGridViewTextBoxColumn1,
            this.docenteDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.listadocentematriculaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(465, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(330, 150);
            this.dataGridView2.TabIndex = 13;
            // 
            // aSUP_BD_TESTDataSet8
            // 
            this.aSUP_BD_TESTDataSet8.DataSetName = "ASUP_BD_TESTDataSet8";
            this.aSUP_BD_TESTDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadocentematriculaBindingSource
            // 
            this.listadocentematriculaBindingSource.DataMember = "Lista_docente_matricula";
            this.listadocentematriculaBindingSource.DataSource = this.aSUP_BD_TESTDataSet8;
            // 
            // lista_docente_matriculaTableAdapter
            // 
            this.lista_docente_matriculaTableAdapter.ClearBeforeFill = true;
            // 
            // iddocenteDataGridViewTextBoxColumn1
            // 
            this.iddocenteDataGridViewTextBoxColumn1.DataPropertyName = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn1.HeaderText = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn1.Name = "iddocenteDataGridViewTextBoxColumn1";
            // 
            // docenteDataGridViewTextBoxColumn
            // 
            this.docenteDataGridViewTextBoxColumn.DataPropertyName = "docente";
            this.docenteDataGridViewTextBoxColumn.HeaderText = "docente";
            this.docenteDataGridViewTextBoxColumn.Name = "docenteDataGridViewTextBoxColumn";
            this.docenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 104);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSUP_BD_TESTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listacursoASUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSUP_BD_TESTDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadocentematriculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ASUP_BD_TESTDataSet4 aSUP_BD_TESTDataSet4;
        private System.Windows.Forms.BindingSource listacursoASUPBindingSource;
        private ASUP_BD_TESTDataSet4TableAdapters.Lista_curso_ASUPTableAdapter lista_curso_ASUPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariocursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidodocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ASUP_BD_TESTDataSet8 aSUP_BD_TESTDataSet8;
        private System.Windows.Forms.BindingSource listadocentematriculaBindingSource;
        private ASUP_BD_TESTDataSet8TableAdapters.Lista_docente_matriculaTableAdapter lista_docente_matriculaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocenteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn docenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}