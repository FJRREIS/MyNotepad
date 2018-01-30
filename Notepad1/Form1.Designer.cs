namespace Notepad1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nó4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nó6");
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.panelText = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelLines = new System.Windows.Forms.Panel();
            this.linha1 = new System.Windows.Forms.Label();
            this.panelDocTree = new System.Windows.Forms.Panel();
            this.panelTreeDocTree = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTitleDocTree = new System.Windows.Forms.Panel();
            this.lblDocTree = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelLines.SuspendLayout();
            this.panelDocTree.SuspendLayout();
            this.panelTreeDocTree.SuspendLayout();
            this.panelTitleDocTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.menuStrip2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(923, 55);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.fromatarToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(923, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNovo,
            this.MenuItemAbrir,
            this.MenuItemSalvar,
            this.MenuItemSalvarComo,
            this.salvarTodosToolStripMenuItem,
            this.toolStripSeparator2,
            this.MenuItemFechar,
            this.fecharTodosToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripSeparator4,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem2.Text = "Arquivo";
            // 
            // MenuItemNovo
            // 
            this.MenuItemNovo.Name = "MenuItemNovo";
            this.MenuItemNovo.Size = new System.Drawing.Size(170, 22);
            this.MenuItemNovo.Text = "Novo";
            this.MenuItemNovo.Click += new System.EventHandler(this.MenuItemNovo_Click);
            // 
            // MenuItemAbrir
            // 
            this.MenuItemAbrir.Name = "MenuItemAbrir";
            this.MenuItemAbrir.Size = new System.Drawing.Size(170, 22);
            this.MenuItemAbrir.Text = "Abrir";
            this.MenuItemAbrir.Click += new System.EventHandler(this.MenuItemAbrir_Click);
            // 
            // MenuItemSalvar
            // 
            this.MenuItemSalvar.Name = "MenuItemSalvar";
            this.MenuItemSalvar.Size = new System.Drawing.Size(170, 22);
            this.MenuItemSalvar.Text = "Salvar";
            this.MenuItemSalvar.Click += new System.EventHandler(this.MenuItemSalvar_Click);
            // 
            // MenuItemSalvarComo
            // 
            this.MenuItemSalvarComo.Name = "MenuItemSalvarComo";
            this.MenuItemSalvarComo.Size = new System.Drawing.Size(170, 22);
            this.MenuItemSalvarComo.Text = "Salvar como...";
            this.MenuItemSalvarComo.Click += new System.EventHandler(this.MenuItemSalvarComo_Click);
            // 
            // salvarTodosToolStripMenuItem
            // 
            this.salvarTodosToolStripMenuItem.Name = "salvarTodosToolStripMenuItem";
            this.salvarTodosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salvarTodosToolStripMenuItem.Text = "Salvar Todos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // MenuItemFechar
            // 
            this.MenuItemFechar.Name = "MenuItemFechar";
            this.MenuItemFechar.Size = new System.Drawing.Size(170, 22);
            this.MenuItemFechar.Text = "Fechar";
            this.MenuItemFechar.Click += new System.EventHandler(this.MenuItemFechar_Click);
            // 
            // fecharTodosToolStripMenuItem
            // 
            this.fecharTodosToolStripMenuItem.Name = "fecharTodosToolStripMenuItem";
            this.fecharTodosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fecharTodosToolStripMenuItem.Text = "Fechar Todos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem10.Text = "Imprimir";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem11.Text = "Configurar página";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem3.Text = "Editar";
            // 
            // fromatarToolStripMenuItem
            // 
            this.fromatarToolStripMenuItem.Name = "fromatarToolStripMenuItem";
            this.fromatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fromatarToolStripMenuItem.Text = "Formatar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArquivosToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem4.Text = "Exibir";
            // 
            // listaDeArquivosToolStripMenuItem
            // 
            this.listaDeArquivosToolStripMenuItem.Name = "listaDeArquivosToolStripMenuItem";
            this.listaDeArquivosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listaDeArquivosToolStripMenuItem.Text = "Lista de arquivos";
            this.listaDeArquivosToolStripMenuItem.Click += new System.EventHandler(this.listaDeArquivosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem5.Text = "Ajuda";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.tabControl1);
            this.panelPrincipal.Controls.Add(this.panelDocTree);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 55);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(923, 421);
            this.panelPrincipal.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(128, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 421);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.GotFocus += new System.EventHandler(this.tabControl1_GotFocus);
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.panelText);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(787, 395);
            this.tabPage0.TabIndex = 0;
            this.tabPage0.Text = "Novo";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.richTextBox1);
            this.panelText.Controls.Add(this.panelLines);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(3, 3);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(781, 389);
            this.panelText.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(163, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 382);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panelLines
            // 
            this.panelLines.AutoSize = true;
            this.panelLines.Controls.Add(this.linha1);
            this.panelLines.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLines.Location = new System.Drawing.Point(0, 0);
            this.panelLines.MinimumSize = new System.Drawing.Size(45, 0);
            this.panelLines.Name = "panelLines";
            this.panelLines.Size = new System.Drawing.Size(45, 389);
            this.panelLines.TabIndex = 0;
            // 
            // linha1
            // 
            this.linha1.AutoSize = true;
            this.linha1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linha1.Location = new System.Drawing.Point(0, 0);
            this.linha1.Name = "linha1";
            this.linha1.Size = new System.Drawing.Size(13, 13);
            this.linha1.TabIndex = 0;
            this.linha1.Text = "1";
            this.linha1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panelDocTree
            // 
            this.panelDocTree.Controls.Add(this.panelTreeDocTree);
            this.panelDocTree.Controls.Add(this.panelTitleDocTree);
            this.panelDocTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDocTree.Location = new System.Drawing.Point(0, 0);
            this.panelDocTree.Name = "panelDocTree";
            this.panelDocTree.Size = new System.Drawing.Size(128, 421);
            this.panelDocTree.TabIndex = 2;
            // 
            // panelTreeDocTree
            // 
            this.panelTreeDocTree.Controls.Add(this.treeView2);
            this.panelTreeDocTree.Controls.Add(this.splitter1);
            this.panelTreeDocTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTreeDocTree.Location = new System.Drawing.Point(0, 25);
            this.panelTreeDocTree.Name = "panelTreeDocTree";
            this.panelTreeDocTree.Size = new System.Drawing.Size(128, 396);
            this.panelTreeDocTree.TabIndex = 4;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Nó0";
            treeNode1.Text = "Nó0";
            treeNode2.Name = "Nó1";
            treeNode2.Text = "Nó1";
            treeNode3.Name = "Nó2";
            treeNode3.Text = "Nó2";
            treeNode4.Name = "Nó3";
            treeNode4.Text = "Nó3";
            treeNode5.Name = "Nó0";
            treeNode5.Text = "Nó0";
            treeNode6.Name = "Nó1";
            treeNode6.Text = "Nó1";
            treeNode7.Name = "Nó2";
            treeNode7.Text = "Nó2";
            treeNode8.Name = "Nó3";
            treeNode8.Text = "Nó3";
            treeNode9.Name = "Nó4";
            treeNode9.Text = "Nó4";
            treeNode10.Name = "Nó5";
            treeNode10.Text = "Nó5";
            treeNode11.Name = "Nó6";
            treeNode11.Text = "Nó6";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView2.Size = new System.Drawing.Size(120, 396);
            this.treeView2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(120, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 396);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelTitleDocTree
            // 
            this.panelTitleDocTree.Controls.Add(this.lblDocTree);
            this.panelTitleDocTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleDocTree.Location = new System.Drawing.Point(0, 0);
            this.panelTitleDocTree.Name = "panelTitleDocTree";
            this.panelTitleDocTree.Size = new System.Drawing.Size(128, 25);
            this.panelTitleDocTree.TabIndex = 3;
            // 
            // lblDocTree
            // 
            this.lblDocTree.AutoSize = true;
            this.lblDocTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocTree.Location = new System.Drawing.Point(11, 6);
            this.lblDocTree.Name = "lblDocTree";
            this.lblDocTree.Size = new System.Drawing.Size(105, 13);
            this.lblDocTree.TabIndex = 2;
            this.lblDocTree.Text = "Lista de Arquivos";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(923, 476);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panelLines.ResumeLayout(false);
            this.panelLines.PerformLayout();
            this.panelDocTree.ResumeLayout(false);
            this.panelTreeDocTree.ResumeLayout(false);
            this.panelTitleDocTree.ResumeLayout(false);
            this.panelTitleDocTree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalvar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalvarComo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fromatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelLines;
        private System.Windows.Forms.Label linha1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Panel panelDocTree;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ToolStripMenuItem listaDeArquivosToolStripMenuItem;
        private System.Windows.Forms.Label lblDocTree;
        private System.Windows.Forms.Panel panelTreeDocTree;
        private System.Windows.Forms.Panel panelTitleDocTree;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem salvarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFechar;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

