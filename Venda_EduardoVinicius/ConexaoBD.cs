using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Venda_EduardoVinicius
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security info = false;server=localhost;database=bd_venda_alunos;user=root;pwd=;");
                conexao.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Insert - delete - Update
        public int AlterarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        //Select
        public DataTable ConsultarDados(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
