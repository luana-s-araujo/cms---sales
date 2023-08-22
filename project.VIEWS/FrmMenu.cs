using CMS.br.com.projeto.VIEWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.project.VIEWS
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToLongTimeString();
        }

        private void txthora_Click(object sender, EventArgs e)
        {

        }

        private void menuCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();

            tela.ShowDialog();
            //tela.Show();
        }

        private void menuConsultaCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();

            tela.tabClientes.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void menuCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();

            tela.ShowDialog();
            //tela.Show();
        }

        private void menuConsultaFuncionario_Click(object sender, EventArgs e)
        {

            FrmFuncionarios tela = new FrmFuncionarios();

            tela.tabFuncionarios.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void menuSairSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide(); // Esconde a tela atual
                FrmLogin telaLogin = new FrmLogin(); // Crie uma instância da tela de login
                telaLogin.Show(); // Mostra a tela de login
            }
            
        }
    }
}
