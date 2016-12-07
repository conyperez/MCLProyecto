namespace MCLProyecto
{
    partial class RegistroProfesor
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
            this.textNombreP = new System.Windows.Forms.TextBox();
            this.textPaternoP = new System.Windows.Forms.TextBox();
            this.textMaternoP = new System.Windows.Forms.TextBox();
            this.textRutP = new System.Windows.Forms.TextBox();
            this.textClaveP = new System.Windows.Forms.TextBox();
            this.textClaveRepetir = new System.Windows.Forms.TextBox();
            this.tablaCursos = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombreP
            // 
            this.textNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombreP.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreP.Location = new System.Drawing.Point(436, 212);
            this.textNombreP.Name = "textNombreP";
            this.textNombreP.Size = new System.Drawing.Size(359, 37);
            this.textNombreP.TabIndex = 0;
            // 
            // textPaternoP
            // 
            this.textPaternoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPaternoP.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaternoP.Location = new System.Drawing.Point(436, 292);
            this.textPaternoP.Name = "textPaternoP";
            this.textPaternoP.Size = new System.Drawing.Size(360, 37);
            this.textPaternoP.TabIndex = 1;
            // 
            // textMaternoP
            // 
            this.textMaternoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMaternoP.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaternoP.Location = new System.Drawing.Point(436, 368);
            this.textMaternoP.Name = "textMaternoP";
            this.textMaternoP.Size = new System.Drawing.Size(361, 37);
            this.textMaternoP.TabIndex = 2;
            // 
            // textRutP
            // 
            this.textRutP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRutP.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRutP.Location = new System.Drawing.Point(1059, 211);
            this.textRutP.Name = "textRutP";
            this.textRutP.Size = new System.Drawing.Size(314, 37);
            this.textRutP.TabIndex = 3;
            // 
            // textClaveP
            // 
            this.textClaveP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClaveP.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClaveP.Location = new System.Drawing.Point(289, 449);
            this.textClaveP.Name = "textClaveP";
            this.textClaveP.Size = new System.Drawing.Size(272, 37);
            this.textClaveP.TabIndex = 4;
            this.textClaveP.UseSystemPasswordChar = true;
            // 
            // textClaveRepetir
            // 
            this.textClaveRepetir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClaveRepetir.Font = new System.Drawing.Font("Open Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClaveRepetir.Location = new System.Drawing.Point(1007, 449);
            this.textClaveRepetir.Name = "textClaveRepetir";
            this.textClaveRepetir.Size = new System.Drawing.Size(276, 37);
            this.textClaveRepetir.TabIndex = 5;
            this.textClaveRepetir.UseSystemPasswordChar = true;
            // 
            // tablaCursos
            // 
            this.tablaCursos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Letra,
            this.Año});
            this.tablaCursos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaCursos.Location = new System.Drawing.Point(111, 580);
            this.tablaCursos.Name = "tablaCursos";
            this.tablaCursos.RowTemplate.Height = 33;
            this.tablaCursos.Size = new System.Drawing.Size(610, 206);
            this.tablaCursos.TabIndex = 6;
            this.tablaCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Curso.HeaderText = "Curso";
            this.Curso.Items.AddRange(new object[] {
            "Quinto",
            "Sexto"});
            this.Curso.Name = "Curso";
            // 
            // Letra
            // 
            this.Letra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Letra.HeaderText = "Letra";
            this.Letra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I"});
            this.Letra.Name = "Letra";
            this.Letra.Width = 50;
            // 
            // Año
            // 
            this.Año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Año.HeaderText = "Año";
            this.Año.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Año.Name = "Año";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MCLProyecto.Properties.Resources.btn21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1166, 722);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 76);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1409, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 66);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(1340, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 60);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // RegistroProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCLProyecto.Properties.Resources.registroProfesor1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 824);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaCursos);
            this.Controls.Add(this.textClaveRepetir);
            this.Controls.Add(this.textClaveP);
            this.Controls.Add(this.textRutP);
            this.Controls.Add(this.textMaternoP);
            this.Controls.Add(this.textPaternoP);
            this.Controls.Add(this.textNombreP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreP;
        private System.Windows.Forms.TextBox textPaternoP;
        private System.Windows.Forms.TextBox textMaternoP;
        private System.Windows.Forms.TextBox textRutP;
        private System.Windows.Forms.TextBox textClaveP;
        private System.Windows.Forms.TextBox textClaveRepetir;
        private System.Windows.Forms.DataGridView tablaCursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Curso;
        private System.Windows.Forms.DataGridViewComboBoxColumn Letra;
        private System.Windows.Forms.DataGridViewComboBoxColumn Año;
    }
}