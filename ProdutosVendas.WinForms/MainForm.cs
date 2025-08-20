using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdutosVendas.Application.Interfaces;
using ProdutosVendas.Domain.Entities;

namespace ProdutosVendas.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IProductService _service;
        private List<Product> _cache = new();

        // Construtor: o IProductService é injetado pelo Program.cs
        public MainForm(IProductService service)
        {
            InitializeComponent();
            _service = service;

            // Eventos de ciclo de vida / UI
            this.Load += MainForm_Load;
            gridProdutos.SelectionChanged += GridProdutos_SelectionChanged;

            // CRUD
            btnSalvar.Click += BtnSalvar_Click;
            btnAtualizar.Click += BtnAtualizar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnLimpar.Click += (_, __) => LimparCampos();
            btnNovo.Click += (_, __) => { LimparCampos(); txtNome.Focus(); };

            // Vendas
            cmbProduto.SelectedIndexChanged += CmbProduto_SelectedIndexChanged;
            btnSimular.Click += BtnSimular_Click;
            btnConfirmar.Click += BtnConfirmar_Click;
        }

        // ===================== LOAD / BINDINGS =====================

        private async void MainForm_Load(object? sender, EventArgs e)
        {
            ConfigurarGrid();
            await RecarregarProdutosAsync();
        }

        private void ConfigurarGrid()
        {
            // Config do DataGridView
            gridProdutos.AutoGenerateColumns = false;
            gridProdutos.ReadOnly = true;
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gridProdutos.Columns.Clear();
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", Width = 50 });
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Produto", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Barcode", HeaderText = "Cód. Barras", Width = 120 });
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Preço",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StockQuantity", HeaderText = "Estoque", Width = 80 });
            gridProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExpirationDate",
                HeaderText = "Validade",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });
        }

        private async Task RecarregarProdutosAsync()
        {
            // pega do serviço
            _cache = await _service.ListAsync();

            // grid
            gridProdutos.DataSource = _cache.ToList();

            // combo vendas
            cmbProduto.DisplayMember = nameof(Product.Name);
            cmbProduto.ValueMember = nameof(Product.Id);
            cmbProduto.DataSource = _cache.ToList();

            AtualizarInfoVenda(); // ajusta labels de preço/estoque
        }

        // ===================== CRUD (aba Produtos) =====================

        private void GridProdutos_SelectionChanged(object? sender, EventArgs e)
        {
            if (gridProdutos.CurrentRow?.DataBoundItem is Product p)
                PreencherCampos(p);
        }

        private void PreencherCampos(Product p)
        {
            txtId.Text = p.Id.ToString();
            txtNome.Text = p.Name;
            txtCodigoBarras.Text = p.Barcode;
            nudPreco.Value = p.UnitPrice;
            nudQuantidade.Value = p.StockQuantity;
            if (p.ExpirationDate.HasValue)
            {
                dtpValidade.Checked = true;
                dtpValidade.Value = p.ExpirationDate.Value;
            }
            else
            {
                dtpValidade.Checked = false;
            }
        }

        private Product LerCampos() => new Product
        {
            Id = int.TryParse(txtId.Text, out var id) ? id : 0,
            Name = txtNome.Text.Trim(),
            Barcode = string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ? null : txtCodigoBarras.Text.Trim(),
            UnitPrice = nudPreco.Value,
            StockQuantity = (int)nudQuantidade.Value,
            ExpirationDate = dtpValidade.Checked ? dtpValidade.Value.Date : null
        };

        private async void BtnSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                var novo = LerCampos();
                await _service.CreateAsync(novo);
                await RecarregarProdutosAsync();
                LimparCampos();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAtualizar_Click(object? sender, EventArgs e)
        {
            try
            {
                var edit = LerCampos();
                if (edit.Id == 0) { MessageBox.Show("Selecione um produto."); return; }
                await _service.UpdateAsync(edit);
                await RecarregarProdutosAsync();
                MessageBox.Show("Produto atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnExcluir_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out var id) || id == 0)
                {
                    MessageBox.Show("Selecione um produto."); return;
                }
                if (MessageBox.Show("Confirmar exclusão?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(id);
                    await RecarregarProdutosAsync();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCodigoBarras.Clear();
            nudPreco.Value = 0;
            nudQuantidade.Value = 0;
            dtpValidade.Checked = false;
        }

        // ===================== VENDAS (aba Vendas) =====================

        private void CmbProduto_SelectedIndexChanged(object? sender, EventArgs e) => AtualizarInfoVenda();

        private void AtualizarInfoVenda()
        {
            if (cmbProduto.SelectedItem is Product p)
            {
                lblPrecoUnitario.Text = $"Preço unitário: {p.UnitPrice:C2} | Estoque: {p.StockQuantity}";
                lblTotal.Text = "Total: R$ 0,00";
            }
            else
            {
                lblPrecoUnitario.Text = "Preço unitário: R$ 0,00 | Estoque: 0";
                lblTotal.Text = "Total: R$ 0,00";
            }
        }

        private async void BtnSimular_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cmbProduto.SelectedItem is not Product p) { MessageBox.Show("Selecione um produto."); return; }
                var qtd = (int)nudQtdVenda.Value;
                var total = await _service.SimulateSaleAsync(p.Id, qtd, applyStockUpdate: false);
                lblTotal.Text = $"Total: {total:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnConfirmar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cmbProduto.SelectedItem is not Product p) { MessageBox.Show("Selecione um produto."); return; }
                var qtd = (int)nudQtdVenda.Value;
                var total = await _service.SimulateSaleAsync(p.Id, qtd, applyStockUpdate: true);
                MessageBox.Show($"Venda registrada! Total: {total:C2}");
                await RecarregarProdutosAsync(); // atualiza estoque/combobox/grid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
