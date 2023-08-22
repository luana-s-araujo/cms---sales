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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.buscarFuncionariosPorNome(nome);

            if (tabelaFuncionario.Rows.Count == 0 || txtpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");
                tabelaFuncionario.DataSource = dao.listarFuncionarios();
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtcomp.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);    

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarioPorNome(nome);


        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
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
    }
}
