namespace TesteMDCleriston.Forms
{
    partial class RegistrarVenda
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
            groupBox1 = new GroupBox();
            btnFecharVenda = new Button();
            btnRegistrar = new Button();
            txtPrecoTotal = new TextBox();
            txtQtd = new TextBox();
            cbxProduto = new ComboBox();
            cbxCliente = new ComboBox();
            label4 = new Label();
            lblPrecoTotal = new Label();
            lblQty = new Label();
            label1 = new Label();
            lblNome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnFecharVenda);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtPrecoTotal);
            groupBox1.Controls.Add(txtQtd);
            groupBox1.Controls.Add(cbxProduto);
            groupBox1.Controls.Add(cbxCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblPrecoTotal);
            groupBox1.Controls.Add(lblQty);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 425);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRAR VENDA";
            // 
            // btnFecharVenda
            // 
            btnFecharVenda.Anchor = AnchorStyles.Bottom;
            btnFecharVenda.BackColor = Color.Red;
            btnFecharVenda.ForeColor = SystemColors.ControlLightLight;
            btnFecharVenda.Location = new Point(542, 367);
            btnFecharVenda.Name = "btnFecharVenda";
            btnFecharVenda.Size = new Size(98, 38);
            btnFecharVenda.TabIndex = 35;
            btnFecharVenda.Text = "Fechar";
            btnFecharVenda.UseVisualStyleBackColor = false;
            btnFecharVenda.Click += btnFecharVenda_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom;
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(400, 367);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(108, 38);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecoTotal.Location = new Point(145, 280);
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.ReadOnly = true;
            txtPrecoTotal.Size = new Size(196, 27);
            txtPrecoTotal.TabIndex = 33;
            // 
            // txtQtd
            // 
            txtQtd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtd.Location = new Point(145, 209);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(196, 27);
            txtQtd.TabIndex = 32;
            txtQtd.TextChanged += txtQtd_TextChanged;
            // 
            // cbxProduto
            // 
            cbxProduto.Font = new Font("Calibri", 12F);
            cbxProduto.FormattingEnabled = true;
            cbxProduto.Location = new Point(145, 140);
            cbxProduto.Name = "cbxProduto";
            cbxProduto.Size = new Size(458, 27);
            cbxProduto.TabIndex = 31;
            cbxProduto.SelectedIndexChanged += cbxProduto_SelectedIndexChanged;
            // 
            // cbxCliente
            // 
            cbxCliente.Font = new Font("Calibri", 12F);
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(145, 71);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(458, 27);
            cbxCliente.TabIndex = 30;
            cbxCliente.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 347);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 29;
            label4.Text = "* Campos Obrigatórios";
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoTotal.Location = new Point(16, 283);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(123, 19);
            lblPrecoTotal.TabIndex = 24;
            lblPrecoTotal.Text = "* Preço Total R$:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(16, 212);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(105, 19);
            lblQty.TabIndex = 23;
            lblQty.Text = "* Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 140);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 22;
            label1.Text = "* Produto:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(16, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(72, 19);
            lblNome.TabIndex = 21;
            lblNome.Text = "* Cliente:";
            // 
            // RegistrarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 449);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR VENDA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPrecoTotal;
        private Label lblQty;
        private Label label1;
        private Label lblNome;
        private Label label4;
        private ComboBox cbxCliente;
        private ComboBox cbxProduto;
        private TextBox txtPrecoTotal;
        private TextBox txtQtd;
        private Button btnRegistrar;
        private Button btnFecharVenda;
    }
}