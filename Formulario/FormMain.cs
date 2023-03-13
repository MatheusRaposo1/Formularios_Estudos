using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSegunda f = new FormSegunda("Bem-Vindo!!!");
            //f.Mensagem = "Matheus";
            //f.Show();
            f.ShowDialog();
            if (f.Mensagem != null)
            {
                lblTitulo.Text = f.Mensagem;
            }
            this.Show();

        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda()));
            t.Start();
        }

        private void menuFileNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void menuFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();
        }

        private void menuFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuSubSobreDes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matheus Raposo !!");
        }

        private void menuSubSobreVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuComboBox.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            }
            else 
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }    
        }

        private void menuPesquisarTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblTitulo.Text = menuPesquisarTextBox.Text;
                menuPesquisarTextBox = null;
            }
        }
    }
}
