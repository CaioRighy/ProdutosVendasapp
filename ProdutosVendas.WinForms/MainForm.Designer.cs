namespace ProdutosVendas.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabProdutos = new TabPage();
            gridProdutos = new DataGridView();
            grpCadastro = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            dtpValidade = new DateTimePicker();
            lblValidade = new Label();
            nudQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            nudPreco = new NumericUpDown();
            lblPreco = new Label();
            txtCodigoBarras = new TextBox();
            lblCodigoBarras = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtId = new TextBox();
            lblId = new Label();
            tabVendas = new TabPage();
            nudQtdVenda = new NumericUpDown();
            cmbProduto = new ComboBox();
            btnConfirmar = new Button();
            btnSimular = new Button();
            lblTotal = new Label();
            lblPrecoUnitario = new Label();
            tabControl1.SuspendLayout();
            tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            grpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            tabVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdVenda).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProdutos);
            tabControl1.Controls.Add(tabVendas);
            tabControl1.Location = new Point(10, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabProdutos
            // 
            tabProdutos.Controls.Add(gridProdutos);
            tabProdutos.Controls.Add(grpCadastro);
            tabProdutos.Location = new Point(4, 24);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.Padding = new Padding(3);
            tabProdutos.Size = new Size(781, 420);
            tabProdutos.TabIndex = 0;
            tabProdutos.Text = "Produtos";
            tabProdutos.UseVisualStyleBackColor = true;
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Dock = DockStyle.Fill;
            gridProdutos.Location = new Point(3, 302);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProdutos.Size = new Size(775, 115);
            gridProdutos.TabIndex = 17;
            // 
            // grpCadastro
            // 
            grpCadastro.Controls.Add(btnLimpar);
            grpCadastro.Controls.Add(btnExcluir);
            grpCadastro.Controls.Add(btnAtualizar);
            grpCadastro.Controls.Add(btnSalvar);
            grpCadastro.Controls.Add(btnNovo);
            grpCadastro.Controls.Add(dtpValidade);
            grpCadastro.Controls.Add(lblValidade);
            grpCadastro.Controls.Add(nudQuantidade);
            grpCadastro.Controls.Add(lblQuantidade);
            grpCadastro.Controls.Add(nudPreco);
            grpCadastro.Controls.Add(lblPreco);
            grpCadastro.Controls.Add(txtCodigoBarras);
            grpCadastro.Controls.Add(lblCodigoBarras);
            grpCadastro.Controls.Add(txtNome);
            grpCadastro.Controls.Add(lblNome);
            grpCadastro.Controls.Add(txtId);
            grpCadastro.Controls.Add(lblId);
            grpCadastro.Dock = DockStyle.Top;
            grpCadastro.Location = new Point(3, 3);
            grpCadastro.Name = "grpCadastro";
            grpCadastro.Size = new Size(775, 299);
            grpCadastro.TabIndex = 0;
            grpCadastro.TabStop = false;
            grpCadastro.Text = "Cadastro";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(391, 263);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(296, 263);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(201, 263);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(106, 263);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 263);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtpValidade
            // 
            dtpValidade.Location = new Point(115, 222);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.ShowCheckBox = true;
            dtpValidade.Size = new Size(200, 23);
            dtpValidade.TabIndex = 11;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(6, 222);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(57, 15);
            lblValidade.TabIndex = 10;
            lblValidade.Text = "Validade :";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(115, 173);
            nudQuantidade.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 9;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(6, 175);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(75, 15);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade :";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(117, 130);
            nudPreco.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 7;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(3, 132);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(43, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço :";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(115, 85);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(100, 23);
            txtCodigoBarras.TabIndex = 5;
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Location = new Point(6, 85);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(103, 15);
            lblCodigoBarras.TabIndex = 4;
            lblCodigoBarras.Text = "Código de barras :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome :";
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id :";
            // 
            // tabVendas
            // 
            tabVendas.Controls.Add(nudQtdVenda);
            tabVendas.Controls.Add(cmbProduto);
            tabVendas.Controls.Add(btnConfirmar);
            tabVendas.Controls.Add(btnSimular);
            tabVendas.Controls.Add(lblTotal);
            tabVendas.Controls.Add(lblPrecoUnitario);
            tabVendas.Location = new Point(4, 24);
            tabVendas.Name = "tabVendas";
            tabVendas.Padding = new Padding(3);
            tabVendas.Size = new Size(781, 420);
            tabVendas.TabIndex = 1;
            tabVendas.Text = "Vendas";
            tabVendas.UseVisualStyleBackColor = true;
            // 
            // nudQtdVenda
            // 
            nudQtdVenda.Location = new Point(19, 54);
            nudQtdVenda.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQtdVenda.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQtdVenda.Name = "nudQtdVenda";
            nudQtdVenda.Size = new Size(120, 23);
            nudQtdVenda.TabIndex = 1;
            nudQtdVenda.TextAlign = HorizontalAlignment.Right;
            nudQtdVenda.ThousandsSeparator = true;
            nudQtdVenda.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbProduto
            // 
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(19, 8);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(166, 205);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar venda";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            btnSimular.Location = new Point(23, 205);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(75, 23);
            btnSimular.TabIndex = 4;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(23, 152);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(19, 113);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(127, 15);
            lblPrecoUnitario.TabIndex = 2;
            lblPrecoUnitario.Text = "`Preço unitário: R$ 0,00";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            grpCadastro.ResumeLayout(false);
            grpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            tabVendas.ResumeLayout(false);
            tabVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProdutos;
        private TabPage tabVendas;
        private GroupBox grpCadastro;
        private TextBox txtId;
        private Label lblId;
        private DateTimePicker dtpValidade;
        private Label lblValidade;
        private NumericUpDown nudQuantidade;
        private Label lblQuantidade;
        private NumericUpDown nudPreco;
        private Label lblPreco;
        private TextBox txtCodigoBarras;
        private Label lblCodigoBarras;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnSalvar;
        private Button btnNovo;
        private DataGridView gridProdutos;
        private Button btnConfirmar;
        private Button btnSimular;
        private Label lblTotal;
        private Label lblPrecoUnitario;
        private NumericUpDown nudQtdVenda;
        private ComboBox cmbProduto;
    }
}
