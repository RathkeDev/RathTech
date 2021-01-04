using System;
using System.Collections.Generic;
using MySqlConnector;
using projetoMVC.Models;

namespace projetoMVC.Models
{
    public class CadastroBanco
    {
        
        private const string dadosConexao = "Database=ProjetoIntegrador; Data Source=localhost; User Id=root; PassWord=gareth11";

    
        public void Inserir (Cadastro novoCadastro)
         
        {
             
           
            using (MySqlConnection Conexao = new MySqlConnection (dadosConexao))
            
            {
                Conexao.Open();

                string query = "INSERT INTO Cadastro(Nome, Cpf, Fone, DataNascimento, Sexo, Cep, Endereco, Senha) VALUES (@Nome, @Cpf, @Fone, @DataNascimento, @Sexo,  @Cep,  @Endereco, @Senha)";
                
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.AddWithValue("@Nome", novoCadastro.Nome);
                comando.Parameters.AddWithValue("@Cpf", novoCadastro.Cpf);
                comando.Parameters.AddWithValue("@Fone", novoCadastro.Fone);
                comando.Parameters.AddWithValue("@DataNascimento", novoCadastro.DataNascimento);
                comando.Parameters.AddWithValue("@Sexo", novoCadastro.Sexo);
                comando.Parameters.AddWithValue("@Cep", novoCadastro.Cep);
                comando.Parameters.AddWithValue("@Endereco", novoCadastro.Endereco);
                comando.Parameters.AddWithValue("@Senha", novoCadastro.Senha);

                comando.ExecuteNonQuery();

                
                Conexao.Close();
            }
        }

        public List<Cadastro> Query() 
        {
            MySqlConnection Conexao = new MySqlConnection (dadosConexao);
           

            Conexao.Open();

            string query = "SELECT * FROM Cadastro";
            
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            
            
            {
                List<Cadastro> lista = new List<Cadastro>();
                while (reader.Read())
                    {
                        Cadastro cadastro = new Cadastro();
                       
                        
                    if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    {
                        cadastro.Nome = reader.GetString("Nome");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Cpf")))
                    {
                       cadastro.DataNascimento = reader.GetString("Cpf");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Fone")))
                    {
                        cadastro.Fone = reader.GetString("Fone");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                    {
                        cadastro.DataNascimento = reader.GetString("DataNascimento");
                    }    
                    if (!reader.IsDBNull(reader.GetOrdinal("Sexo")))
                    {
                        cadastro.Senha = reader.GetString("Sexo");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Cep")))
                    {
                        cadastro.Senha = reader.GetString("Cep");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Endereco")))
                    {
                        cadastro.Senha = reader.GetString("Endereco");
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    {
                        cadastro.Senha = reader.GetString("Senha");
                    }
                    lista.Add(cadastro); 
                }
                Conexao.Close();
                return lista;
                    

            }

            
            
           

        }

       
    }
}