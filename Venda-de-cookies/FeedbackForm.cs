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
    public partial class FeedbackForm : Form
    {
        IniFile iniFile = new IniFile();

        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
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

            if (txbFeedback.Text.Length < 10)
            {
                MessageBox.Show("Precisamos informar no minimo 10 caracteres como feedback.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            iniFile.Write(txbCpf.Text, txbFeedback.Text, "feedback");
            MessageBox.Show("Feedback enviado com sucesso! Obrigado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
