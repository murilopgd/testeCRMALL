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
    public partial class FormPesquisaClientes : Form
    {
        List<Cliente> _Clientes;

        public Cliente Cliente { get;private set; }
        public FormPesquisaClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            _Clientes = clientes;
            Cliente = null;
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.Rows.Count > 0 && DgvClientes.CurrentRow != null)
            {
                TxtPesquisa.Visible = false;
                Cliente = _Clientes[DgvClientes.CurrentRow.Index];
                if (Cliente != null)
                    this.Close();
            }
        }

        private void DgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && DgvClientes.CurrentRow.Index == 0)
                TxtPesquisa.Focus();
            if (e.KeyCode == Keys.Enter)
            {
                DgvClientes_CellDoubleClick(sender, null);
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Cliente cli = _Clientes.FirstOrDefault(c =>
            c.Cli_Nome.Contains(TxtPesquisa.Text));
            if (TxtPesquisa.Text != "" && cli != null)
                DgvClientes.CurrentCell =
                DgvClientes.Rows[_Clientes.IndexOf(cli)].Cells["cli_nome"];
            else
                DgvClientes.ClearSelection();
        }

        private void DgvClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvClientes.ClearSelection();
        }

        private void FormPesquisaClientes_Load(object sender, EventArgs e)
        {
            DgvClientes.DataSource = _Clientes;
            TxtPesquisa.Focus();
        }

        private void TxtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
                DgvClientes.Focus();
        }
    }
}
