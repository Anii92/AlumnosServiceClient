namespace Vueling.Presentation
{
    partial class dataGridAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAll = new System.Windows.Forms.Button();
            this.dataGridListadoAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(26, 207);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 33);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dataGridListadoAlumnos
            // 
            this.dataGridListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListadoAlumnos.Location = new System.Drawing.Point(26, 26);
            this.dataGridListadoAlumnos.Name = "dataGridListadoAlumnos";
            this.dataGridListadoAlumnos.RowTemplate.Height = 28;
            this.dataGridListadoAlumnos.Size = new System.Drawing.Size(704, 150);
            this.dataGridListadoAlumnos.TabIndex = 2;
            // 
            // dataGridAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridListadoAlumnos);
            this.Controls.Add(this.btnAll);
            this.Name = "dataGridAlumnos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dataGridListadoAlumnos;
    }
}

