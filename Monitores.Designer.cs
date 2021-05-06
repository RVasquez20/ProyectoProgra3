namespace ProyectoProgra3
{
    partial class Monitores
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Mpalabras = new System.Windows.Forms.TextBox();
            this.mfacs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*Palabras.txt*";
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.Path = "C:\\Users\\rodri\\Documents\\GitHub\\Proyecto de Jose\\ProyectoProgra3\\bin\\Debug";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Mpalabras
            // 
            this.Mpalabras.Location = new System.Drawing.Point(24, 104);
            this.Mpalabras.Multiline = true;
            this.Mpalabras.Name = "Mpalabras";
            this.Mpalabras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Mpalabras.Size = new System.Drawing.Size(274, 555);
            this.Mpalabras.TabIndex = 0;
            // 
            // mfacs
            // 
            this.mfacs.Location = new System.Drawing.Point(351, 104);
            this.mfacs.Multiline = true;
            this.mfacs.Name = "mfacs";
            this.mfacs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mfacs.Size = new System.Drawing.Size(285, 555);
            this.mfacs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitor \r\n    De\r\nPalabras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 124);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monitor \r\n    De\r\nFacturas\r\n\r\n";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.Filter = "*Facturas.txt*";
            this.fileSystemWatcher2.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher2.Path = "C:\\Users\\rodri\\Documents\\GitHub\\Proyecto de Jose\\ProyectoProgra3\\bin\\Debug";
            this.fileSystemWatcher2.SynchronizingObject = this;
            this.fileSystemWatcher2.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher2_Changed);
            // 
            // Monitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 671);
            this.Controls.Add(this.mfacs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mpalabras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Monitores";
            this.Text = "Proyecto Programacion 3";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox mfacs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mpalabras;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}

