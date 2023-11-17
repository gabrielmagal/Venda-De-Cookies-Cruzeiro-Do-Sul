using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_de_cookies
{
    public partial class LoginForm : Form
    {
        IniFile iniFile = new IniFile();

        public LoginForm()
        {
            InitializeComponent();
            refreshFeedback();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

            string passwordSaved = iniFile.Read("password", txbCpf.Text);
            if (txbPassword.Text == passwordSaved) {
                MessageBox.Show("Seja bem vindo(a) - " + txbCpf.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new RequestsForm(txbCpf.Text).ShowDialog();
                Application.Exit();
            }
            MessageBox.Show("Senha incorreta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Hide();
            new ForgotPasswordForm().ShowDialog();
            Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Hide();
            new NewUserForm().ShowDialog();
            Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Hide();
            new FeedbackForm().ShowDialog();
            Show();
        }

        public void refreshFeedback()
        {
            if (File.Exists(new FileInfo(Assembly.GetExecutingAssembly().GetName().Name + ".ini").FullName))
            {
                string[] allSectionsName = iniFile.ReadAllSectionsName();

                for (int i = 0; i < allSectionsName.Count(); i++)
                {
                    if (!allSectionsName[i].Contains("feedback"))
                    {
                        string feedback = iniFile.Read(allSectionsName[i], "feedback");
                        if(feedback != "")
                        {
                            txbFeedback.Text = allSectionsName[i] + " - " + feedback + Environment.NewLine;
                        }
                    }
                }
            }
        }
    }
}
