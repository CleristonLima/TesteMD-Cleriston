namespace TesteMDCleriston.Forms
{
    partial class CadastroProduto
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
            grpBoxCadastroProd = new GroupBox();
            btnFecharProd = new Button();
            btnSalvarProd = new Button();
            label2 = new Label();
            txtCodProd = new TextBox();
            txtQtdEstoque = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            lblObrigatorio = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            lblEstoque = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            lblNome = new Label();
            grpBoxCadastroProd.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxCadastroProd
            // 
            grpBoxCadastroProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadastroProd.Controls.Add(btnFecharProd);
            grpBoxCadastroProd.Controls.Add(btnSalvarProd);
            grpBoxCadastroProd.Controls.Add(label2);
            grpBoxCadastroProd.Controls.Add(txtCodProd);
            grpBoxCadastroProd.Controls.Add(txtQtdEstoque);
            grpBoxCadastroProd.Controls.Add(txtPreco);
            grpBoxCadastroProd.Controls.Add(txtDescricao);
            grpBoxCadastroProd.Controls.Add(txtNome);
            grpBoxCadastroProd.Controls.Add(label1);
            grpBoxCadastroProd.Controls.Add(lblObrigatorio);
            grpBoxCadastroProd.Controls.Add(btnFechar);
            grpBoxCadastroProd.Controls.Add(btnSalvar);
            grpBoxCadastroProd.Controls.Add(lblEstoque);
            grpBoxCadastroProd.Controls.Add(lblPreco);
            grpBoxCadastroProd.Controls.Add(lblDescricao);
            grpBoxCadastroProd.Controls.Add(lblNome);
            grpBoxCadastroProd.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCadastroProd.Location = new Point(12, 12);
            grpBoxCadastroProd.Name = "grpBoxCadastroProd";
            grpBoxCadastroProd.Size = new Size(860, 464);
            grpBoxCadastroProd.TabIndex = 1;
            grpBoxCadastroProd.TabStop = false;
            grpBoxCadastroProd.Text = "CADASTRO DE PRODUTO";
            // 
            // btnFecharProd
            // 
            btnFecharProd.Anchor = AnchorStyles.Bottom;
            btnFecharProd.BackColor = Color.Red;
            btnFecharProd.ForeColor = SystemColors.ControlLightLight;
            btnFecharProd.Location = new Point(707, 408);
            btnFecharProd.Name = "btnFecharProd";
            btnFecharProd.Size = new Size(98, 38);
            btnFecharProd.TabIndex = 19;
            btnFecharProd.Text = "Fechar";
            btnFecharProd.UseVisualStyleBackColor = false;
            btnFecharProd.Click += btnFecharProd_Click;
            // 
            // btnSalvarProd
            // 
            btnSalvarProd.Anchor = AnchorStyles.Bottom;
            btnSalvarProd.BackColor = Color.Green;
            btnSalvarProd.ForeColor = SystemColors.ControlLightLight;
            btnSalvarProd.Location = new Point(578, 408);
            btnSalvarProd.Name = "btnSalvarProd";
            btnSalvarProd.Size = new Size(98, 38);
            btnSalvarProd.TabIndex = 18;
            btnSalvarProd.Text = "Salvar";
            btnSalvarProd.UseVisualStyleBackColor = false;
            btnSalvarProd.Click += btnSalvarProd_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 385);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 17;
            label2.Text = "* Campos Obrigatórios";
            // 
            // txtCodProd
            // 
            txtCodProd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProd.Location = new Point(171, 56);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.ReadOnly = true;
            txtCodProd.Size = new Size(81, 27);
            txtCodProd.TabIndex = 16;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtdEstoque.Location = new Point(138, 324);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(328, 27);
            txtQtdEstoque.TabIndex = 15;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(138, 254);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(328, 27);
            txtPreco.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(138, 186);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(705, 27);
            txtDescricao.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(138, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(705, 27);
            txtNome.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 59);
            label1.Name = "label1";
            label1.Size = new Size(143, 19);
            label1.TabIndex = 11;
            label1.Text = "Codigo do produto:";
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.Anchor = AnchorStyles.Left;
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObrigatorio.Location = new Point(29, 506);
            lblObrigatorio.Name = "lblObrigatorio";
            lblObrigatorio.Size = new Size(147, 18);
            lblObrigatorio.TabIndex = 10;
            lblObrigatorio.Text = "* Campos Obrigatórios";
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom;
            btnFechar.BackColor = Color.Red;
            btnFechar.ForeColor = SystemColors.ControlLightLight;
            btnFechar.Location = new Point(1130, 720);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(98, 38);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom;
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(998, 720);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(22, 327);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(110, 19);
            lblEstoque.TabIndex = 3;
            lblEstoque.Text = "* Qtd Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(22, 257);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(64, 19);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "* Preço:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(22, 189);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(90, 19);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "* Descrição:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(22, 120);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "* Nome:";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 495);
            Controls.Add(grpBoxCadastroProd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE PRODUTO";
            grpBoxCadastroProd.ResumeLayout(false);
            grpBoxCadastroProd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCadastroProd;
        private Label lblObrigatorio;
        private Button btnFechar;
        private Button btnSalvar;
        private Label lblEstoque;
        private Label lblPreco;
        private Label lblDescricao;
        private Label lblNome;
        private Label label1;
        private TextBox txtCodProd;
        private TextBox txtQtdEstoque;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Label label2;
        private Button btnSalvarProd;
        private Button btnFecharProd;
    }
}