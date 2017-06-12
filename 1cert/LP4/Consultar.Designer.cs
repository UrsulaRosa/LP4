namespace LP4
{
    partial class Consultar
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListView();
            this.Treino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minutos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intensidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.checknome = new System.Windows.Forms.CheckBox();
            this.checkminutos = new System.Windows.Forms.CheckBox();
            this.checknivel = new System.Windows.Forms.CheckBox();
            this.checkintensidade = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnconsultar.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(828, 25);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // Lista
            // 
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Treino,
            this.Minutos,
            this.Nivel,
            this.Intensidade});
            this.Lista.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.GridLines = true;
            this.Lista.Location = new System.Drawing.Point(90, 87);
            this.Lista.MultiSelect = false;
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(752, 367);
            this.Lista.TabIndex = 1;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            // 
            // Treino
            // 
            this.Treino.Text = "Treino";
            this.Treino.Width = 400;
            // 
            // Minutos
            // 
            this.Minutos.Text = "Minutos";
            this.Minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Minutos.Width = 100;
            // 
            // Nivel
            // 
            this.Nivel.Text = "Nível";
            this.Nivel.Width = 150;
            // 
            // Intensidade
            // 
            this.Intensidade.Text = "Intensidade";
            this.Intensidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Intensidade.Width = 100;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(522, 25);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(282, 20);
            this.txtConsulta.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(34, 22);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(90, 19);
            this.nome.TabIndex = 3;
            this.nome.Text = "Pesquisar por:";
            // 
            // checknome
            // 
            this.checknome.AutoSize = true;
            this.checknome.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknome.Location = new System.Drawing.Point(130, 25);
            this.checknome.Name = "checknome";
            this.checknome.Size = new System.Drawing.Size(63, 23);
            this.checknome.TabIndex = 7;
            this.checknome.Text = "Nome";
            this.checknome.UseVisualStyleBackColor = true;
            // 
            // checkminutos
            // 
            this.checkminutos.AutoSize = true;
            this.checkminutos.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkminutos.Location = new System.Drawing.Point(216, 25);
            this.checkminutos.Name = "checkminutos";
            this.checkminutos.Size = new System.Drawing.Size(74, 23);
            this.checkminutos.TabIndex = 8;
            this.checkminutos.Text = "Minutos";
            this.checkminutos.UseVisualStyleBackColor = true;
            // 
            // checknivel
            // 
            this.checknivel.AutoSize = true;
            this.checknivel.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknivel.Location = new System.Drawing.Point(302, 24);
            this.checknivel.Name = "checknivel";
            this.checknivel.Size = new System.Drawing.Size(58, 23);
            this.checknivel.TabIndex = 9;
            this.checknivel.Text = "Nível";
            this.checknivel.UseVisualStyleBackColor = true;
            // 
            // checkintensidade
            // 
            this.checkintensidade.AutoSize = true;
            this.checkintensidade.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkintensidade.Location = new System.Drawing.Point(390, 26);
            this.checkintensidade.Name = "checkintensidade";
            this.checkintensidade.Size = new System.Drawing.Size(95, 23);
            this.checkintensidade.TabIndex = 10;
            this.checkintensidade.Text = "Intensidade";
            this.checkintensidade.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(952, 466);
            this.Controls.Add(this.checkintensidade);
            this.Controls.Add(this.checknivel);
            this.Controls.Add(this.checkminutos);
            this.Controls.Add(this.checknome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnconsultar);
            this.Name = "Consultar";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.ColumnHeader Nivel;
        private System.Windows.Forms.ColumnHeader Intensidade;
        public System.Windows.Forms.ColumnHeader Treino;
        public System.Windows.Forms.ColumnHeader Minutos;
        private System.Windows.Forms.CheckBox checknome;
        private System.Windows.Forms.CheckBox checkminutos;
        private System.Windows.Forms.CheckBox checknivel;
        private System.Windows.Forms.CheckBox checkintensidade;
    }
}