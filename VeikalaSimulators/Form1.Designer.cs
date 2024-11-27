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
            this.NotikumuKaste = new System.Windows.Forms.RichTextBox();
            this.DienasSimulacija = new System.Windows.Forms.Button();
            this.DienasSimuletas = new System.Windows.Forms.Label();
            this.IepirkumaDaudzums = new System.Windows.Forms.TextBox();
            this.IepirktInvetaru = new System.Windows.Forms.Button();
            this.ProduktaCena = new System.Windows.Forms.TextBox();
            this.MainitProduktaCenu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Budzets
            // 
            this.Budzets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Budzets.AutoSize = true;
            this.Budzets.Location = new System.Drawing.Point(12, 9);
            this.Budzets.Name = "Budzets";
            this.Budzets.Size = new System.Drawing.Size(78, 20);
            this.Budzets.TabIndex = 0;
            this.Budzets.Text = "Budžets";
            // 
            // Inventars
            // 
            this.Inventars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventars.AutoSize = true;
            this.Inventars.Location = new System.Drawing.Point(12, 29);
            this.Inventars.Name = "Inventars";
            this.Inventars.Size = new System.Drawing.Size(92, 20);
            this.Inventars.TabIndex = 1;
            this.Inventars.Text = "Inventars";
            // 
            // PrecesCena
            // 
            this.PrecesCena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecesCena.AutoSize = true;
            this.PrecesCena.Location = new System.Drawing.Point(12, 49);
            this.PrecesCena.Name = "PrecesCena";
            this.PrecesCena.Size = new System.Drawing.Size(131, 20);
            this.PrecesCena.TabIndex = 2;
            this.PrecesCena.Text = "Produkta cena";
            // 
            // NotikumuKaste
            // 
            this.NotikumuKaste.Dock = System.Windows.Forms.DockStyle.Right;
            this.NotikumuKaste.Location = new System.Drawing.Point(199, 0);
            this.NotikumuKaste.Name = "NotikumuKaste";
            this.NotikumuKaste.ReadOnly = true;
            this.NotikumuKaste.Size = new System.Drawing.Size(601, 450);
            this.NotikumuKaste.TabIndex = 3;
            this.NotikumuKaste.Text = "";
            // 
            // DienasSimulacija
            // 
            this.DienasSimulacija.Location = new System.Drawing.Point(12, 68);
            this.DienasSimulacija.Name = "DienasSimulacija";
            this.DienasSimulacija.Size = new System.Drawing.Size(116, 55);
            this.DienasSimulacija.TabIndex = 4;
            this.DienasSimulacija.Text = "Dienas Simulacija";
            this.DienasSimulacija.UseVisualStyleBackColor = true;
            this.DienasSimulacija.Click += new System.EventHandler(this.DienasSimulacija_Click);
            // 
            // DienasSimuletas
            // 
            this.DienasSimuletas.AutoSize = true;
            this.DienasSimuletas.Location = new System.Drawing.Point(8, 377);
            this.DienasSimuletas.Name = "DienasSimuletas";
            this.DienasSimuletas.Size = new System.Drawing.Size(181, 20);
            this.DienasSimuletas.TabIndex = 5;
            this.DienasSimuletas.Text = "Dienas simulētas: 0";
            // 
            // IepirkumaDaudzums
            // 
            this.IepirkumaDaudzums.Location = new System.Drawing.Point(12, 130);
            this.IepirkumaDaudzums.MaxLength = 100;
            this.IepirkumaDaudzums.Name = "IepirkumaDaudzums";
            this.IepirkumaDaudzums.Size = new System.Drawing.Size(116, 27);
            this.IepirkumaDaudzums.TabIndex = 6;
            this.IepirkumaDaudzums.Text = "0";
            // 
            // IepirktInvetaru
            // 
            this.IepirktInvetaru.Location = new System.Drawing.Point(12, 159);
            this.IepirktInvetaru.Name = "IepirktInvetaru";
            this.IepirktInvetaru.Size = new System.Drawing.Size(116, 55);
            this.IepirktInvetaru.TabIndex = 7;
            this.IepirktInvetaru.Text = "Iepirkt Inventāru";
            this.IepirktInvetaru.UseVisualStyleBackColor = true;
            this.IepirktInvetaru.Click += new System.EventHandler(this.IepirktInvetaru_Click);
            // 
            // ProduktaCena
            // 
            this.ProduktaCena.Location = new System.Drawing.Point(12, 220);
            this.ProduktaCena.MaxLength = 100;
            this.ProduktaCena.Name = "ProduktaCena";
            this.ProduktaCena.Size = new System.Drawing.Size(116, 27);
            this.ProduktaCena.TabIndex = 8;
            this.ProduktaCena.Text = "0";
            // 
            // MainitProduktaCenu
            // 
            this.MainitProduktaCenu.Location = new System.Drawing.Point(12, 249);
            this.MainitProduktaCenu.Name = "MainitProduktaCenu";
            this.MainitProduktaCenu.Size = new System.Drawing.Size(116, 55);
            this.MainitProduktaCenu.TabIndex = 9;
            this.MainitProduktaCenu.Text = "Mainīt produkta cenu";
            this.MainitProduktaCenu.UseVisualStyleBackColor = true;
            this.MainitProduktaCenu.Click += new System.EventHandler(this.MainitProduktaCenu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 39);
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MainitProduktaCenu);
            this.Controls.Add(this.ProduktaCena);
            this.Controls.Add(this.IepirktInvetaru);
            this.Controls.Add(this.IepirkumaDaudzums);
            this.Controls.Add(this.DienasSimuletas);
            this.Controls.Add(this.DienasSimulacija);
            this.Controls.Add(this.PrecesCena);
            this.Controls.Add(this.Inventars);
            this.Controls.Add(this.Budzets);
            this.Controls.Add(this.NotikumuKaste);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Veikala Simulators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Budzets;
        private System.Windows.Forms.Label Inventars;
        private System.Windows.Forms.Label PrecesCena;
        private System.Windows.Forms.RichTextBox NotikumuKaste;
        private System.Windows.Forms.Button DienasSimulacija;
        private System.Windows.Forms.Label DienasSimuletas;
        private System.Windows.Forms.TextBox IepirkumaDaudzums;
        private System.Windows.Forms.Button IepirktInvetaru;
        private System.Windows.Forms.TextBox ProduktaCena;
        private System.Windows.Forms.Button MainitProduktaCenu;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

