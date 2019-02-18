using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace FitLanches
{
    public partial class FrmPedido : Form
    {

        public FrmPedido()
        {
            InitializeComponent();

        }
        int codigo;
        List<Pedido> PedidoObj = new List<Pedido>();

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            PedidoObj.Add(new Pedido()
            {
                Cod = int.Parse(txtCodVenda.Text),
                Item = cbProdutos.Text,
                Qtde = int.Parse(txtQnt.Text),
                Valor = int.Parse(txtValor.Text),                
            });

            DgvPedido.DataSource = null;
            DgvPedido.DataSource = PedidoObj;

            cbProdutos.Text = "";
            txtQnt.Text = "";
            txtValor.Text = "";
            txtTotal.Text = "";
            txtCodVenda.Enabled = false;

            if (DgvPedido.RowCount == 2)
            {
                MessageBox.Show("O cliente ganhou um suco de brinde");
            }
            SomaValores();
        }
        private Cozinha ObjCozinha;
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ObjCozinha = new Cozinha();
            txtTotal.Text = "";            
            DgvPedido.DataSource = null;
            codigo = int.Parse(txtCodVenda.Text);
            listViewStatus.Items.Add("Pedido: " + Convert.ToString(codigo) + " - " + ObjCozinha.status1);
            timerStatus.Enabled = true;
            timerStatus3.Enabled = true;
            timerStatus4.Enabled = true;
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            listViewStatus.Refresh();
            listViewStatus.Items.Add("Pedido: " + Convert.ToString(codigo) + " - " + ObjCozinha.status2);
            timerStatus.Enabled = false;
        }

        private void timerStatus3_Tick(object sender, EventArgs e)
        {
            listViewStatus.Refresh();
            listViewStatus.Items.Add("Pedido: " + Convert.ToString(codigo) + " - " + ObjCozinha.status3);
            timerStatus3.Enabled = false;
        }

        private void timerStatus4_Tick(object sender, EventArgs e)
        {
            listViewStatus.Refresh();
            listViewStatus.Items.Add("Pedido: " + Convert.ToString(codigo) + " - " + ObjCozinha.status4);
            timerStatus3.Enabled = false;
        }

        private void SomaValores()
        {
            int total = 0;
            foreach (DataGridViewRow dg in DgvPedido.Rows)
            {
                int v1 = Convert.ToInt32(dg.Cells[2].Value);
                int v2 = Convert.ToInt32(dg.Cells[3].Value);
                int subtotal = v1 * v2;
                total = total + subtotal;
                txtTotal.Text = Convert.ToString(total);
            }

        }

        private void CarregaLista()
        {
            var cSeparador = ";";
            var dt = new DataTable();
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Tempo de Preparo (segundos)");

            var Arquivo = new System.IO.StreamReader(@"C:\FitLanches\Cardapio.txt");

            while (Arquivo.Peek() != -1)
            {
                dt.Rows.Add(Arquivo.ReadLine().Split(Convert.ToChar(cSeparador)));
            }

            DgvCardapio.DataSource = dt;
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            txtCodVenda.Text = "";
            listViewStatus.Clear();
        }
        
    }
}
