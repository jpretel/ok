namespace Presentacion
{
    partial class LectorLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dpDesde = new System.Windows.Forms.DateTimePicker();
            this.dpHasta = new System.Windows.Forms.DateTimePicker();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(458, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dpDesde
            // 
            this.dpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDesde.Location = new System.Drawing.Point(84, 19);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(96, 20);
            this.dpDesde.TabIndex = 3;
            // 
            // dpHasta
            // 
            this.dpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpHasta.Location = new System.Drawing.Point(275, 17);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(96, 20);
            this.dpHasta.TabIndex = 4;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToOrderColumns = true;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento});
            this.grdDatos.Location = new System.Drawing.Point(12, 48);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.Size = new System.Drawing.Size(521, 216);
            this.grdDatos.TabIndex = 5;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // LectorLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 276);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.dpHasta);
            this.Controls.Add(this.dpDesde);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LectorLista";
            this.Text = "LectorLista";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dpDesde;
        private System.Windows.Forms.DateTimePicker dpHasta;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
    }
}