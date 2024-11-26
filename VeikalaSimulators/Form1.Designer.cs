namespace VeikalaSimulators
{
    partial class Form1
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
            this.Budzets = new System.Windows.Forms.Label();
            this.Inventars = new System.Windows.Forms.Label();
            this.PrecesCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Budzets
            // 
            this.Budzets.AutoSize = true;
            this.Budzets.Location = new System.Drawing.Point(22, 20);
            this.Budzets.Name = "Budzets";
            this.Budzets.Size = new System.Drawing.Size(59, 16);
            this.Budzets.TabIndex = 0;
            this.Budzets.Text = "Budžets";
            // 
            // Inventars
            // 
            this.Inventars.AutoSize = true;
            this.Inventars.Location = new System.Drawing.Point(22, 54);
            this.Inventars.Name = "Inventars";
            this.Inventars.Size = new System.Drawing.Size(70, 16);
            this.Inventars.TabIndex = 1;
            this.Inventars.Text = "Inventars";
            // 
            // PrecesCena
            // 
            this.PrecesCena.AutoSize = true;
            this.PrecesCena.Location = new System.Drawing.Point(22, 91);
            this.PrecesCena.Name = "PrecesCena";
            this.PrecesCena.Size = new System.Drawing.Size(102, 16);
            this.PrecesCena.TabIndex = 2;
            this.PrecesCena.Text = "Produkta cena";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrecesCena);
            this.Controls.Add(this.Inventars);
            this.Controls.Add(this.Budzets);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Budzets;
        private System.Windows.Forms.Label Inventars;
        private System.Windows.Forms.Label PrecesCena;
    }
}

