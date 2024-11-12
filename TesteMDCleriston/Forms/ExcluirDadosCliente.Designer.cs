namespace TesteMDCleriston.Forms
{
    partial class ExcluirDadosCliente
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
            btnPesquisar = new Button();
            txtEmailConsulta = new TextBox();
            lblObrigatorio = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            lblEmail = new Label();
            grpBoxCliente = new GroupBox();
            btnFechar2 = new Button();
            btnExcluir = new Button();
            label4 = new Label();
            txtEmailDel = new TextBox();
            txtTelefone = new TextBox();
            txtEnd = new TextBox();
            txtNome = new TextBox();
            btnFechar1 = new Button();
            btnAlterar = new Button();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            lblTelefone = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            grpBoxCadastroCliente.SuspendLayout();
            grpBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxCadastroCliente
            // 
            grpBoxCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadastroCliente.Controls.Add(btnPesquisar);
            grpBoxCadastroCliente.Controls.Add(txtEmailConsulta);
            grpBoxCadastroCliente.Controls.Add(lblObrigatorio);
            grpBoxCadastroCliente.Controls.Add(btnFechar);
            grpBoxCadastroCliente.Controls.Add(btnSalvar);
            grpBoxCadastroCliente.Controls.Add(lblEmail);
            grpBoxCadastroCliente.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCadastroCliente.Location = new Point(11, 12);
            grpBoxCadastroCliente.Name = "grpBoxCadastroCliente";
            grpBoxCadastroCliente.Size = new Size(852, 113);
            grpBoxCadastroCliente.TabIndex = 3;
            grpBoxCadastroCliente.TabStop = false;
            grpBoxCadastroCliente.Text = "CONSULTAR CLIENTE";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Yellow;
            btnPesquisar.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(705, 45);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 38);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtEmailConsulta
            // 
            txtEmailConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmailConsulta.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailConsulta.Location = new Point(86, 53);
            txtEmailConsulta.Name = "txtEmailConsulta";
            txtEmailConsulta.Size = new Size(580, 27);
            txtEmailConsulta.TabIndex = 11;
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.Anchor = AnchorStyles.Left;
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObrigatorio.Location = new Point(29, 346);
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
            btnFechar.Location = new Point(1700, 402);
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
            btnSalvar.Location = new Point(1568, 402);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(18, 56);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "* Email:";
            // 
            // grpBoxCliente
            // 
            grpBoxCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCliente.Controls.Add(btnFechar2);
            grpBoxCliente.Controls.Add(btnExcluir);
            grpBoxCliente.Controls.Add(label4);
            grpBoxCliente.Controls.Add(txtEmailDel);
            grpBoxCliente.Controls.Add(txtTelefone);
            grpBoxCliente.Controls.Add(txtEnd);
            grpBoxCliente.Controls.Add(txtNome);
            grpBoxCliente.Controls.Add(btnFechar1);
            grpBoxCliente.Controls.Add(btnAlterar);
            grpBoxCliente.Controls.Add(label3);
            grpBoxCliente.Controls.Add(label1);
            grpBoxCliente.Controls.Add(button1);
            grpBoxCliente.Controls.Add(button2);
            grpBoxCliente.Controls.Add(label2);
            grpBoxCliente.Controls.Add(lblTelefone);
            grpBoxCliente.Controls.Add(lblEndereco);
            grpBoxCliente.Controls.Add(lblNome);
            grpBoxCliente.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCliente.Location = new Point(11, 144);
            grpBoxCliente.Name = "grpBoxCliente";
            grpBoxCliente.Size = new Size(852, 435);
            grpBoxCliente.TabIndex = 4;
            grpBoxCliente.TabStop = false;
            grpBoxCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // btnFechar2
            // 
            btnFechar2.Anchor = AnchorStyles.Bottom;
            btnFechar2.BackColor = Color.Red;
            btnFechar2.ForeColor = SystemColors.ControlLightLight;
            btnFechar2.Location = new Point(727, 380);
            btnFechar2.Name = "btnFechar2";
            btnFechar2.Size = new Size(98, 38);
            btnFechar2.TabIndex = 25;
            btnFechar2.Text = "Fechar";
            btnFechar2.UseVisualStyleBackColor = false;
            btnFechar2.Click += btnFechar2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.BackColor = Color.Green;
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(603, 380);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 38);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 339);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 23;
            label4.Text = "* Campos Obrigatórios";
            // 
            // txtEmailDel
            // 
            txtEmailDel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmailDel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailDel.Location = new Point(126, 271);
            txtEmailDel.Name = "txtEmailDel";
            txtEmailDel.Size = new Size(709, 27);
            txtEmailDel.TabIndex = 22;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(126, 195);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(709, 27);
            txtTelefone.TabIndex = 21;
            // 
            // txtEnd
            // 
            txtEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEnd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnd.Location = new Point(126, 119);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(709, 27);
            txtEnd.TabIndex = 20;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(126, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(709, 27);
            txtNome.TabIndex = 19;
            // 
            // btnFechar1
            // 
            btnFechar1.Anchor = AnchorStyles.Bottom;
            btnFechar1.BackColor = Color.Red;
            btnFechar1.ForeColor = SystemColors.ControlLightLight;
            btnFechar1.Location = new Point(1009, 692);
            btnFechar1.Name = "btnFechar1";
            btnFechar1.Size = new Size(98, 38);
            btnFechar1.TabIndex = 18;
            btnFechar1.Text = "Fechar";
            btnFechar1.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.BackColor = Color.Green;
            btnAlterar.ForeColor = SystemColors.ControlLightLight;
            btnAlterar.Location = new Point(881, 692);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(98, 38);
            btnAlterar.TabIndex = 17;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 496);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 16;
            label3.Text = "* Campos Obrigatórios";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 647);
            label1.Name = "label1";
            label1.Size = new Size(147, 18);
            label1.TabIndex = 10;
            label1.Text = "* Campos Obrigatórios";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1452, 1003);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 9;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.Green;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1320, 1003);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 8;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 274);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 3;
            label2.Text = "* Email:";
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
            // ExcluirDadosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 591);
            Controls.Add(grpBoxCliente);
            Controls.Add(grpBoxCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExcluirDadosCliente";
            Text = "EXCLUIR DADOS DO CLIENTE";
            grpBoxCadastroCliente.ResumeLayout(false);
            grpBoxCadastroCliente.PerformLayout();
            grpBoxCliente.ResumeLayout(false);
            grpBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCadastroCliente;
        private Button btnPesquisar;
        private TextBox txtEmailConsulta;
        private Label lblObrigatorio;
        private Button btnFechar;
        private Button btnSalvar;
        private Label lblEmail;
        private GroupBox grpBoxCliente;
        private Button btnFechar1;
        private Button btnAlterar;
        private Label label3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label lblTelefone;
        private Label lblEndereco;
        private Label lblNome;
        private TextBox txtEnd;
        private TextBox txtNome;
        private TextBox txtEmailDel;
        private TextBox txtTelefone;
        private Label label4;
        private Button btnExcluir;
        private Button btnFechar2;
    }
}