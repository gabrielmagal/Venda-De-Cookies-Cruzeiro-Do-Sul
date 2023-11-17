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
    public partial class NewRequestForm : Form
    {
        string cpfSaved = null;

        IniFile iniFile = new IniFile();

        public NewRequestForm()
        {
            InitializeComponent();
        }

        public NewRequestForm(string userCpf)
        {
            InitializeComponent();
            cpfSaved = userCpf;
        }

        private void btnCookieChocolate_Click(object sender, EventArgs e)
        {
            ltvRequests.Items.Add(new Random().Next(1, 9000) + " - Cookie de Chocolate - $20");
            MessageBox.Show("Item adicionado com sucesso ao carrinho!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCookieMorango_Click(object sender, EventArgs e)
        {
            ltvRequests.Items.Add(new Random().Next(1, 9000) + " - Cookie de Morango - $20");
            MessageBox.Show("Item adicionado com sucesso ao carrinho!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCookieAoLeite_Click(object sender, EventArgs e)
        {
            ltvRequests.Items.Add(new Random().Next(1, 9000) + " - Cookie ao Leite - $20");
            MessageBox.Show("Item adicionado com sucesso ao carrinho!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection itens = ltvRequests.Items;
            for (int i = 0; i < itens.Count; i++) {
                if (itens[i].Text.Contains(txbRemove.Text))
                {
                    ltvRequests.Items[i].Remove();
                    MessageBox.Show("Item Removido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection itens = ltvRequests.Items;

            if (itens.Count == 0)
            {
                MessageBox.Show("Não foi possível continuar a operação, pois seu carrinho está vazio.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string formaDePagamento = "";

            if (rdbDinheiro.Checked)
            {
                formaDePagamento = "Dinheiro";
            }
            else if (rdbDebito.Checked)
            {
                formaDePagamento = "Débito";
            }
            else if (rdbCredito.Checked)
            {
                formaDePagamento = "Crédito";
            }
            else if (rdbPix.Checked)
            {
                formaDePagamento = "Pix";
            }

            if(formaDePagamento == "")
            {
                MessageBox.Show("Não é possível prosseguir sem definir uma forma de pagamento.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int contadorDePedidos = int.Parse(iniFile.Read("contadorpedidos", cpfSaved));

            for (int i = 0; i < itens.Count; i++)
            {
                contadorDePedidos++;
                iniFile.Write("pedido" + contadorDePedidos, itens[i].Text + " - " +  formaDePagamento, cpfSaved);
            }
            iniFile.Write("contadorpedidos", contadorDePedidos.ToString(), cpfSaved);
            MessageBox.Show("Pedido feito com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
