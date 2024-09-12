namespace Veterinaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.endereçoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raçaToolStripMenuItem,
            this.tipoAnimalToolStripMenuItem,
            this.sexoToolStripMenuItem});
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.animalToolStripMenuItem.Text = "Animal";
            // 
            // raçaToolStripMenuItem
            // 
            this.raçaToolStripMenuItem.Name = "raçaToolStripMenuItem";
            this.raçaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.raçaToolStripMenuItem.Text = "Raça";
            this.raçaToolStripMenuItem.Click += new System.EventHandler(this.raçaToolStripMenuItem_Click);
            // 
            // tipoAnimalToolStripMenuItem
            // 
            this.tipoAnimalToolStripMenuItem.Name = "tipoAnimalToolStripMenuItem";
            this.tipoAnimalToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tipoAnimalToolStripMenuItem.Text = "Tipo Animal";
            this.tipoAnimalToolStripMenuItem.Click += new System.EventHandler(this.tipoAnimalToolStripMenuItem_Click);
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            this.sexoToolStripMenuItem.Click += new System.EventHandler(this.sexoToolStripMenuItem_Click);
            // 
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bairroToolStripMenuItem});
            this.endereçoToolStripMenuItem.Name = "endereçoToolStripMenuItem";
            this.endereçoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.endereçoToolStripMenuItem.Text = "Endereço";
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bairroToolStripMenuItem.Text = "Bairro";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.bairroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
    }
}

