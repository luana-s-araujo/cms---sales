using CMS.br.com.projeto.conexao;
using CMS.br.com.projeto.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.br.com.projeto.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection conexao; 

        public ClienteDAO()
        {
            conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, complemento, bairro, cidade, estado, numero)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @complemento, @bairro, @cidade, @estado, @numero) ";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                MessageBox.Show("Cliente cadastrado com sucesso!");
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

        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, 
                                celular=@celular, cep=@cep, endereco=@endereco, complemento=@complemento, 
                                    bairro=@bairro, cidade=@cidade, estado=@estado, numero=@numero
                                        where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                MessageBox.Show("Cliente atualizado com sucesso!");
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

        public void excluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"delete from tb_clientes where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso!");
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

        public DataTable listarClientes()
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelacliente);
                }

                return tabelacliente;
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

        public DataTable buscarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
             
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelacliente);
                }

                return tabelacliente;
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


        public DataTable listarClientesPorNome(string nome)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {

                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelacliente);
                }

                return tabelacliente;
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
