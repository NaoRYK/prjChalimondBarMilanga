namespace prjChalimondBarMilanga
{
    partial class frmVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            dgvDatos = new DataGridView();
            Comidas = new DataGridViewTextBoxColumn();
            BebidasSinAlcohol = new DataGridViewTextBoxColumn();
            BebidasConAlcohol = new DataGridViewTextBoxColumn();
            Postres = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMejorMozo = new Button();
            btnTotal = new Button();
            txtResultados = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Comidas, BebidasSinAlcohol, BebidasConAlcohol, Postres });
            dgvDatos.Location = new Point(12, 24);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(443, 172);
            dgvDatos.TabIndex = 0;
            // 
            // Comidas
            // 
            Comidas.HeaderText = "Comidas";
            Comidas.Name = "Comidas";
            // 
            // BebidasSinAlcohol
            // 
            BebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            BebidasSinAlcohol.Name = "BebidasSinAlcohol";
            // 
            // BebidasConAlcohol
            // 
            BebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            BebidasConAlcohol.Name = "BebidasConAlcohol";
            // 
            // Postres
            // 
            Postres.HeaderText = "Postres";
            Postres.Name = "Postres";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 212);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(443, 40);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMejorMozo
            // 
            btnMejorMozo.Location = new Point(12, 258);
            btnMejorMozo.Name = "btnMejorMozo";
            btnMejorMozo.Size = new Size(220, 45);
            btnMejorMozo.TabIndex = 2;
            btnMejorMozo.Text = "Mejor mozo";
            btnMejorMozo.UseVisualStyleBackColor = true;
            btnMejorMozo.Click += btnMejorMozo_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(238, 258);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(217, 45);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(12, 309);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(443, 150);
            txtResultados.TabIndex = 4;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 494);
            Controls.Add(txtResultados);
            Controls.Add(btnTotal);
            Controls.Add(btnMejorMozo);
            Controls.Add(btnValidar);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Comidas;
        private DataGridViewTextBoxColumn BebidasSinAlcohol;
        private DataGridViewTextBoxColumn BebidasConAlcohol;
        private DataGridViewTextBoxColumn Postres;
        private Button btnValidar;
        private Button btnMejorMozo;
        private Button btnTotal;
        private TextBox txtResultados;
    }
}
