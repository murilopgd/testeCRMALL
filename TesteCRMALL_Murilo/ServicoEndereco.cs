using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TesteCRMALL_Murilo
{
    public class ServicoEndereco
    {
        string EnderecoServico;

        public string MensagemErro { get; set; }

        public ServicoEndereco()
        {
            EnderecoServico = "https://viacep.com.br/ws/";
        }


        public Endereco ObterEndereco(string cep)
        {
            try
            {
                MensagemErro = "";
                string endereco = EnderecoServico + cep.Replace("-", "") + "/json/";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endereco);
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MensagemErro = "Servidor indisponível";
                    return null; // Sai da rotina
                }
                Stream webStream = ChecaServidor.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                return ((Endereco)JsonConvert.DeserializeObject(response, typeof(Endereco)));
            }
            catch(Exception e)
            {
                MensagemErro = e.Message;
                return null;
            }
        }

        public string EstadoUF(string uf)
        {
            switch(uf)
            {
                case "AC":
                    return "Acre";
                case "AL":
                    return "Alagoas";
                case "AP":
                    return "Amapá";
                case "AM":
                    return "Amazonas";
                case "BA":
                    return "Bahia";
                case "CE":
                    return "Ceará";
                case "DF":
                    return "Distrito Federal";
                case "ES":
                    return "Espírito Santo";
                case "GO":
                    return "Goiás";
                case "MA":
                    return "Maranhão";
                case "MT":
                    return "Mato Grosso";
                case "MS":
                    return "Mato Grosso do Sul";
                case "MG":
                    return "Minas Gerais";
                case "PA":
                    return "Pará";
                case "PB":
                    return "Paraíba";
                case "PR":
                    return "Paraná";
                case "PE":
                    return "Pernambuco";
                case "PI":
                    return "Piauí";
                case "RJ":
                    return "Rio de Janeiro";
                case "RN":
                    return "Rio Grande do Norte";
                case "RS":
                    return "Rio Grande do Sul";
                case "RO":
                    return "Rondônia";
                case "RR":
                    return "Roraima";
                case "SC":
                    return "Santa Catarina";
                case "SP":
                    return "São Paulo";
                case "SE":
                    return "Sergipe";
                case "TO":
                    return "Tocantins";
                default:
                    return "";
            }
        }

    }
}
