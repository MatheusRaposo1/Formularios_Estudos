namespace Formulario
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaFormThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubSobreDes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubSobreVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuPesquisarTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 91);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(885, 126);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegunda.Location = new System.Drawing.Point(12, 383);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(284, 84);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaFormThread
            // 
            this.btnSegundaFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaFormThread.Location = new System.Drawing.Point(318, 383);
            this.btnSegundaFormThread.Name = "btnSegundaFormThread";
            this.btnSegundaFormThread.Size = new System.Drawing.Size(284, 84);
            this.btnSegundaFormThread.TabIndex = 2;
            this.btnSegundaFormThread.Text = "Segunda Form Thread";
            this.btnSegundaFormThread.UseVisualStyleBackColor = true;
            this.btnSegundaFormThread.Click += new System.EventHandler(this.btnSegundaFormThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.menuComboBox,
            this.menuPesquisarTextBox});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(910, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Info;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNovo,
            this.menuFileAbrir,
            this.toolStripSeparator1,
            this.menuFileSair});
            this.menuFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(42, 23);
            this.menuFile.Text = "File";
            // 
            // menuFileNovo
            // 
            this.menuFileNovo.BackColor = System.Drawing.Color.MistyRose;
            this.menuFileNovo.Image = global::Formulario.Properties.Resources.new_page_document_16676;
            this.menuFileNovo.Name = "menuFileNovo";
            this.menuFileNovo.ShortcutKeyDisplayString = "";
            this.menuFileNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNovo.Size = new System.Drawing.Size(180, 22);
            this.menuFileNovo.Text = "Novo";
            this.menuFileNovo.Click += new System.EventHandler(this.menuFileNovo_Click);
            // 
            // menuFileAbrir
            // 
            this.menuFileAbrir.Enabled = false;
            this.menuFileAbrir.Image = global::Formulario.Properties.Resources.open_256_icon_icons_com_76002;
            this.menuFileAbrir.Name = "menuFileAbrir";
            this.menuFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuFileAbrir.Text = "Abrir";
            this.menuFileAbrir.Click += new System.EventHandler(this.menuFileAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileSair
            // 
            this.menuFileSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuFileSair.ForeColor = System.Drawing.Color.DarkRed;
            this.menuFileSair.Image = global::Formulario.Properties.Resources.exit_icon_icons_com_70975;
            this.menuFileSair.Name = "menuFileSair";
            this.menuFileSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuFileSair.Size = new System.Drawing.Size(180, 22);
            this.menuFileSair.Text = "Sair";
            this.menuFileSair.Click += new System.EventHandler(this.menuFileSair_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpSobre});
            this.menuHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(49, 23);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpSobre
            // 
            this.menuHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubSobreDes,
            this.menuSubSobreVersion});
            this.menuHelpSobre.Name = "menuHelpSobre";
            this.menuHelpSobre.Size = new System.Drawing.Size(180, 22);
            this.menuHelpSobre.Text = "Sobre";
            // 
            // menuSubSobreDes
            // 
            this.menuSubSobreDes.Name = "menuSubSobreDes";
            this.menuSubSobreDes.Size = new System.Drawing.Size(168, 22);
            this.menuSubSobreDes.Text = "Desenvolvedor";
            this.menuSubSobreDes.Click += new System.EventHandler(this.menuSubSobreDes_Click);
            // 
            // menuSubSobreVersion
            // 
            this.menuSubSobreVersion.Name = "menuSubSobreVersion";
            this.menuSubSobreVersion.Size = new System.Drawing.Size(168, 22);
            this.menuSubSobreVersion.Text = "Versão";
            this.menuSubSobreVersion.Click += new System.EventHandler(this.menuSubSobreVersion_Click);
            // 
            // menuComboBox
            // 
            this.menuComboBox.Items.AddRange(new object[] {
            "English",
            "Portuguese"});
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(121, 23);
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // menuPesquisarTextBox
            // 
            this.menuPesquisarTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuPesquisarTextBox.Name = "menuPesquisarTextBox";
            this.menuPesquisarTextBox.Size = new System.Drawing.Size(200, 23);
            this.menuPesquisarTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.menuPesquisarTextBox_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 493);
            this.Controls.Add(this.btnSegundaFormThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaFormThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem menuSubSobreDes;
        private System.Windows.Forms.ToolStripMenuItem menuSubSobreVersion;
        private System.Windows.Forms.ToolStripComboBox menuComboBox;
        private System.Windows.Forms.ToolStripTextBox menuPesquisarTextBox;
    }
}

