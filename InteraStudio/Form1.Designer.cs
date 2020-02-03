namespace InteraStudio
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarCópiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doInícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPartirDaCenaSelecionadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.storyboardBox = new System.Windows.Forms.GroupBox();
            this.contextMenuBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novaCenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyboardPanel = new System.Windows.Forms.Panel();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProjTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileProject = new System.Windows.Forms.OpenFileDialog();
            this.openFileVideo = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuCena = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.primeiraCenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTransiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subTT_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.subTT_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileProject = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.storyboardBox.SuspendLayout();
            this.contextMenuBoard.SuspendLayout();
            this.propertiesBox.SuspendLayout();
            this.contextMenuCena.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.reproduzirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProjetoToolStripMenuItem,
            this.carregarProjetoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarCópiaToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShowShortcutKeys = false;
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoProjetoToolStripMenuItem
            // 
            this.novoProjetoToolStripMenuItem.Name = "novoProjetoToolStripMenuItem";
            this.novoProjetoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoProjetoToolStripMenuItem.ShowShortcutKeys = false;
            this.novoProjetoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.novoProjetoToolStripMenuItem.Text = "Novo Projeto";
            this.novoProjetoToolStripMenuItem.Click += new System.EventHandler(this.novoProjetoToolStripMenuItem_Click);
            // 
            // carregarProjetoToolStripMenuItem
            // 
            this.carregarProjetoToolStripMenuItem.Name = "carregarProjetoToolStripMenuItem";
            this.carregarProjetoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.carregarProjetoToolStripMenuItem.ShowShortcutKeys = false;
            this.carregarProjetoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.carregarProjetoToolStripMenuItem.Text = "Abrir...";
            this.carregarProjetoToolStripMenuItem.Click += new System.EventHandler(this.carregarProjetoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.ShowShortcutKeys = false;
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarCópiaToolStripMenuItem
            // 
            this.salvarCópiaToolStripMenuItem.Name = "salvarCópiaToolStripMenuItem";
            this.salvarCópiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarCópiaToolStripMenuItem.Text = "Salvar Como...";
            this.salvarCópiaToolStripMenuItem.Click += new System.EventHandler(this.salvarCópiaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // importarToolStripMenuItem1
            // 
            this.importarToolStripMenuItem1.Name = "importarToolStripMenuItem1";
            this.importarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.importarToolStripMenuItem1.Text = "Importar";
            this.importarToolStripMenuItem1.Click += new System.EventHandler(this.importarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Exportar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // reproduzirToolStripMenuItem
            // 
            this.reproduzirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doInícioToolStripMenuItem,
            this.aPartirDaCenaSelecionadaToolStripMenuItem});
            this.reproduzirToolStripMenuItem.Name = "reproduzirToolStripMenuItem";
            this.reproduzirToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reproduzirToolStripMenuItem.Text = "Reproduzir";
            // 
            // doInícioToolStripMenuItem
            // 
            this.doInícioToolStripMenuItem.Name = "doInícioToolStripMenuItem";
            this.doInícioToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.doInícioToolStripMenuItem.Text = "Do início";
            this.doInícioToolStripMenuItem.Click += new System.EventHandler(this.doInícioToolStripMenuItem_Click);
            // 
            // aPartirDaCenaSelecionadaToolStripMenuItem
            // 
            this.aPartirDaCenaSelecionadaToolStripMenuItem.Name = "aPartirDaCenaSelecionadaToolStripMenuItem";
            this.aPartirDaCenaSelecionadaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.aPartirDaCenaSelecionadaToolStripMenuItem.Text = "A partir da Cena Selecionada";
            this.aPartirDaCenaSelecionadaToolStripMenuItem.Click += new System.EventHandler(this.aPartirDaCenaSelecionadaToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.storyboardBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertiesBox);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 725);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 1;
            // 
            // storyboardBox
            // 
            this.storyboardBox.AutoSize = true;
            this.storyboardBox.ContextMenuStrip = this.contextMenuBoard;
            this.storyboardBox.Controls.Add(this.storyboardPanel);
            this.storyboardBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyboardBox.Location = new System.Drawing.Point(0, 0);
            this.storyboardBox.MinimumSize = new System.Drawing.Size(0, 400);
            this.storyboardBox.Name = "storyboardBox";
            this.storyboardBox.Size = new System.Drawing.Size(1064, 515);
            this.storyboardBox.TabIndex = 0;
            this.storyboardBox.TabStop = false;
            this.storyboardBox.Text = "Storyboard";
            this.storyboardBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.storyboardBox_DragDrop);
            this.storyboardBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.storyboardBox_DragEnter);
            // 
            // contextMenuBoard
            // 
            this.contextMenuBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCenaToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.contextMenuBoard.Name = "contextMenuStrip1";
            this.contextMenuBoard.Size = new System.Drawing.Size(133, 48);
            // 
            // novaCenaToolStripMenuItem
            // 
            this.novaCenaToolStripMenuItem.Name = "novaCenaToolStripMenuItem";
            this.novaCenaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.novaCenaToolStripMenuItem.Text = "Nova Cena";
            this.novaCenaToolStripMenuItem.Click += new System.EventHandler(this.novaCenaToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem1_Click);
            // 
            // storyboardPanel
            // 
            this.storyboardPanel.AutoScroll = true;
            this.storyboardPanel.AutoSize = true;
            this.storyboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyboardPanel.Location = new System.Drawing.Point(3, 16);
            this.storyboardPanel.Name = "storyboardPanel";
            this.storyboardPanel.Size = new System.Drawing.Size(1058, 496);
            this.storyboardPanel.TabIndex = 0;
            this.storyboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.storyboardBox_Paint);
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.textBoxAuthor);
            this.propertiesBox.Controls.Add(this.label2);
            this.propertiesBox.Controls.Add(this.textBoxProjTitle);
            this.propertiesBox.Controls.Add(this.label1);
            this.propertiesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesBox.Location = new System.Drawing.Point(0, 0);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(1064, 206);
            this.propertiesBox.TabIndex = 0;
            this.propertiesBox.TabStop = false;
            this.propertiesBox.Text = "Projeto";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(56, 61);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(416, 20);
            this.textBoxAuthor.TabIndex = 3;
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor:";
            // 
            // textBoxProjTitle
            // 
            this.textBoxProjTitle.Location = new System.Drawing.Point(56, 29);
            this.textBoxProjTitle.Name = "textBoxProjTitle";
            this.textBoxProjTitle.Size = new System.Drawing.Size(416, 20);
            this.textBoxProjTitle.TabIndex = 1;
            this.textBoxProjTitle.TextChanged += new System.EventHandler(this.textBoxProjTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // openFileProject
            // 
            this.openFileProject.Filter = "\"Projeto do InteraStudio|*.intera";
            // 
            // contextMenuCena
            // 
            this.contextMenuCena.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeiraCenaToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.removerToolStripMenuItem,
            this.novaTransiçãoToolStripMenuItem});
            this.contextMenuCena.Name = "contextMenuCena";
            this.contextMenuCena.Size = new System.Drawing.Size(155, 92);
            this.contextMenuCena.Opened += new System.EventHandler(this.contextMenuCena_Opened);
            // 
            // primeiraCenaToolStripMenuItem
            // 
            this.primeiraCenaToolStripMenuItem.Name = "primeiraCenaToolStripMenuItem";
            this.primeiraCenaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.primeiraCenaToolStripMenuItem.Text = "Primeira Cena";
            this.primeiraCenaToolStripMenuItem.Click += new System.EventHandler(this.primeiraCenaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // novaTransiçãoToolStripMenuItem
            // 
            this.novaTransiçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subTT_0,
            this.subTT_1});
            this.novaTransiçãoToolStripMenuItem.Name = "novaTransiçãoToolStripMenuItem";
            this.novaTransiçãoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.novaTransiçãoToolStripMenuItem.Text = "Nova Transição";
            // 
            // subTT_0
            // 
            this.subTT_0.Name = "subTT_0";
            this.subTT_0.Size = new System.Drawing.Size(204, 22);
            this.subTT_0.Tag = "";
            this.subTT_0.Text = "Automática";
            this.subTT_0.Click += new System.EventHandler(this.novaTransiçãoToolStripMenuItem_Click);
            // 
            // subTT_1
            // 
            this.subTT_1.Name = "subTT_1";
            this.subTT_1.Size = new System.Drawing.Size(204, 22);
            this.subTT_1.Text = "Pressionamento de Tecla";
            this.subTT_1.Click += new System.EventHandler(this.novaTransiçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "*Novo Projeto - InteraStudio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.storyboardBox.ResumeLayout(false);
            this.storyboardBox.PerformLayout();
            this.contextMenuBoard.ResumeLayout(false);
            this.propertiesBox.ResumeLayout(false);
            this.propertiesBox.PerformLayout();
            this.contextMenuCena.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproduzirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox storyboardBox;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuBoard;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileProject;
        private System.Windows.Forms.OpenFileDialog openFileVideo;
        private System.Windows.Forms.ToolStripMenuItem doInícioToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuCena;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaCenaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileProject;
        private System.Windows.Forms.ToolStripMenuItem aPartirDaCenaSelecionadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaTransiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subTT_0;
        private System.Windows.Forms.ToolStripMenuItem subTT_1;
        private System.Windows.Forms.ToolStripMenuItem primeiraCenaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxProjTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem salvarCópiaToolStripMenuItem;
        private System.Windows.Forms.Panel storyboardPanel;
    }
}

