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
    public partial class NewUserForm : Form
    {

        IniFile iniFile = new IniFile();

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if(txbCpf.Text == "")
            {
                MessageBox.Show("É necessário informar o CPF do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbCpf.Text.Length != 11)
            {
                MessageBox.Show("O CPF informado não contém o número correto de caracteres.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbAddress.Text == "")
            {
                MessageBox.Show("É necessário informar o endereço do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbAddress.Text.Length < 10)
            {
                MessageBox.Show("É necessário informar um endereço válido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbDate.Text == "")
            {
                MessageBox.Show("É necessário informar a data de nascimento do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbDate.Text.Length != 10)
            {
                MessageBox.Show("O formato de data está incorreto (ex de formato válido: 10/10/2001).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbEmail.Text == "")
            {
                MessageBox.Show("É necessário informar o e-mail do usuário.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("O E-mail informado está incorreto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            iniFile.Write("name", txbName.Text, txbCpf.Text);
            iniFile.Write("address", txbAddress.Text, txbCpf.Text);
            iniFile.Write("date", txbDate.Text, txbCpf.Text);
            iniFile.Write("email", txbEmail.Text, txbCpf.Text);
            iniFile.Write("cpf", txbCpf.Text, txbCpf.Text);
            iniFile.Write("password", txbPassword.Text, txbCpf.Text);
            iniFile.Write("contadorpedidos", "0", txbCpf.Text);

            MessageBox.Show("Usuário criado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
