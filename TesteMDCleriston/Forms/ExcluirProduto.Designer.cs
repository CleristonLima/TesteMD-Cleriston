namespace TesteMDCleriston.Forms
{
    partial class ExcluirProduto
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
            grpBoxConsultaProduto = new GroupBox();
            btnPesquisar = new Button();
            txtCodProd = new TextBox();
            lblCodProd = new Label();
            grpBoxCadProd = new GroupBox();
            btnFecharProduto = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            txtQtdEstoque = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnFecharProd = new Button();
            btnSalvarProd = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            lblEstoque = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            lblNome = new Label();
            grpBoxConsultaProduto.SuspendLayout();
            grpBoxCadProd.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxConsultaProduto
            // 
            grpBoxConsultaProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxConsultaProduto.Controls.Add(btnPesquisar);
            grpBoxConsultaProduto.Controls.Add(txtCodProd);
            grpBoxConsultaProduto.Controls.Add(lblCodProd);
            grpBoxConsultaProduto.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            grpBoxConsultaProduto.Location = new Point(12, 12);
            grpBoxConsultaProduto.Name = "grpBoxConsultaProduto";
            grpBoxConsultaProduto.Size = new Size(699, 107);
            grpBoxConsultaProduto.TabIndex = 1;
            grpBoxConsultaProduto.TabStop = false;
            grpBoxConsultaProduto.Text = "CONSULTAR PRODUTO";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Yellow;
            btnPesquisar.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(534, 37);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 38);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCodProd
            // 
            txtCodProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodProd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProd.Location = new Point(172, 45);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(243, 27);
            txtCodProd.TabIndex = 12;
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodProd.Location = new Point(11, 48);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(155, 19);
            lblCodProd.TabIndex = 4;
            lblCodProd.Text = "* Codigo do produto:";
            // 
            // grpBoxCadProd
            // 
            grpBoxCadProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadProd.Controls.Add(btnFecharProduto);
            grpBoxCadProd.Controls.Add(btnExcluir);
            grpBoxCadProd.Controls.Add(label1);
            grpBoxCadProd.Controls.Add(txtQtdEstoque);
            grpBoxCadProd.Controls.Add(txtPreco);
            grpBoxCadProd.Controls.Add(txtDescricao);
            grpBoxCadProd.Controls.Add(btnFecharProd);
            grpBoxCadProd.Controls.Add(btnSalvarProd);
            grpBoxCadProd.Controls.Add(label2);
            grpBoxCadProd.Controls.Add(txtNome);
            grpBoxCadProd.Controls.Add(lblEstoque);
            grpBoxCadProd.Controls.Add(lblPreco);
            grpBoxCadProd.Controls.Add(lblDescricao);
            grpBoxCadProd.Controls.Add(lblNome);
            grpBoxCadProd.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            grpBoxCadProd.Location = new Point(12, 136);
            grpBoxCadProd.Name = "grpBoxCadProd";
            grpBoxCadProd.Size = new Size(815, 377);
            grpBoxCadProd.TabIndex = 2;
            grpBoxCadProd.TabStop = false;
            grpBoxCadProd.Text = "CADASTRO DE PRODUTO";
            // 
            // btnFecharProduto
            // 
            btnFecharProduto.Anchor = AnchorStyles.Bottom;
            btnFecharProduto.BackColor = Color.Red;
            btnFecharProduto.ForeColor = SystemColors.ControlLightLight;
            btnFecharProduto.Location = new Point(673, 319);
            btnFecharProduto.Name = "btnFecharProduto";
            btnFecharProduto.Size = new Size(98, 38);
            btnFecharProduto.TabIndex = 36;
            btnFecharProduto.Text = "Fechar";
            btnFecharProduto.UseVisualStyleBackColor = false;
            btnFecharProduto.Click += btnFecharProduto_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.BackColor = Color.Green;
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(534, 319);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 38);
            btnExcluir.TabIndex = 35;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 297);
            label1.Name = "label1";
            label1.Size = new Size(147, 18);
            label1.TabIndex = 34;
            label1.Text = "* Campos Obrigatórios";
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQtdEstoque.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtdEstoque.Location = new Point(123, 239);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(257, 27);
            txtQtdEstoque.TabIndex = 33;
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPreco.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(123, 169);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(257, 27);
            txtPreco.TabIndex = 32;
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(123, 101);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(669, 27);
            txtDescricao.TabIndex = 31;
            // 
            // btnFecharProd
            // 
            btnFecharProd.Anchor = AnchorStyles.Bottom;
            btnFecharProd.BackColor = Color.Red;
            btnFecharProd.ForeColor = SystemColors.ControlLightLight;
            btnFecharProd.Location = new Point(1002, 604);
            btnFecharProd.Name = "btnFecharProd";
            btnFecharProd.Size = new Size(98, 38);
            btnFecharProd.TabIndex = 30;
            btnFecharProd.Text = "Fechar";
            btnFecharProd.UseVisualStyleBackColor = false;
            // 
            // btnSalvarProd
            // 
            btnSalvarProd.Anchor = AnchorStyles.Bottom;
            btnSalvarProd.BackColor = Color.Green;
            btnSalvarProd.ForeColor = SystemColors.ControlLightLight;
            btnSalvarProd.Location = new Point(873, 604);
            btnSalvarProd.Name = "btnSalvarProd";
            btnSalvarProd.Size = new Size(98, 38);
            btnSalvarProd.TabIndex = 29;
            btnSalvarProd.Text = "Salvar";
            btnSalvarProd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 440);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 28;
            label2.Text = "* Campos Obrigatórios";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(123, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(669, 27);
            txtNome.TabIndex = 24;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(10, 242);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(110, 19);
            lblEstoque.TabIndex = 23;
            lblEstoque.Text = "* Qtd Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(10, 172);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(64, 19);
            lblPreco.TabIndex = 22;
            lblPreco.Text = "* Preço:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(10, 104);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(90, 19);
            lblDescricao.TabIndex = 21;
            lblDescricao.Text = "* Descrição:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(10, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 19);
            lblNome.TabIndex = 20;
            lblNome.Text = "* Nome:";
            // 
            // ExcluirProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 525);
            Controls.Add(grpBoxCadProd);
            Controls.Add(grpBoxConsultaProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ExcluirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EXCLUIR PRODUTO";
            grpBoxConsultaProduto.ResumeLayout(false);
            grpBoxConsultaProduto.PerformLayout();
            grpBoxCadProd.ResumeLayout(false);
            grpBoxCadProd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxConsultaProduto;
        private Button btnPesquisar;
        private TextBox txtCodProd;
        private Label lblCodProd;
        private GroupBox grpBoxCadProd;
        private TextBox txtQtdEstoque;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Button btnFecharProd;
        private Button btnSalvarProd;
        private Label label2;
        private TextBox txtNome;
        private Label lblEstoque;
        private Label lblPreco;
        private Label lblDescricao;
        private Label lblNome;
        private Label label1;
        private Button btnExcluir;
        private Button btnFecharProduto;
    }
}