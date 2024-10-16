namespace Cadastro
{
    partial class frmLogin
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
            btnentrar = new Button();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 31);
            label1.Name = "label1";
            label1.Size = new Size(155, 65);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 161);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(323, 223);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.DarkOrange;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnentrar.ForeColor = SystemColors.ActiveCaptionText;
            btnentrar.Location = new Point(380, 324);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(191, 36);
            btnentrar.TabIndex = 3;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(426, 163);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(203, 23);
            txtusuario.TabIndex = 4;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(426, 225);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(203, 23);
            txtsenha.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 450);
            panel1.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(712, 450);
            Controls.Add(panel1);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(btnentrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnentrar;
        private TextBox txtusuario;
        private TextBox txtsenha;
        private Panel panel1;
    }
}