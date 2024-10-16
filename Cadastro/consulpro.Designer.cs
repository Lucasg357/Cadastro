namespace Cadastro
{
    partial class consulpro
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
            label2 = new Label();
            btnsairf = new Button();
            btnlimparfunc = new Button();
            btnpesquisarfunc = new Button();
            dgvpro = new DataGridView();
            txtnomepro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvpro).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 41);
            label2.Name = "label2";
            label2.Size = new Size(359, 47);
            label2.TabIndex = 13;
            label2.Text = "Consulta de Produto";
            // 
            // btnsairf
            // 
            btnsairf.BackColor = Color.DarkOrange;
            btnsairf.FlatStyle = FlatStyle.Popup;
            btnsairf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnsairf.ForeColor = SystemColors.ControlText;
            btnsairf.Location = new Point(498, 217);
            btnsairf.Name = "btnsairf";
            btnsairf.Size = new Size(91, 30);
            btnsairf.TabIndex = 12;
            btnsairf.Text = "Sair";
            btnsairf.UseVisualStyleBackColor = false;
            // 
            // btnlimparfunc
            // 
            btnlimparfunc.BackColor = Color.DarkOrange;
            btnlimparfunc.FlatStyle = FlatStyle.Popup;
            btnlimparfunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnlimparfunc.ForeColor = SystemColors.ControlText;
            btnlimparfunc.Location = new Point(348, 217);
            btnlimparfunc.Name = "btnlimparfunc";
            btnlimparfunc.Size = new Size(91, 30);
            btnlimparfunc.TabIndex = 11;
            btnlimparfunc.Text = "Limpar";
            btnlimparfunc.UseVisualStyleBackColor = false;
            // 
            // btnpesquisarfunc
            // 
            btnpesquisarfunc.BackColor = Color.DarkOrange;
            btnpesquisarfunc.FlatStyle = FlatStyle.Popup;
            btnpesquisarfunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnpesquisarfunc.ForeColor = SystemColors.ControlText;
            btnpesquisarfunc.Location = new Point(195, 217);
            btnpesquisarfunc.Name = "btnpesquisarfunc";
            btnpesquisarfunc.Size = new Size(94, 30);
            btnpesquisarfunc.TabIndex = 10;
            btnpesquisarfunc.Text = "Pesquisar";
            btnpesquisarfunc.UseVisualStyleBackColor = false;
            btnpesquisarfunc.Click += btnpesquisarfunc_Click;
            // 
            // dgvpro
            // 
            dgvpro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpro.Location = new Point(195, 292);
            dgvpro.Name = "dgvpro";
            dgvpro.Size = new Size(394, 64);
            dgvpro.TabIndex = 9;
            // 
            // txtnomepro
            // 
            txtnomepro.Location = new Point(331, 142);
            txtnomepro.Name = "txtnomepro";
            txtnomepro.Size = new Size(174, 23);
            txtnomepro.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 142);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // consulpro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnsairf);
            Controls.Add(btnlimparfunc);
            Controls.Add(btnpesquisarfunc);
            Controls.Add(dgvpro);
            Controls.Add(txtnomepro);
            Controls.Add(label1);
            Name = "consulpro";
            Text = "consulpro";
            ((System.ComponentModel.ISupportInitialize)dgvpro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnsairf;
        private Button btnlimparfunc;
        private Button btnpesquisarfunc;
        private DataGridView dgvpro;
        private TextBox txtnomepro;
        private Label label1;
    }
}