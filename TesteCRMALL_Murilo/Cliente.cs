using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCRMALL_Murilo
{
    public class Cliente
    {
        public int Cli_codigo { get; set; }
        public string Cli_Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string Cli_Numero { get; set; }
        public string Cli_Sexo { get; set; }
        public DateTime Cli_DataNascimento { get; set; }

        public Cliente()
        {
            Cli_codigo = 0;
            Cli_Nome = "";
            Cli_Sexo = "";
            Cli_Numero = "";
            Cli_DataNascimento = DateTime.Now;
            Endereco = new Endereco();
        }

        public Cliente(int cli_codigo, 
                       string cli_Nome, string cli_Sexo, string cli_Numero,
                       Endereco endereco, 
                       DateTime cli_DataNascimento)
        {
            Cli_codigo = cli_codigo;
            Cli_Nome = cli_Nome;
            Cli_Sexo = cli_Sexo;
            Cli_Numero = cli_Numero;
            Endereco = endereco;
            Cli_DataNascimento = cli_DataNascimento;
        }
    }
}
