namespace FitLanches
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCodigoProduto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            System.Windows.Forms.Label lblValor;
            System.Windows.Forms.Label lblQnt;
            System.Windows.Forms.Label lblCodigoVenda;
            System.Windows.Forms.Label lblTotal;
            this.DgvCardapio = new System.Windows.Forms.DataGridView();
            this.lblCardapio = new System.Windows.Forms.Label();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.timerStatus3 = new System.Windows.Forms.Timer(this.components);
            this.timerStatus4 = new System.Windows.Forms.Timer(this.components);
            this.btnNovaVenda = new System.Windows.Forms.Button();
            lblCodigoProduto = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
            lblQnt = new System.Windows.Forms.Label();
            lblCodigoVenda = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            resources.ApplyResources(lblCodigoProduto, "lblCodigoProduto");
            lblCodigoProduto.Name = "lblCodigoProduto";
            // 
            // lblValor
            // 
            resources.ApplyResources(lblValor, "lblValor");
            lblValor.Name = "lblValor";
            // 
            // lblQnt
            // 
            resources.ApplyResources(lblQnt, "lblQnt");
            lblQnt.Name = "lblQnt";
            // 
            // lblCodigoVenda
            // 
            resources.ApplyResources(lblCodigoVenda, "lblCodigoVenda");
            lblCodigoVenda.Name = "lblCodigoVenda";
            // 
            // lblTotal
            // 
            resources.ApplyResources(lblTotal, "lblTotal");
            lblTotal.Name = "lblTotal";
            // 
            // DgvCardapio
            // 
            this.DgvCardapio.AllowUserToAddRows = false;
            this.DgvCardapio.AllowUserToDeleteRows = false;
            this.DgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DgvCardapio, "DgvCardapio");
            this.DgvCardapio.Name = "DgvCardapio";
            this.DgvCardapio.ReadOnly = true;
            // 
            // lblCardapio
            // 
            resources.ApplyResources(this.lblCardapio, "lblCardapio");
            this.lblCardapio.Name = "lblCardapio";
            // 
            // btnNovoItem
            // 
            resources.ApplyResources(this.btnNovoItem, "btnNovoItem");
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Items.AddRange(new object[] {
            resources.GetString("cbProdutos.Items"),
            resources.GetString("cbProdutos.Items1"),
            resources.GetString("cbProdutos.Items2"),
            resources.GetString("cbProdutos.Items3"),
            resources.GetString("cbProdutos.Items4"),
            resources.GetString("cbProdutos.Items5"),
            resources.GetString("cbProdutos.Items6"),
            resources.GetString("cbProdutos.Items7")});
            resources.ApplyResources(this.cbProdutos, "cbProdutos");
            this.cbProdutos.Name = "cbProdutos";
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.Name = "txtValor";
            // 
            // txtQnt
            // 
            resources.ApplyResources(this.txtQnt, "txtQnt");
            this.txtQnt.Name = "txtQnt";
            // 
            // txtCodVenda
            // 
            resources.ApplyResources(this.txtCodVenda, "txtCodVenda");
            this.txtCodVenda.Name = "txtCodVenda";
            // 
            // DgvPedido
            // 
            this.DgvPedido.AllowUserToAddRows = false;
            this.DgvPedido.AllowUserToDeleteRows = false;
            this.DgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DgvPedido, "DgvPedido");
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            resources.ApplyResources(this.btnFinalizar, "btnFinalizar");
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // listViewStatus
            // 
            resources.ApplyResources(this.listViewStatus, "listViewStatus");
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            this.listViewStatus.View = System.Windows.Forms.View.List;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 300000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // timerStatus3
            // 
            this.timerStatus3.Interval = 310000;
            this.timerStatus3.Tick += new System.EventHandler(this.timerStatus3_Tick);
            // 
            // timerStatus4
            // 
            this.timerStatus4.Interval = 320000;
            this.timerStatus4.Tick += new System.EventHandler(this.timerStatus4_Tick);
            // 
            // btnNovaVenda
            // 
            resources.ApplyResources(this.btnNovaVenda, "btnNovaVenda");
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // FrmPedido
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.listViewStatus);
            this.Controls.Add(lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.DgvPedido);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(lblCodigoProduto);
            this.Controls.Add(this.cbProdutos);
            this.Controls.Add(lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(lblQnt);
            this.Controls.Add(this.txtQnt);
            this.Controls.Add(lblCodigoVenda);
            this.Controls.Add(this.txtCodVenda);
            this.Controls.Add(this.lblCardapio);
            this.Controls.Add(this.DgvCardapio);
            this.Name = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCardapio;
        private System.Windows.Forms.Label lblCardapio;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Timer timerStatus3;
        private System.Windows.Forms.Timer timerStatus4;
        private System.Windows.Forms.Button btnNovaVenda;
    }
}

