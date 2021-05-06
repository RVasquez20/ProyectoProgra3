namespace ProyectoProgra3
{
    partial class Captcha
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
            this.img_NoConfirmada = new System.Windows.Forms.PictureBox();
            this.txt_noConfirmada = new System.Windows.Forms.TextBox();
            this.txt_Confirmada = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.txt_conf = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.img_NoConfirmada)).BeginInit();
            this.SuspendLayout();
            // 
            // img_NoConfirmada
            // 
            this.img_NoConfirmada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_NoConfirmada.Location = new System.Drawing.Point(88, 36);
            this.img_NoConfirmada.Name = "img_NoConfirmada";
            this.img_NoConfirmada.Size = new System.Drawing.Size(200, 100);
            this.img_NoConfirmada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_NoConfirmada.TabIndex = 0;
            this.img_NoConfirmada.TabStop = false;
            // 
            // txt_noConfirmada
            // 
            this.txt_noConfirmada.Location = new System.Drawing.Point(88, 153);
            this.txt_noConfirmada.Name = "txt_noConfirmada";
            this.txt_noConfirmada.Size = new System.Drawing.Size(200, 20);
            this.txt_noConfirmada.TabIndex = 2;
            // 
            // txt_Confirmada
            // 
            this.txt_Confirmada.Location = new System.Drawing.Point(308, 153);
            this.txt_Confirmada.Name = "txt_Confirmada";
            this.txt_Confirmada.Size = new System.Drawing.Size(200, 20);
            this.txt_Confirmada.TabIndex = 3;
            // 
            // Verificar
            // 
            this.Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verificar.Location = new System.Drawing.Point(225, 191);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(137, 66);
            this.Verificar.TabIndex = 4;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // txt_conf
            // 
            this.txt_conf.BackColor = System.Drawing.SystemColors.Control;
            this.txt_conf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf.Location = new System.Drawing.Point(308, 63);
            this.txt_conf.Multiline = true;
            this.txt_conf.Name = "txt_conf";
            this.txt_conf.Size = new System.Drawing.Size(200, 35);
            this.txt_conf.TabIndex = 5;
            this.txt_conf.Text = "Maritimo";
            this.txt_conf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 269);
            this.Controls.Add(this.txt_conf);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.txt_Confirmada);
            this.Controls.Add(this.txt_noConfirmada);
            this.Controls.Add(this.img_NoConfirmada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Captcha";
            this.Text = "Proyecto Programacion 3";
            ((System.ComponentModel.ISupportInitialize)(this.img_NoConfirmada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_NoConfirmada;
        private System.Windows.Forms.TextBox txt_noConfirmada;
        private System.Windows.Forms.TextBox txt_Confirmada;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.TextBox txt_conf;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

