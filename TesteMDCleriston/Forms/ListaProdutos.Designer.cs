namespace TesteMDCleriston.Forms
{
    partial class ListaProdutos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpBoxCadastroCliente = new GroupBox();
            btnPesquisar = new Button();
            txtCodProd = new TextBox();
            lblObrigatorio = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            lblCodProd = new Label();
            dataGridViewProdutos = new DataGridView();
            grpBoxCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // grpBoxCadastroCliente
            // 
            grpBoxCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadastroCliente.Controls.Add(btnPesquisar);
            grpBoxCadastroCliente.Controls.Add(txtCodProd);
            grpBoxCadastroCliente.Controls.Add(lblObrigatorio);
            grpBoxCadastroCliente.Controls.Add(btnFechar);
            grpBoxCadastroCliente.Controls.Add(btnSalvar);
            grpBoxCadastroCliente.Controls.Add(lblCodProd);
            grpBoxCadastroCliente.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCadastroCliente.Location = new Point(12, 12);
            grpBoxCadastroCliente.Name = "grpBoxCadastroCliente";
            grpBoxCadastroCliente.Size = new Size(767, 120);
            grpBoxCadastroCliente.TabIndex = 2;
            grpBoxCadastroCliente.TabStop = false;
            grpBoxCadastroCliente.Text = "CONSULTAR PRODUTO";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.Yellow;
            btnPesquisar.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(557, 42);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(126, 38);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCodProd
            // 
            txtCodProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodProd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProd.Location = new Point(167, 53);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(216, 27);
            txtCodProd.TabIndex = 11;
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.Anchor = AnchorStyles.Left;
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObrigatorio.Location = new Point(29, 344);
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
            btnFechar.Location = new Point(1331, 396);
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
            btnSalvar.Location = new Point(1199, 396);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodProd.Location = new Point(18, 56);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(143, 19);
            lblCodProd.TabIndex = 3;
            lblCodProd.Text = "Codigo do produto:";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProdutos.BackgroundColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProdutos.Location = new Point(12, 147);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(823, 291);
            dataGridViewProdutos.TabIndex = 3;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(grpBoxCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA DE PRODUTOS";
            grpBoxCadastroCliente.ResumeLayout(false);
            grpBoxCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCadastroCliente;
        private Button btnPesquisar;
        private TextBox txtCodProd;
        private Label lblObrigatorio;
        private Button btnFechar;
        private Button btnSalvar;
        private Label lblCodProd;
        private DataGridView dataGridViewProdutos;
    }
}