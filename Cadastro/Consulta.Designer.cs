namespace Cadastro
{
    partial class Consulta
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
            label4 = new Label();
            label5 = new Label();
            txtcpf = new TextBox();
            label6 = new Label();
            dgvcliente = new DataGridView();
            btnpesquisar = new Button();
            btnlimpar = new Button();
            btnsair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcliente).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(261, 133);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 3;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 234);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(309, 133);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(182, 23);
            txtcpf.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 18);
            label6.Name = "label6";
            label6.Size = new Size(465, 65);
            label6.TabIndex = 9;
            label6.Text = "Consulta de Cliente";
            // 
            // dgvcliente
            // 
            dgvcliente.BackgroundColor = SystemColors.ControlDarkDark;
            dgvcliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcliente.Location = new Point(165, 289);
            dgvcliente.Name = "dgvcliente";
            dgvcliente.Size = new Size(440, 83);
            dgvcliente.TabIndex = 10;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.DarkOrange;
            btnpesquisar.FlatStyle = FlatStyle.Popup;
            btnpesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpesquisar.Location = new Point(120, 210);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(102, 29);
            btnpesquisar.TabIndex = 11;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.DarkOrange;
            btnlimpar.FlatStyle = FlatStyle.Popup;
            btnlimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpar.Location = new Point(337, 210);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(101, 29);
            btnlimpar.TabIndex = 12;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.DarkOrange;
            btnsair.FlatStyle = FlatStyle.Popup;
            btnsair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsair.Location = new Point(557, 210);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(99, 29);
            btnsair.TabIndex = 13;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsair);
            Controls.Add(btnlimpar);
            Controls.Add(btnpesquisar);
            Controls.Add(dgvcliente);
            Controls.Add(label6);
            Controls.Add(txtcpf);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvcliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox txtcpf;
        private Label label6;
        private DataGridView dgvcliente;
        private Button btnpesquisar;
        private Button btnlimpar;
        private Button btnsair;
    }
}