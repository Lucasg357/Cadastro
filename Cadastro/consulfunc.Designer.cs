namespace Cadastro
{
    partial class consulfunc
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
            label1 = new Label();
            txtcpffunc = new TextBox();
            dgvfunc = new DataGridView();
            btnpesquisarfunc = new Button();
            btnlimparfunc = new Button();
            btnsairf = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvfunc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 120);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Cpf:";
            // 
            // txtcpffunc
            // 
            txtcpffunc.Location = new Point(324, 122);
            txtcpffunc.Name = "txtcpffunc";
            txtcpffunc.Size = new Size(174, 23);
            txtcpffunc.TabIndex = 1;
            // 
            // dgvfunc
            // 
            dgvfunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfunc.Location = new Point(188, 272);
            dgvfunc.Name = "dgvfunc";
            dgvfunc.Size = new Size(394, 64);
            dgvfunc.TabIndex = 2;
            // 
            // btnpesquisarfunc
            // 
            btnpesquisarfunc.BackColor = Color.DarkOrange;
            btnpesquisarfunc.FlatStyle = FlatStyle.Popup;
            btnpesquisarfunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnpesquisarfunc.ForeColor = SystemColors.ControlText;
            btnpesquisarfunc.Location = new Point(188, 197);
            btnpesquisarfunc.Name = "btnpesquisarfunc";
            btnpesquisarfunc.Size = new Size(94, 30);
            btnpesquisarfunc.TabIndex = 3;
            btnpesquisarfunc.Text = "Pesquisar";
            btnpesquisarfunc.UseVisualStyleBackColor = false;
            btnpesquisarfunc.Click += btnpesquisarfunc_Click;
            // 
            // btnlimparfunc
            // 
            btnlimparfunc.BackColor = Color.DarkOrange;
            btnlimparfunc.FlatStyle = FlatStyle.Popup;
            btnlimparfunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnlimparfunc.ForeColor = SystemColors.ControlText;
            btnlimparfunc.Location = new Point(341, 197);
            btnlimparfunc.Name = "btnlimparfunc";
            btnlimparfunc.Size = new Size(91, 30);
            btnlimparfunc.TabIndex = 4;
            btnlimparfunc.Text = "Limpar";
            btnlimparfunc.UseVisualStyleBackColor = false;
            // 
            // btnsairf
            // 
            btnsairf.BackColor = Color.DarkOrange;
            btnsairf.FlatStyle = FlatStyle.Popup;
            btnsairf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnsairf.ForeColor = SystemColors.ControlText;
            btnsairf.Location = new Point(491, 197);
            btnsairf.Name = "btnsairf";
            btnsairf.Size = new Size(91, 30);
            btnsairf.TabIndex = 5;
            btnsairf.Text = "Sair";
            btnsairf.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 21);
            label2.Name = "label2";
            label2.Size = new Size(417, 47);
            label2.TabIndex = 6;
            label2.Text = "Consulta de Funcionário";
            // 
            // consulfunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnsairf);
            Controls.Add(btnlimparfunc);
            Controls.Add(btnpesquisarfunc);
            Controls.Add(dgvfunc);
            Controls.Add(txtcpffunc);
            Controls.Add(label1);
            Name = "consulfunc";
            Text = "consulfunc";
            ((System.ComponentModel.ISupportInitialize)dgvfunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtcpffunc;
        private DataGridView dgvfunc;
        private Button btnpesquisarfunc;
        private Button btnlimparfunc;
        private Button btnsairf;
        private Label label2;
    }
}