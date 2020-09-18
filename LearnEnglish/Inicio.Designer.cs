namespace LearnEnglish
{
    partial class Inicioform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jugamos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LearnEnglish.Properties.Resources.otrofondo;
            this.panel1.Controls.Add(this.Jugamos);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 627);
            this.panel1.TabIndex = 0;
            // 
            // Jugamos
            // 
            this.Jugamos.Location = new System.Drawing.Point(464, 308);
            this.Jugamos.Name = "Jugamos";
            this.Jugamos.Size = new System.Drawing.Size(149, 44);
            this.Jugamos.TabIndex = 0;
            this.Jugamos.Text = "Jugar";
            this.Jugamos.UseVisualStyleBackColor = true;
            this.Jugamos.Click += new System.EventHandler(this.Jugamos_Click);
            // 
            // Inicioform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 612);
            this.Controls.Add(this.panel1);
            this.Name = "Inicioform";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Jugamos;
    }
}

