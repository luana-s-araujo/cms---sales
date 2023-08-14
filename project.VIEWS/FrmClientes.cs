using CMS.br.com.projeto.DAO;
using CMS.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.br.com.projeto.VIEWS
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            tabelaFuncionarios.DataSource = dao.listarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            tabelaFuncionarios.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tabelaFuncionarios.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();

            tabelaFuncionarios.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcomp.Text = tabelaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaFuncionarios.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            tabelaFuncionarios.DataSource = dao.listarClientes();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaFuncionarios.DataSource = dao.buscarClientePorNome(nome);

            if(tabelaFuncionarios.Rows.Count == 0)
            {
                tabelaFuncionarios.DataSource = dao.listarClientes();
            }
        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaFuncionarios.DataSource = dao.listarClientesPorNome(nome);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;

                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, digite manualmente!");
            }
        }
    }
}
