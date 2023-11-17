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
    public partial class RequestsForm : Form
    {
        string cpfSaved = null;

        IniFile iniFile = new IniFile();

        public RequestsForm()
        {
            InitializeComponent();
        }

        public RequestsForm(string userCpf)
        {
            InitializeComponent();
            cpfSaved = userCpf;
            ltvRequests.Items.Clear();
            int contadorPedidos = int.Parse(iniFile.Read("contadorpedidos", cpfSaved));
            for (int i = 0; i < contadorPedidos; i++)
            {
                ltvRequests.Items.Add(iniFile.Read("pedido" + (i + 1), cpfSaved));
            }
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            Hide();
            new NewRequestForm(cpfSaved).ShowDialog();
            Show();
        }

        private void btnUpdateListRequests_Click(object sender, EventArgs e)
        {
            ltvRequests.Items.Clear();
            int contadorPedidos = int.Parse(iniFile.Read("contadorpedidos", cpfSaved));
            for (int i = 0; i < contadorPedidos; i++)
            {
                ltvRequests.Items.Add(iniFile.Read("pedido" + (i+1), cpfSaved));
            }

            MessageBox.Show("Lista atualizada com sucesso.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
