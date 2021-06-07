using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCRMALL_Murilo
{
    public partial class FormCadastroClientes : Form
    {
        Cliente _Cliente;
        List<Cliente> _Clientes;
        DAO_Cliente cliDAO;
        ServicoEndereco servico;

        public FormCadastroClientes()
        {
            InitializeComponent();
            cliDAO = new DAO_Cliente();
            _Clientes = new List<Cliente>();
            _Cliente = new Cliente();
            servico = new ServicoEndereco();
        }

        private void TxtCepCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCepCliente.Text.Replace("-","").Replace(" ","") != "")
            {
                if (_Cliente == null)
                    _Cliente = new Cliente();
                _Cliente.Endereco = servico.ObterEndereco(TxtCepCliente.Text);
                if(_Cliente.Endereco==null)
                    MessageBox.Show("Erro: "+servico.MensagemErro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    TxtEnderecoCliente.Text = _Cliente.Endereco.Logradouro;
                    TxtNumeroCliente.Text = "";
                    TxtBairroCliente.Text = _Cliente.Endereco.Bairro;
                    TxtCidadeCliente.Text = _Cliente.Endereco.Localidade;
                    CbEstadoCliente.Text = servico.EstadoUF(_Cliente.Endereco.Uf);
                }
            }
        }

        private void Controletela(bool controle)
        {
            TxtNomeCliente.ReadOnly = !controle;
            TxtEnderecoCliente.ReadOnly = !controle;
            TxtBairroCliente.ReadOnly = !controle;
            TxtNumeroCliente.ReadOnly = !controle;
            TxtComplementoCliente.ReadOnly = !controle;
            TxtCidadeCliente.ReadOnly = !controle;
            TxtCepCliente.ReadOnly = !controle;
            CbSexoCliente.Enabled = controle;
            CbEstadoCliente.Enabled = controle;
            DtpDataNascimentoCliente.Enabled = controle;
        }

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            BtnCancelar.PerformClick();
        }

        private void PreencherCampos(Cliente cliente)
        {
            if(cliente!=null)
            {
                TxtNomeCliente.Text = cliente.Cli_Nome;
                DtpDataNascimentoCliente.Value = cliente.Cli_DataNascimento;
                CbSexoCliente.Text = cliente.Cli_Sexo;
                TxtCepCliente.Text = cliente.Endereco.Cep;
                TxtEnderecoCliente.Text = cliente.Endereco.Logradouro;
                TxtNumeroCliente.Text = cliente.Cli_Numero;
                TxtBairroCliente.Text = cliente.Endereco.Bairro;
                TxtComplementoCliente.Text = cliente.Endereco.Complemento;
                TxtCidadeCliente.Text = cliente.Endereco.Localidade;
                CbEstadoCliente.Text = cliente.Endereco.Uf;
            }
            else
            {
                TxtNomeCliente.Text = "";
                DtpDataNascimentoCliente.Value = DateTime.Now;
                CbSexoCliente.SelectedItem = null;
                TxtCepCliente.Text = "";
                TxtEnderecoCliente.Text = "";
                TxtNumeroCliente.Text = "";
                TxtBairroCliente.Text = "";
                TxtComplementoCliente.Text = "";
                TxtCidadeCliente.Text = "";
                CbEstadoCliente.Text = "";
            }
            _Cliente = cliente;
        }

        private bool ValidarCliente()
        {
            if (TxtNomeCliente.Text == "")
            {
                MessageBox.Show("É necessário preencher o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNomeCliente.Focus();
                return false;
            }
            else
            {
                if ((_Cliente == null || _Cliente.Cli_codigo==0) && cliDAO.ObterCliente(TxtNomeCliente.Text) != null)
                {
                    MessageBox.Show("Já existe um cliente com esse nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtNomeCliente.Focus();
                    return false;
                }
            }
            if (CbSexoCliente.Text == "")
            {
                MessageBox.Show("É necessário preencher o sexo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbSexoCliente.Focus();
                return false;
            }
            if (DtpDataNascimentoCliente.Value.Date>DateTime.Now.Date)
            {
                MessageBox.Show("Data inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DtpDataNascimentoCliente.Focus();
                return false;
            }
            if(_Cliente != null && _Cliente.Cli_codigo > 0 &&
                TxtNomeCliente.Text == _Cliente.Cli_Nome &&
                DtpDataNascimentoCliente.Value == _Cliente.Cli_DataNascimento &&
                CbSexoCliente.Text == _Cliente.Cli_Sexo &&
                TxtCepCliente.Text == _Cliente.Endereco.Cep &&
                TxtEnderecoCliente.Text == _Cliente.Endereco.Logradouro &&
                TxtNumeroCliente.Text == _Cliente.Cli_Numero &&
                TxtBairroCliente.Text == _Cliente.Endereco.Bairro &&
                TxtComplementoCliente.Text == _Cliente.Endereco.Complemento &&
                TxtCidadeCliente.Text == _Cliente.Endereco.Localidade &&
                CbEstadoCliente.Text == _Cliente.Endereco.Uf )
            {
                MessageBox.Show("Nada foi alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNomeCliente.Focus();
                return false;
            }
            return true;
        }

        private void AlterarBotaoExcluir(bool visivel)
        {
            BtnExcluir.Enabled = visivel;
            BtnGravar.Enabled = visivel;
        }

        private void Cancelar()
        {
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnGravar.Enabled = false;
            BtnLocalizar.Enabled = true;
            BtnNovo.Enabled = true;
        }

        private void Usar()
        {
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGravar.Enabled = true;
            BtnLocalizar.Enabled = false;
            BtnNovo.Enabled = false;
            //btnEditar.Enabled = false; 
            //btnSearch.Enabled = false;
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            BtnExcluir.Enabled = false;
            PreencherCampos(null);
            _Clientes = cliDAO.ObterClientes();
            if (cliDAO.MensagemTransacao != "")
                MessageBox.Show("Erro:" + cliDAO.MensagemTransacao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_Clientes == null || !_Clientes.Any())
                    MessageBox.Show("Não existem sócios cadastrados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FormPesquisaClientes fpc = new FormPesquisaClientes(_Clientes);
                    fpc.ShowDialog();
                    AlterarBotaoExcluir(fpc.Cliente != null);
                    Controletela(fpc.Cliente != null);
                    PreencherCampos(fpc.Cliente);
                    TxtNomeCliente.Focus();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PreencherCampos(null);
            Cancelar();
            Controletela(false);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PreencherCampos(null);
            Usar();
            BtnNovo.Focus();
            Controletela(true);
            TxtNomeCliente.Focus();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                _Cliente = new Cliente(
                _Cliente == null ? 0 : _Cliente.Cli_codigo,
                TxtNomeCliente.Text,
                CbSexoCliente.Text,
                TxtNumeroCliente.Text,
                new Endereco(                    
                    TxtCepCliente.Text,
                    TxtEnderecoCliente.Text,
                    TxtComplementoCliente.Text,
                    TxtBairroCliente.Text,
                    TxtCidadeCliente.Text,
                    CbEstadoCliente.Text,"","","",""),
                DtpDataNascimentoCliente.Value);
                string msg = _Cliente.Cli_codigo > 0 ? "alterado" : "cadastrado";
                if ((_Cliente.Cli_codigo > 0 && cliDAO.alterar(_Cliente)) ||
                    cliDAO.incluir(_Cliente))
                {                    
                    MessageBox.Show($"Cliente {msg} com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnCancelar_Click(sender, e);
                }
                else
                    MessageBox.Show("Erro:" + cliDAO.MensagemTransacao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (_Cliente != null && _Cliente.Cli_codigo > 0 && MessageBox.Show($"Deseja excluir este Cliente!?", "Cadastro de Clientes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                cliDAO.excluir(_Cliente.Cli_codigo);
                BtnCancelar_Click(sender, e);
            }
        }

        private void FormCadastroClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}"); //e.SuppressKeyPress = true;
        }
    }
}
