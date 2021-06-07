using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCRMALL_Murilo
{
    public class DAO_Cliente : Conexao
    {

        public bool incluir(Cliente cliente)
        {
            if (Conecta())
            {
                cliente.Cli_codigo = Funcoes.proximocodigo("cliente", "cli_codigo");
                ComandoSql = @"insert into 
                    cliente(CLI_CODIGO, CLI_DATANASCIMENTO, CLI_SEXO, CLI_NOME, CLI_CEP, CLI_ENDERECO, 
                            CLI_NUMERO, CLI_COMPLEMENTO, CLI_BAIRRO, CLI_CIDADE, CLI_ESTADO) 
                    values (@CODIGO, @DATANASCIMENTO, @SEXO, @NOME, @CEP, @ENDERECO, 
                            @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @ESTADO)";
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@CODIGO", cliente.Cli_codigo);
                Com.Parameters.AddWithValue("@DATANASCIMENTO", cliente.Cli_DataNascimento);
                Com.Parameters.AddWithValue("@SEXO", cliente.Cli_Sexo);
                Com.Parameters.AddWithValue("@NOME", cliente.Cli_Nome);
                Com.Parameters.AddWithValue("@CEP", cliente.Endereco.Cep);
                Com.Parameters.AddWithValue("@ENDERECO", cliente.Endereco.Logradouro);
                Com.Parameters.AddWithValue("@NUMERO", cliente.Cli_Numero);
                Com.Parameters.AddWithValue("@COMPLEMENTO", cliente.Endereco.Complemento);
                Com.Parameters.AddWithValue("@BAIRRO", cliente.Endereco.Bairro);
                Com.Parameters.AddWithValue("@CIDADE", cliente.Endereco.Localidade);
                Com.Parameters.AddWithValue("@ESTADO", cliente.Endereco.Uf);
                return ExecuteQuery();
            }
            return false;
        }

        public bool alterar(Cliente cliente)
        {
            if (Conecta())
            {
                ComandoSql = @"update cliente set 
                    CLI_DATANASCIMENTO=@DATANASCIMENTO, 
                    CLI_SEXO=@SEXO, 
                    CLI_NOME=@NOME, 
                    CLI_CEP=@CEP, 
                    CLI_ENDERECO=@ENDERECO, 
                    CLI_NUMERO=@NUMERO, 
                    CLI_COMPLEMENTO=@COMPLEMENTO, 
                    CLI_BAIRRO=@BAIRRO, 
                    CLI_CIDADE=@CIDADE, 
                    CLI_ESTADO=@ESTADO
                    where CLI_CODIGO = @CODIGO";
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@CODIGO", cliente.Cli_codigo);
                Com.Parameters.AddWithValue("@DATANASCIMENTO", cliente.Cli_DataNascimento);
                Com.Parameters.AddWithValue("@SEXO", cliente.Cli_Sexo);
                Com.Parameters.AddWithValue("@NOME", cliente.Cli_Nome);
                Com.Parameters.AddWithValue("@CEP", cliente.Endereco.Cep);
                Com.Parameters.AddWithValue("@ENDERECO", cliente.Endereco.Logradouro);
                Com.Parameters.AddWithValue("@NUMERO", cliente.Cli_Numero);
                Com.Parameters.AddWithValue("@COMPLEMENTO", cliente.Endereco.Complemento);
                Com.Parameters.AddWithValue("@BAIRRO", cliente.Endereco.Bairro);
                Com.Parameters.AddWithValue("@CIDADE", cliente.Endereco.Localidade);
                Com.Parameters.AddWithValue("@ESTADO", cliente.Endereco.Uf);
                return ExecuteQuery();
            }
            return false;
        }

        public bool excluir(int id)
        {
            if (Conecta())
            {
                ComandoSql = "delete from cliente where cli_codigo = @cod";
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@cod", id);
                return ExecuteQuery();
            }
            return false;
        }

        public List<Cliente> ObterClientes()
        {
            if (Conecta())
            {
                ComandoSql = @"select * from cliente";
                DataTable dt = GetDataTable();
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<Cliente> Clientes = new List<Cliente>();
                    foreach (DataRow linha in dt.Rows)
                    {
                        Clientes.Add(new Cliente(
                    Convert.ToInt32(linha["cli_codigo"]),
                    linha["cli_nome"].ToString(),
                    linha["cli_sexo"].ToString(),
                    linha["cli_numero"].ToString(),
                    new Endereco(linha["cli_cep"].ToString(),
                    linha["cli_endereco"].ToString(),
                    linha["cli_complemento"].ToString(),
                    linha["cli_bairro"].ToString(),
                    linha["cli_cidade"].ToString(),
                    linha["cli_estado"].ToString(), "", "", "", ""),
                        Convert.ToDateTime(linha["cli_DataNascimento"].ToString()).Date));
                    }
                    return Clientes;
                }
            }
            return null;
        }



        public Cliente ObterCliente(int codigo)
        {
            if (Conecta())
            {
                ComandoSql = "select * from cliente where cli_codigo= @cod";
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@cod", codigo);
                DataTable dt = GetDataTable();
                if (dt != null && dt.Rows.Count > 0)
                {
                    return new Cliente(
                    Convert.ToInt32(dt.Rows[0]["cli_codigo"]),
                    dt.Rows[0]["cli_nome"].ToString(),
                    dt.Rows[0]["cli_sexo"].ToString(),
                    dt.Rows[0]["cli_numero"].ToString(),
                    new Endereco(dt.Rows[0]["cli_cep"].ToString(),
                    dt.Rows[0]["cli_endereco"].ToString(),
                    dt.Rows[0]["cli_complemento"].ToString(),
                    dt.Rows[0]["cli_bairro"].ToString(),
                    dt.Rows[0]["cli_cidade"].ToString(),
                    dt.Rows[0]["cli_estado"].ToString(),"","","",""),
                        Convert.ToDateTime(dt.Rows[0]["cli_DataNascimento"].ToString()).Date);
                }
            }
            return null;
        }


        public Cliente ObterCliente(string nome)
        {
            if (Conecta())
            {
                ComandoSql = "select * from cliente where cli_nome= @nome";
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@nome", nome);
                DataTable dt = GetDataTable();
                if (dt != null && dt.Rows.Count > 0)
                {
                    return new Cliente(
                    Convert.ToInt32(dt.Rows[0]["cli_codigo"]),
                    dt.Rows[0]["cli_nome"].ToString(),
                    dt.Rows[0]["cli_sexo"].ToString(),
                    dt.Rows[0]["cli_numero"].ToString(),
                    new Endereco(dt.Rows[0]["cli_cep"].ToString(),
                    dt.Rows[0]["cli_endereco"].ToString(),
                    dt.Rows[0]["cli_complemento"].ToString(),
                    dt.Rows[0]["cli_bairro"].ToString(),
                    dt.Rows[0]["cli_cidade"].ToString(),
                    dt.Rows[0]["cli_estado"].ToString(), "", "", "", ""),
                        Convert.ToDateTime(dt.Rows[0]["cli_DataNascimento"].ToString()).Date);
                }
            }
            return null;
        }
    }
}
