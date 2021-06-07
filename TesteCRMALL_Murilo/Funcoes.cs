using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCRMALL_Murilo
{
    public class Funcoes
    {
        public static int proximocodigo(string tabela, string campo)
        {
            try
            {
                string sql = "SELECT COALESCE(MAX(" + campo + "), 0) FROM " + tabela + " ";
                return new Conexao().GetInt32(sql) + 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
