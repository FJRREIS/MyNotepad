using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Notepad1
{
     public partial class Form1 : Form
    {
        int numberOfTabs;
        public Aba AbaCurrent = new Aba();
        public TabControl auxtabctrl;
        public RichTextBox TxtCurrent = new RichTextBox();
        public List<Aba> Abas = new List<Aba>();
        public List<int> newFileTabNums = new List<int>();
        public SqlConnection _conn = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            numberOfTabs = 1;

            auxtabctrl = tabControl1;
            Aba.NovaAba(tabControl1, 1, Abas);
            tabControl1.TabPages.Remove(tabPage0);

            AbaCurrent = Abas[0];
            TxtCurrent = AbaCurrent.RTB;
            TxtCurrent.TextChanged += TxtCurrent_TextChanged;
            TxtCurrent.Select();
            AbaCurrent.NewFileTabNum = 0;
            newFileTabNums.Add(0);
            AbaCurrent.tabPage.Text = "Novo" + (AbaCurrent.NewFileTabNum+1);
            _conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConNotepad1DB"].ToString();
            _conn.Open();
        }

        //
        //Handles interface when text is changed
        //
        private void TxtCurrent_TextChanged(object sender, EventArgs e)
        {
            for( ; AbaCurrent.Contador < TxtCurrent.GetLineFromCharIndex(TxtCurrent.Text.Length); AbaCurrent.Contador++)
                Linhas.AdicionarLinha(AbaCurrent);
            for (; AbaCurrent.Contador > TxtCurrent.GetLineFromCharIndex(TxtCurrent.Text.Length); AbaCurrent.Contador--)
                Linhas.RemoverLinha(AbaCurrent);
            if (AbaCurrent.Saved)
            {
                AbaCurrent.Saved = false;
                AbaCurrent.tabPage.Text += "*";
            }
        }

        //
        //Hide Explorer Panel
        //
        private void listaDeArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (treeView2.Visible)
            {
                lblDocTree.Visible = false;
                panelTitleDocTree.AutoSize = true;
                treeView2.Visible = false;
                panelDocTree.AutoSize = true;
                listaDeArquivosToolStripMenuItem.Checked = false;
            }
            else
            {
                panelTitleDocTree.AutoSize = false;
                lblDocTree.Visible = true;
                panelDocTree.AutoSize = false;
                treeView2.Visible = true;
                listaDeArquivosToolStripMenuItem.Checked = true;
            }
        }

        //
        //Nova Aba
        //Nomeia a nova aba de acordo com o menor identificador númerico de novas abas corrente
        private void MenuItemNovo_Click(object sender, EventArgs e)
        {
            numberOfTabs++;
            Aba.NovaAba(auxtabctrl, numberOfTabs,  Abas);
            AbaCurrent = Abas[Abas.Count - 1];
            TxtCurrent = AbaCurrent.RTB;
            TxtCurrent.TextChanged += TxtCurrent_TextChanged;
            for (int i=0; i <= newFileTabNums.Count; i++)
            {
                if (!newFileTabNums.Contains(i))
                {
                    AbaCurrent.NewFileTabNum = i;
                    break;
                }
            }
            if (newFileTabNums.Count == 0)
                AbaCurrent.NewFileTabNum = 0;
            newFileTabNums.Add(AbaCurrent.NewFileTabNum);
            AbaCurrent.tabPage.Text = "Novo " + (AbaCurrent.NewFileTabNum+1);
        }

        //
        //Changes the current public handlers everytime a different tab is selected
        //
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(AbaCurrent.tabPage != tabControl1.SelectedTab)
                foreach (Aba a in Abas)
                {
                    if (a.tabPage == tabControl1.SelectedTab)
                    {
                        AbaCurrent = a;
                        TxtCurrent = AbaCurrent.RTB;
                        TxtCurrent.TextChanged += TxtCurrent_TextChanged;
                        break;
                     }
                }
        }

        //
        //Changes the focus to the text everytime a tab gets focused
        //
        private void tabControl1_GotFocus(object sender, EventArgs e)
        {
            AbaCurrent.RTB.Select();
        }

        //
        //Open text Files
        //
        private void MenuItemAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Text File";
            openFileDialog1.Multiselect = false;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if ((AbaCurrent.Path == null) && (AbaCurrent.RTB.Text == ""))
                    {
                        StreamReader NewSR = new StreamReader(openFileDialog1.OpenFile());
                        AbaCurrent.RTB.Text = NewSR.ReadToEnd();
                        NewSR.Close();
                    }
                    else
                    {
                        MenuItemNovo_Click(sender, e);
                        StreamReader NewSR = new StreamReader(openFileDialog1.OpenFile());
                        AbaCurrent.RTB.Text = NewSR.ReadToEnd();
                        NewSR.Close();
                    }
                    AbaCurrent.Saved = true;
                    AbaCurrent.IsNewFileTab = false;
                    newFileTabNums.Remove(AbaCurrent.NewFileTabNum);
                    AbaCurrent.Path = openFileDialog1.FileName;
                    AbaCurrent.tabPage.Text = openFileDialog1.SafeFileName;
                    openFileDialog1.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Erro: não foi possível abrir o arquivo especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        //Fecha a aba que estiver selecionada
        //
        private void MenuItemFechar_Click(object sender, EventArgs e)
        {

            //Pergunta se o usuario deseja salvar um trabalho não salvo
            if (!AbaCurrent.Saved)
            {
                DialogResult newDR = MessageBox.Show(AbaCurrent.tabPage.Text + " contém alterações que não foram salvas. Deseja salvar?", "Item não salvo", MessageBoxButtons.YesNoCancel);
                if (newDR == DialogResult.Cancel)
                    return;
                else if (newDR == DialogResult.Yes)
                    MenuItemSalvar_Click(sender, e);
            }

            //remove a instancia da aba das listas publicas de controle
            Abas.Remove(AbaCurrent);
            if (AbaCurrent.IsNewFileTab)
                newFileTabNums.Remove(AbaCurrent.NewFileTabNum);

            //muda para a tab anterior. Caso nao haja anterior, muda para a posterior
            //fecha a tab no form
            int index = auxtabctrl.SelectedIndex;
            auxtabctrl.TabPages.Remove(AbaCurrent.tabPage);
            try { auxtabctrl.SelectTab(index - 1); }
            catch { try { auxtabctrl.SelectTab(index); } catch { } }

            //muda a aba current para a nova aba selecionada
            if (AbaCurrent.tabPage != tabControl1.SelectedTab)
                foreach (Aba a in Abas)
                {
                    if (a.tabPage == tabControl1.SelectedTab)
                    {
                        AbaCurrent = a;
                        TxtCurrent = AbaCurrent.RTB;
                        TxtCurrent.TextChanged += TxtCurrent_TextChanged;
                        break;
                    }
                }
            tabControl1_GotFocus(sender, e);
        }

        //
        //Save
        //
        private void MenuItemSalvar_Click(object sender, EventArgs e)
        {
            if (AbaCurrent.Path == null)
                MenuItemSalvarComo_Click(sender, e);
            else
            {
                AbaCurrent.RTB.SaveFile(AbaCurrent.Path, RichTextBoxStreamType.PlainText);
                AbaCurrent.Saved = true;
                AbaCurrent.tabPage.Text = AbaCurrent.tabPage.Text.Substring(0, AbaCurrent.tabPage.Text.Length - 5) + ".txt";
            }
        }

        //
        //Save As
        //
        private void MenuItemSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar como";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text Files|*.txt"; 
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(!AbaCurrent.Saved)
                saveFileDialog1.FileName = AbaCurrent.tabPage.Text.Substring(0, AbaCurrent.tabPage.Text.Length - 1);
            else
                saveFileDialog1.FileName = AbaCurrent.tabPage.Text;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                AbaCurrent.Path = saveFileDialog1.FileName;
                AbaCurrent.RTB.SaveFile(AbaCurrent.Path, RichTextBoxStreamType.PlainText);
                AbaCurrent.tabPage.Text =  saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf(@"\")+1);
                if (AbaCurrent.IsNewFileTab)
                {
                    AbaCurrent.Saved = true;
                    AbaCurrent.IsNewFileTab = false;
                    newFileTabNums.Remove(AbaCurrent.NewFileTabNum);
                }
            }
        }
    }

    public class Linhas
    {
        private int _contador = 0;
        public Stack<Label> NumLinhas = new Stack<Label>();

        public int Contador
        {
            get
            {
                return _contador;
            }
            set
            {
                _contador = value;
            }
        }
        
        public static void AdicionarLinha(Aba tAba)
        {
            Label aux = tAba.NumLinhas.Peek();
            Label novalinha = new Label();

            novalinha.AutoSize = true;
            novalinha.Location = new System.Drawing.Point(0, aux.Bottom);
            novalinha.Name = "linha" + tAba.Contador.ToString();
            novalinha.Size = new System.Drawing.Size(13, 13);
            novalinha.TabIndex = 0;
            novalinha.Text = (tAba.Contador + 2).ToString();
            novalinha.TextAlign = System.Drawing.ContentAlignment.BottomRight;

            tAba.NumLinhas.Push(novalinha);
            tAba.linePanel.Controls.Add(novalinha);
        }

        public static void RemoverLinha(Aba tAba)
        {
            Label aux = tAba.NumLinhas.Pop();
            tAba.linePanel.Controls.Remove(aux);
        }
    }

    public class Aba : Linhas
    {
        private string _path;
        private bool _saved;
        private int numAba;
        private int _NewFileTabNum;
        private bool _isNewFileTab;
        public Panel textPanel = new Panel();
        public Panel linePanel = new Panel();
        public RichTextBox RTB = new RichTextBox();
        public TabPage tabPage = new TabPage();

        public int NumAba { get => numAba; set => numAba = value; }
        public bool Saved { get => _saved; set => _saved = value; }
        public string Path { get => _path; set => _path = value; }
        public int NewFileTabNum { get => _NewFileTabNum; set => _NewFileTabNum = value; }
        public bool IsNewFileTab { get => _isNewFileTab; set => _isNewFileTab = value; }

        //
        //NovaAba method
        //Creates new Aba instance and adds to public Abas list
        public static void NovaAba(TabControl x, int tnumAbas, List<Aba> list)
        {
            Panel NewTextPanel = new Panel();
            Panel NewLinePanel = new Panel();
            Label NewLine = new Label();
            RichTextBox NewRichTextBox = new RichTextBox();
            TabPage NewTabPage = new TabPage();

            NewLinePanel.AutoSize = true;
            NewLinePanel.Controls.Add(NewLine);
            NewLinePanel.Dock = System.Windows.Forms.DockStyle.Left;
            //NewLinePanel.Location = new System.Drawing.Point(0, 0);
            NewLinePanel.MinimumSize = new System.Drawing.Size(35, 0);
            NewLinePanel.Name = "panelLines" + tnumAbas.ToString();
            //NewLinePanel.Size = new System.Drawing.Size(45, 382);

            NewLine.AutoSize = true;
            NewLine.Dock = System.Windows.Forms.DockStyle.Top;
            //NewLine.Location = new System.Drawing.Point(0, 0);
            NewLine.Name = "linha1_Aba" + tnumAbas.ToString();
            //NewLine.Size = new System.Drawing.Size(13, 13);
            NewLine.Text = "1";
            NewLine.TextAlign = System.Drawing.ContentAlignment.BottomRight;

            NewRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            //NewRichTextBox.Location = new System.Drawing.Point(45, 0);
            NewRichTextBox.Name = "richTextBox_Aba" + tnumAbas.ToString();
            //NewRichTextBox.Size = new System.Drawing.Size(502, 382);
            NewRichTextBox.Text = "";
            NewRichTextBox.TabIndex = 0;

            NewTextPanel.Controls.Add(NewRichTextBox);
            NewTextPanel.Controls.Add(NewLinePanel);
            NewTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            //NewTextPanel.Location = new System.Drawing.Point(3, 3);
            NewTextPanel.Name = "panelText";
            //NewTextPanel.Size = new System.Drawing.Size(547, 382);

            NewTabPage.Controls.Add(NewTextPanel);
            x.TabPages.Add(NewTabPage);
            x.SelectedTab = NewTabPage;
            NewRichTextBox.Select();
            

            Aba NewAba = new Aba(NewLinePanel,NewTextPanel,tnumAbas, NewRichTextBox, NewLine, NewTabPage);
            list.Add(NewAba);
        } 

        //
        //Constructor full
        //
        public Aba (Panel lines, Panel text, int numAba, RichTextBox tRTB, Label linha1, TabPage tpage)
        {
            textPanel = text;
            linePanel = lines;
            NumAba = numAba;
            RTB = tRTB;
            NumLinhas.Push(linha1);
            tabPage = tpage;
            Saved = true;
            IsNewFileTab = true;
        }

        //default constructor;
        public Aba() { }
    }

  

}
