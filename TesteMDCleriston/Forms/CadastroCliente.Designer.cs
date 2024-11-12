namespace TesteMDCleriston.Forms
{
    partial class CadastroCliente
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
            grpBoxCadastroCliente = new GroupBox();
            lblObrigatorio = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtEnd = new TextBox();
            txtNome = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            grpBoxCadastroCliente.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxCadastroCliente
            // 
            grpBoxCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadastroCliente.Controls.Add(lblObrigatorio);
            grpBoxCadastroCliente.Controls.Add(btnFechar);
            grpBoxCadastroCliente.Controls.Add(btnSalvar);
            grpBoxCadastroCliente.Controls.Add(txtEmail);
            grpBoxCadastroCliente.Controls.Add(txtTelefone);
            grpBoxCadastroCliente.Controls.Add(txtEnd);
            grpBoxCadastroCliente.Controls.Add(txtNome);
            grpBoxCadastroCliente.Controls.Add(lblEmail);
            grpBoxCadastroCliente.Controls.Add(lblTelefone);
            grpBoxCadastroCliente.Controls.Add(lblEndereco);
            grpBoxCadastroCliente.Controls.Add(lblNome);
            grpBoxCadastroCliente.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCadastroCliente.Location = new Point(13, 12);
            grpBoxCadastroCliente.Name = "grpBoxCadastroCliente";
            grpBoxCadastroCliente.Size = new Size(931, 412);
            grpBoxCadastroCliente.TabIndex = 0;
            grpBoxCadastroCliente.TabStop = false;
            grpBoxCadastroCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.Anchor = AnchorStyles.Left;
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObrigatorio.Location = new Point(29, 324);
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
            btnFechar.Location = new Point(800, 356);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(98, 38);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom;
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(668, 356);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(117, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(807, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(117, 192);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(807, 27);
            txtTelefone.TabIndex = 6;
            // 
            // txtEnd
            // 
            txtEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEnd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnd.Location = new Point(117, 119);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(807, 27);
            txtEnd.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(117, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(807, 27);
            txtNome.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(22, 274);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "* Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(22, 195);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(83, 19);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "* Telefone:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(22, 122);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(89, 19);
            lblEndereco.TabIndex = 1;
            lblEndereco.Text = "* Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(22, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "* Nome:";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 431);
            Controls.Add(grpBoxCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE CLIENTE";
            grpBoxCadastroCliente.ResumeLayout(false);
            grpBoxCadastroCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCadastroCliente;
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblEndereco;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtEnd;
        private Label lblObrigatorio;
        private Button btnFechar;
        private Button btnSalvar;
    }
}