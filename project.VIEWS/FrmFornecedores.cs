using CMS.br.com.projeto.DAO;
using CMS.br.com.projeto.MODEL;
using CMS.project.DAO;
using CMS.project.MODEL;
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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.cnpj = txtcnpj.Text;
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

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().limparTela(this);
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.listarFornecedores()
;        }

        private void tabelaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.cnpj = txtcnpj.Text;
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

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().limparTela(this);
        }

        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtcomp.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tabelaFornecedores.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().limparTela(this);
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado!");
                tabelaFornecedor.DataSource = dao.listarFornecedores();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.listarFornecedorPorNome(nome);
        }
    }
}
