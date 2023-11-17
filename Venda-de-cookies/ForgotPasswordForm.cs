using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_de_cookies
{
    public partial class ForgotPasswordForm : Form
    {
        IniFile iniFile = new IniFile();

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txbCpf.Text == "")
            {
                MessageBox.Show("É necessário informar o CPF do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbCpf.Text.Length != 11)
            {
                MessageBox.Show("O CPF informado não contém o número correto de caracteres.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbPassword.Text == "")
            {
                MessageBox.Show("É necessário informar a senha do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbPassword.Text.Length < 9)
            {
                MessageBox.Show("A senha do usuário deve ter no minimo 9 caracteres.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool bExistSection = iniFile.ReadAllSectionsName().Contains(txbCpf.Text);

            if(bExistSection)
            {
                iniFile.Write("password", txbPassword.Text, txbCpf.Text);
                MessageBox.Show("Senha alterada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
