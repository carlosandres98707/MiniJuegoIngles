namespace LearnEnglish
{
    partial class Pasado
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
            this.Presente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Español = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Empieza = new System.Windows.Forms.Button();
            this.Verifica = new System.Windows.Forms.Button();
            this.Otra = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.Punto = new System.Windows.Forms.Label();
            this.Pasadsimple = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juega Mucho";
            // 
            // Presente
            // 
            this.Presente.AutoSize = true;
            this.Presente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presente.Location = new System.Drawing.Point(187, 217);
            this.Presente.Name = "Presente";
            this.Presente.Size = new System.Drawing.Size(82, 25);
            this.Presente.TabIndex = 1;
            this.Presente.Text = "----------";
            this.Presente.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasado Simple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Presente Simple";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Español";
            // 
            // Español
            // 
            this.Español.AutoSize = true;
            this.Español.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Español.Location = new System.Drawing.Point(748, 217);
            this.Español.Name = "Español";
            this.Español.Size = new System.Drawing.Size(82, 25);
            this.Español.TabIndex = 5;
            this.Español.Text = "----------";
            this.Español.Click += new System.EventHandler(this.Español_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puntos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Errores:";
            // 
            // Empieza
            // 
            this.Empieza.Location = new System.Drawing.Point(192, 292);
            this.Empieza.Name = "Empieza";
            this.Empieza.Size = new System.Drawing.Size(144, 48);
            this.Empieza.TabIndex = 8;
            this.Empieza.Text = "Empezar/Reiniciar";
            this.Empieza.UseVisualStyleBackColor = true;
            this.Empieza.Click += new System.EventHandler(this.Empieza_Click);
            // 
            // Verifica
            // 
            this.Verifica.Location = new System.Drawing.Point(688, 292);
            this.Verifica.Name = "Verifica";
            this.Verifica.Size = new System.Drawing.Size(112, 48);
            this.Verifica.TabIndex = 9;
            this.Verifica.Text = "Verificar";
            this.Verifica.UseVisualStyleBackColor = true;
            this.Verifica.Click += new System.EventHandler(this.Verifica_Click);
            // 
            // Otra
            // 
            this.Otra.Location = new System.Drawing.Point(445, 292);
            this.Otra.Name = "Otra";
            this.Otra.Size = new System.Drawing.Size(112, 48);
            this.Otra.TabIndex = 10;
            this.Otra.Text = "Otra palabra";
            this.Otra.UseVisualStyleBackColor = true;
            this.Otra.Click += new System.EventHandler(this.Otra_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(140, 53);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(45, 24);
            this.Error.TabIndex = 12;
            this.Error.Text = "-----";
            // 
            // Punto
            // 
            this.Punto.AutoSize = true;
            this.Punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punto.Location = new System.Drawing.Point(836, 53);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(45, 24);
            this.Punto.TabIndex = 13;
            this.Punto.Text = "-----";
            // 
            // Pasadsimple
            // 
            this.Pasadsimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pasadsimple.Location = new System.Drawing.Point(428, 209);
            this.Pasadsimple.Name = "Pasadsimple";
            this.Pasadsimple.Size = new System.Drawing.Size(202, 30);
            this.Pasadsimple.TabIndex = 14;
            // 
            // Pasado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 550);
            this.Controls.Add(this.Pasadsimple);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Otra);
            this.Controls.Add(this.Verifica);
            this.Controls.Add(this.Empieza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Español);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Presente);
            this.Controls.Add(this.label1);
            this.Name = "Pasado";
            this.Text = "Pasado";
            this.Load += new System.EventHandler(this.Pasado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Presente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Español;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Empieza;
        private System.Windows.Forms.Button Verifica;
        private System.Windows.Forms.Button Otra;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label Punto;
        private System.Windows.Forms.TextBox Pasadsimple;
    }
}