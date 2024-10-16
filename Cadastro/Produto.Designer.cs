namespace Cadastro
{
    partial class frmProduto
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdescricao = new TextBox();
            mdtvalor = new MaskedTextBox();
            btnpro = new Button();
            btnlimparpro = new Button();
            btninserirpro = new Button();
            btnnovop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 36);
            label1.Name = "label1";
            label1.Size = new Size(332, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 193);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(411, 192);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 193);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(280, 190);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(100, 23);
            txtdescricao.TabIndex = 4;
            // 
            // mdtvalor
            // 
            mdtvalor.Location = new Point(472, 190);
            mdtvalor.Mask = "$99999999";
            mdtvalor.Name = "mdtvalor";
            mdtvalor.Size = new Size(109, 23);
            mdtvalor.TabIndex = 5;
            // 
            // btnpro
            // 
            btnpro.BackColor = Color.DarkOrange;
            btnpro.FlatStyle = FlatStyle.Popup;
            btnpro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnpro.Location = new Point(619, 328);
            btnpro.Name = "btnpro";
            btnpro.Size = new Size(89, 32);
            btnpro.TabIndex = 20;
            btnpro.Text = "Sair";
            btnpro.UseVisualStyleBackColor = false;
            btnpro.Click += btnpro_Click;
            // 
            // btnlimparpro
            // 
            btnlimparpro.BackColor = Color.DarkOrange;
            btnlimparpro.FlatStyle = FlatStyle.Popup;
            btnlimparpro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlimparpro.Location = new Point(440, 328);
            btnlimparpro.Name = "btnlimparpro";
            btnlimparpro.Size = new Size(92, 32);
            btnlimparpro.TabIndex = 19;
            btnlimparpro.Text = "Limpar";
            btnlimparpro.UseVisualStyleBackColor = false;
            btnlimparpro.Click += btnlimparpro_Click;
            // 
            // btninserirpro
            // 
            btninserirpro.BackColor = Color.DarkOrange;
            btninserirpro.FlatStyle = FlatStyle.Popup;
            btninserirpro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btninserirpro.Location = new Point(258, 328);
            btninserirpro.Name = "btninserirpro";
            btninserirpro.Size = new Size(94, 32);
            btninserirpro.TabIndex = 18;
            btninserirpro.Text = "Inserir";
            btninserirpro.UseVisualStyleBackColor = false;
            btninserirpro.Click += btninserirpro_Click;
            // 
            // btnnovop
            // 
            btnnovop.BackColor = Color.DarkOrange;
            btnnovop.FlatStyle = FlatStyle.Popup;
            btnnovop.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnnovop.Location = new Point(94, 328);
            btnnovop.Name = "btnnovop";
            btnnovop.Size = new Size(92, 32);
            btnnovop.TabIndex = 17;
            btnnovop.Text = "Novo";
            btnnovop.UseVisualStyleBackColor = false;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpro);
            Controls.Add(btnlimparpro);
            Controls.Add(btninserirpro);
            Controls.Add(btnnovop);
            Controls.Add(mdtvalor);
            Controls.Add(txtdescricao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProduto";
            Text = "Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdescricao;
        private MaskedTextBox mdtvalor;
        private Button btnpro;
        private Button btnlimparpro;
        private Button btninserirpro;
        private Button btnnovop;
    }
}