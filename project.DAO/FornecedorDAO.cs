using CMS.br.com.projeto.conexao;
using CMS.br.com.projeto.MODEL;
using CMS.project.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.project.DAO
{
    public class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, complemento, bairro, cidade, estado, numero)
                                values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @complemento, @bairro, @cidade, @estado, @numero) ";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar: " + erro.Message);
            }
            //finally
            //{
            //    conexao.Close();
            //}
        }

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, 
                                celular=@celular, cep=@cep, endereco=@endereco, complemento=@complemento, 
                                    bairro=@bairro, cidade=@cidade, estado=@estado, numero=@numero
                                        where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar: " + erro.Message);
            }
            //finally
            //{
            //    conexao.Close(); 
            //}
        }

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir: " + erro.Message);
            }
            //finally
            //{
            //    conexao.Close(); 
            //}
        }


        public DataTable listarFornecedores()
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafornecedor);
                }

                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql " + erro);
                return null;
            }
            //finally
            //{
            //    conexao.Close(); 
            //}
        }
        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafornecedor);
                }

                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql " + erro);
                return null;
            }
            //finally
            //{
            //    conexao.Close(); 
            //}
        }


        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafornecedor);
                }

                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql " + erro);
                return null;
            }
            //finally
            //{
            //    conexao.Close(); 
            //}
        }


    }
}
