using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCRMALL_Murilo
{
    public class Conexao
    {
        private static string caminhoBanco = "localhost", usuarioBanco = "root", NomeBanco = "testecrmall", senhaBanco = "2327158";
        private static string strcon = string.Format("server={0};User Id={1};database={2};Pwd={3};", caminhoBanco, usuarioBanco, NomeBanco, senhaBanco); //@"server=localhost;User Id=root;database=agrojetvendas;Pwd=2327158;";
        private static string strconaux = "Allow Zero Datetime=True";

        private static MySqlConnection conexao;
        private static MySqlCommand com = new MySqlCommand();
        private static MySqlTransaction transaction;
        private static MySqlDataReader dr = null;

        public static MySqlCommand Com
        {
            get { return com; }
            set { com = value; }
        }

        public string MensagemTransacao { get; set; }
        public string ComandoSql { get; set; }

        public  bool Conecta()
        {
            MensagemTransacao = "";
            try
            {
                if (conexao == null || conexao.State == ConnectionState.Closed)
                {
                    conexao = new MySqlConnection(strcon + strconaux);
                    com.Connection = conexao;  //Tenta conectar no Ip Local 
                    conexao.Open();
                    return true;
                }
                else
                {
                    if (conexao != null && conexao.State == ConnectionState.Open)
                        return true;
                }
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
            }
            return false;
        }

        public bool Desconecta()
        {
            MensagemTransacao = "";
            try
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    return true;
                }
                else
                    MensagemTransacao = "A conexão não está aberta";
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
            }
            return false;
        }

        public bool BeginTransaction()
        {
            MensagemTransacao = "";
            try
            {
                if ((conexao != null) && (conexao.State == System.Data.ConnectionState.Open))
                {
                    Conecta();
                    transaction = conexao.BeginTransaction();
                    return true;
                }
                else
                    MensagemTransacao = "A conexão não está aberta";
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
            }
            return false;
        }

        public bool CommitTransaction()
        {
            MensagemTransacao = "";
            try
            {
                if ((conexao != null) && (transaction != null) && (conexao.State == System.Data.ConnectionState.Open))
                {
                    transaction.Commit();
                    transaction = null;
                    return true;
                }
                else
                    MensagemTransacao = "A conexão não está aberta";
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
            }
            return false;
        }

        public bool RollbackTransaction()
        {
            MensagemTransacao = "";
            try
            {
                if ((conexao != null) && (transaction != null) && (conexao.State == System.Data.ConnectionState.Open))
                {
                    transaction.Rollback();
                    transaction = null;
                    return true;
                }
                else
                    MensagemTransacao = "A conexão não está aberta";
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
            }
            return false;
        }

        public bool ExecuteQuery()
        {
            try
            {
                int lLinhasAfetadas = 0;
                com.CommandText = ComandoSql;
                lLinhasAfetadas = com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MensagemTransacao = ex.Message;
                return false;
            }
            finally
            {
                Desconecta();
            }
        }

        private  MySqlDataAdapter ExecutaDataAdapter(string strsql)
        {
            Conecta();
            MySqlDataAdapter da = new MySqlDataAdapter();
            com.CommandText = strsql;
            da.SelectCommand = com;
            return da;
        }

        public DataTable GetDataTable()
        {
            MySqlDataAdapter da = ExecutaDataAdapter(ComandoSql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        private  MySqlDataReader ExecutarDataReader(string sSQL)
        {
            Conecta();
            com.CommandText = sSQL;
            MySqlDataReader drReader = com.ExecuteReader();
            return drReader;
        }

        public  int GetInt32(string Sql)
        {
           // MySqlDataReader dr = new MySqlDataReader();
            try
            {
                int int32 = 0;
                MySqlDataReader dr = ExecutarDataReader(Sql);
                if (dr.Read())
                    int32 = dr.GetInt32(0);
                dr.Close();
                return int32;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
