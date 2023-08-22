using CMS.br.com.projeto.conexao;
using CMS.br.com.projeto.MODEL;
using CMS.project.MODEL;
using CMS.project.VIEWS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.project.DAO
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, complemento, bairro, cidade, estado, numero)
                                values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @complemento, @bairro, @cidade, @estado, @numero) ";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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
                MessageBox.Show("Funcionário cadastrado com sucesso!");
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

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso,
                                telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, complemento=@complemento, 
                                    bairro=@bairro, cidade=@cidade, estado=@estado, numero=@numero
                                        where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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
                MessageBox.Show("Funcionário atualizado com sucesso!");
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

        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id=@id";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário excluído com sucesso!");
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

        public DataTable listarFuncionarios()
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafuncionario);
                }

                return tabelafuncionario;
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

        public DataTable buscarFuncionariosPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {
                    
                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafuncionario);

                    
                }

                return tabelafuncionario;
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

        public DataTable listarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))
                {

                    conexao.Open();
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafuncionario);
                }

                return tabelafuncionario;
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

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email and senha = @senha";
                using (MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString))

                {
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@email", email);
                    executacmd.Parameters.AddWithValue("@senha", senha);

                    conexao.Open();

                    using (MySqlDataReader reader = executacmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nivel = reader.GetString("nivel_acesso");
                            string nome = reader.GetString("nome");

                            FrmMenu telamenu = new FrmMenu();
                                
                            telamenu.txtusuario.Text =  nome;

                            if (nivel.Equals("Administrador"))
                            {
                                telamenu.Show();
                            }
                            else if (nivel.Equals("Vendedor"))
                            {
                                //telamenu.menuProdutos.Visible = false;
                                telamenu.menuProdutos.Enabled = false;
                                telamenu.menuHistóricoDeVendas.Enabled = false;

                                telamenu.Show();
                            }


                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretas!");
                            return false;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return false;
            }

            return false;
        }


    }
}
