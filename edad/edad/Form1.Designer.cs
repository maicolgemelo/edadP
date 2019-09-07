namespace edad
{
    partial class Form1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbleres = new System.Windows.Forms.Label();
            this.lblmaymen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(463, 159);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(102, 27);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(351, 26);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(65, 24);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "EDAD";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(160, 159);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(135, 19);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "ingrese su edad :";
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(313, 162);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(113, 24);
            this.txtedad.TabIndex = 3;
            // 
            // lbleres
            // 
            this.lbleres.AutoSize = true;
            this.lbleres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleres.Location = new System.Drawing.Point(220, 252);
            this.lbleres.Name = "lbleres";
            this.lbleres.Size = new System.Drawing.Size(75, 18);
            this.lbleres.TabIndex = 4;
            this.lbleres.Text = "Tu eres :";
            // 
            // lblmaymen
            // 
            this.lblmaymen.AutoSize = true;
            this.lblmaymen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaymen.Location = new System.Drawing.Point(310, 252);
            this.lblmaymen.Name = "lblmaymen";
            this.lblmaymen.Size = new System.Drawing.Size(91, 18);
            this.lblmaymen.TabIndex = 5;
            this.lblmaymen.Text = "may o men";
            this.lblmaymen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmaymen);
            this.Controls.Add(this.lbleres);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbleres;
        private System.Windows.Forms.Label lblmaymen;
    }
}

