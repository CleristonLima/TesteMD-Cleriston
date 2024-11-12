namespace TesteMDCleriston.Forms
{
    partial class ListaClientes
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
            txtEmail = new TextBox();
            lblObrigatorio = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            lblEmail = new Label();
            dataGridView1 = new DataGridView();
            grpBoxCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpBoxCadastroCliente
            // 
            grpBoxCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxCadastroCliente.Controls.Add(btnPesquisar);
            grpBoxCadastroCliente.Controls.Add(txtEmail);
            grpBoxCadastroCliente.Controls.Add(lblObrigatorio);
            grpBoxCadastroCliente.Controls.Add(btnFechar);
            grpBoxCadastroCliente.Controls.Add(btnSalvar);
            grpBoxCadastroCliente.Controls.Add(lblEmail);
            grpBoxCadastroCliente.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxCadastroCliente.Location = new Point(12, 19);
            grpBoxCadastroCliente.Name = "grpBoxCadastroCliente";
            grpBoxCadastroCliente.Size = new Size(697, 120);
            grpBoxCadastroCliente.TabIndex = 1;
            grpBoxCadastroCliente.TabStop = false;
            grpBoxCadastroCliente.Text = "CONSULTAR CLIENTE";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Yellow;
            btnPesquisar.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(539, 45);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 38);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(86, 53);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(414, 27);
            txtEmail.TabIndex = 11;
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.Anchor = AnchorStyles.Left;
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObrigatorio.Location = new Point(29, 334);
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
            btnFechar.Location = new Point(1048, 376);
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
            btnSalvar.Location = new Point(916, 376);
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
            lblEmail.Size = new Size(50, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 281);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grpBoxCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA DE CLIENTES";
            grpBoxCadastroCliente.ResumeLayout(false);
            grpBoxCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCadastroCliente;
        private Label lblObrigatorio;
        private Button btnFechar;
        private Button btnSalvar;
        private Label lblEmail;
        private Button btnPesquisar;
        private TextBox txtEmail;
        private DataGridView dataGridView1;
    }
}