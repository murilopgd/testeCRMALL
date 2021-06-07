using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteCRMALL_Murilo.Properties;

namespace TesteCRMALL_Murilo
{
    public partial class FormConfiguracoes : Form
    {
        Settings settings;
        public FormConfiguracoes()
        {
            InitializeComponent();
            settings = new Settings();
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            if(settings != null)
            {
                TxtServidor.Text = settings.caminhoBanco;
                TxtBase.Text = settings.nomeBanco;
                TxtUsuario.Text = settings.usuarioBanco;
                TxtSenha.Text = settings.senhaBanco;
            }
        }

        private void FormConfiguracoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((TxtServidor.Text != settings.caminhoBanco ||
                TxtBase.Text != settings.nomeBanco ||
                TxtUsuario.Text != settings.usuarioBanco ||
                TxtSenha.Text != settings.senhaBanco) &&
            MessageBox.Show($"Deseja salvar as alterações!?", "Configurações",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                settings.caminhoBanco= TxtServidor.Text;
                settings.nomeBanco= TxtBase.Text;
                settings.usuarioBanco= TxtUsuario.Text;
                settings.senhaBanco= TxtSenha.Text;
                settings.Save();
            }
        }
    }
}
