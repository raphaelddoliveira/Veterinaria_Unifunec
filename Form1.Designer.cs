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
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.endereçoToolStripMenuItem,
            this.contatoToolStripMenuItem,
            this.pessoaToolStripMenuItem,
            this.produtoToolStripMenuItem});
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
            this.cidAnimalToolStripMenuItem});
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.animalToolStripMenuItem.Text = "Animal";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
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
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bairroToolStripMenuItem,
            this.cepToolStripMenuItem,
            this.ruaToolStripMenuItem,
            this.paísToolStripMenuItem});
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
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cepToolStripMenuItem.Text = "Cep";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.cepToolStripMenuItem_Click);
            // 
            // ruaToolStripMenuItem
            // 
            this.ruaToolStripMenuItem.Name = "ruaToolStripMenuItem";
            this.ruaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ruaToolStripMenuItem.Text = "Rua";
            this.ruaToolStripMenuItem.Click += new System.EventHandler(this.ruaToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefoneToolStripMenuItem});
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.contatoToolStripMenuItem.Text = "Contato";
            // 
            // telefoneToolStripMenuItem
            // 
            this.telefoneToolStripMenuItem.Name = "telefoneToolStripMenuItem";
            this.telefoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telefoneToolStripMenuItem.Text = "Telefone";
            this.telefoneToolStripMenuItem.Click += new System.EventHandler(this.telefoneToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoFuncionárioToolStripMenuItem});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // tipoFuncionárioToolStripMenuItem
            // 
            this.tipoFuncionárioToolStripMenuItem.Name = "tipoFuncionárioToolStripMenuItem";
            this.tipoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoFuncionárioToolStripMenuItem.Text = "Tipo Funcionário";
            this.tipoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.tipoFuncionárioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.tipoProdutoToolStripMenuItem,
            this.tipoServiçoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // tipoProdutoToolStripMenuItem
            // 
            this.tipoProdutoToolStripMenuItem.Name = "tipoProdutoToolStripMenuItem";
            this.tipoProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoProdutoToolStripMenuItem.Text = "Tipo Produto";
            this.tipoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoProdutoToolStripMenuItem_Click);
            // 
            // cidAnimalToolStripMenuItem
            // 
            this.cidAnimalToolStripMenuItem.Name = "cidAnimalToolStripMenuItem";
            this.cidAnimalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidAnimalToolStripMenuItem.Text = "Cid Animal";
            this.cidAnimalToolStripMenuItem.Click += new System.EventHandler(this.cidAnimalToolStripMenuItem_Click);
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paísToolStripMenuItem.Text = "País";
            this.paísToolStripMenuItem.Click += new System.EventHandler(this.paísToolStripMenuItem_Click);
            // 
            // tipoServiçoToolStripMenuItem
            // 
            this.tipoServiçoToolStripMenuItem.Name = "tipoServiçoToolStripMenuItem";
            this.tipoServiçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoServiçoToolStripMenuItem.Text = "Tipo Serviço";
            this.tipoServiçoToolStripMenuItem.Click += new System.EventHandler(this.tipoServiçoToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoServiçoToolStripMenuItem;
    }
}

