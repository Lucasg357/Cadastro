namespace Cadastro
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnome = new TextBox();
            txttel = new TextBox();
            txtemail = new TextBox();
            txtcpf = new TextBox();
            btnnovo = new Button();
            btninserir = new Button();
            btnlimpar = new Button();
            btnsair = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 108);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 218);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 108);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(429, 218);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 3;
            label4.Text = "Cpf";
            // 
            // txtnome
            // 
            txtnome.BackColor = SystemColors.ButtonFace;
            txtnome.Location = new Point(58, 147);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(235, 23);
            txtnome.TabIndex = 4;
            // 
            // txttel
            // 
            txttel.Location = new Point(58, 251);
            txttel.Name = "txttel";
            txttel.Size = new Size(235, 23);
            txttel.TabIndex = 5;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(429, 147);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(235, 23);
            txtemail.TabIndex = 6;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(429, 251);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(235, 23);
            txtcpf.TabIndex = 7;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.DarkOrange;
            btnnovo.FlatStyle = FlatStyle.Popup;
            btnnovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnovo.ForeColor = SystemColors.Desktop;
            btnnovo.Location = new Point(80, 367);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(106, 32);
            btnnovo.TabIndex = 8;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // btninserir
            // 
            btninserir.BackColor = Color.DarkOrange;
            btninserir.FlatStyle = FlatStyle.Popup;
            btninserir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninserir.Location = new Point(234, 367);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(105, 32);
            btninserir.TabIndex = 9;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = false;
            btninserir.Click += btninserir_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.DarkOrange;
            btnlimpar.FlatStyle = FlatStyle.Popup;
            btnlimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpar.Location = new Point(386, 367);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(96, 32);
            btnlimpar.TabIndex = 10;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += button3_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.DarkOrange;
            btnsair.FlatStyle = FlatStyle.Popup;
            btnsair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsair.Location = new Point(539, 367);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(95, 32);
            btnsair.TabIndex = 11;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 21);
            label5.Name = "label5";
            label5.Size = new Size(468, 65);
            label5.TabIndex = 12;
            label5.Text = "Cadastro de Cliente";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(779, 474);
            Controls.Add(label5);
            Controls.Add(btnsair);
            Controls.Add(btnlimpar);
            Controls.Add(btninserir);
            Controls.Add(btnnovo);
            Controls.Add(txtcpf);
            Controls.Add(txtemail);
            Controls.Add(txttel);
            Controls.Add(txtnome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtnome;
        private TextBox txttel;
        private TextBox txtemail;
        private TextBox txtcpf;
        private Button btnnovo;
        private Button btninserir;
        private Button btnlimpar;
        private Button btnsair;
        private Label label5;
    }
}
