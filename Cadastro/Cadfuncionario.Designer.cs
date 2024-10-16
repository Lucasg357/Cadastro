namespace Cadastro
{
    partial class Cadfuncionario
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtnomefunc = new TextBox();
            txtemail = new TextBox();
            txttelfunc = new TextBox();
            txtsal = new TextBox();
            txtcpffunc = new TextBox();
            btnnovofunc = new Button();
            btninserirfunc = new Button();
            btnlimparfunc = new Button();
            btnsair = new Button();
            cmbsexo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(569, 65);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 170);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 270);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(284, 168);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(307, 269);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 4;
            label5.Text = "Cpf:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(518, 165);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 5;
            label6.Text = "Salário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(534, 269);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 6;
            label7.Text = "Sexo:";
            // 
            // txtnomefunc
            // 
            txtnomefunc.Location = new Point(115, 167);
            txtnomefunc.Name = "txtnomefunc";
            txtnomefunc.Size = new Size(146, 23);
            txtnomefunc.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(115, 267);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(146, 23);
            txtemail.TabIndex = 8;
            // 
            // txttelfunc
            // 
            txttelfunc.Location = new Point(370, 167);
            txttelfunc.Name = "txttelfunc";
            txttelfunc.Size = new Size(119, 23);
            txttelfunc.TabIndex = 9;
            // 
            // txtsal
            // 
            txtsal.Location = new Point(595, 166);
            txtsal.Name = "txtsal";
            txtsal.Size = new Size(126, 23);
            txtsal.TabIndex = 11;
            // 
            // txtcpffunc
            // 
            txtcpffunc.Location = new Point(354, 267);
            txtcpffunc.Name = "txtcpffunc";
            txtcpffunc.Size = new Size(135, 23);
            txtcpffunc.TabIndex = 12;
            // 
            // btnnovofunc
            // 
            btnnovofunc.BackColor = Color.DarkOrange;
            btnnovofunc.FlatStyle = FlatStyle.Popup;
            btnnovofunc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnnovofunc.Location = new Point(98, 363);
            btnnovofunc.Name = "btnnovofunc";
            btnnovofunc.Size = new Size(92, 32);
            btnnovofunc.TabIndex = 13;
            btnnovofunc.Text = "Novo";
            btnnovofunc.UseVisualStyleBackColor = false;
            // 
            // btninserirfunc
            // 
            btninserirfunc.BackColor = Color.DarkOrange;
            btninserirfunc.FlatStyle = FlatStyle.Popup;
            btninserirfunc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btninserirfunc.Location = new Point(254, 363);
            btninserirfunc.Name = "btninserirfunc";
            btninserirfunc.Size = new Size(94, 32);
            btninserirfunc.TabIndex = 14;
            btninserirfunc.Text = "Inserir";
            btninserirfunc.UseVisualStyleBackColor = false;
            btninserirfunc.Click += btninserirfunc_Click;
            // 
            // btnlimparfunc
            // 
            btnlimparfunc.BackColor = Color.DarkOrange;
            btnlimparfunc.FlatStyle = FlatStyle.Popup;
            btnlimparfunc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlimparfunc.Location = new Point(420, 363);
            btnlimparfunc.Name = "btnlimparfunc";
            btnlimparfunc.Size = new Size(92, 32);
            btnlimparfunc.TabIndex = 15;
            btnlimparfunc.Text = "Limpar";
            btnlimparfunc.UseVisualStyleBackColor = false;
            btnlimparfunc.Click += btnlimparfunc_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.DarkOrange;
            btnsair.FlatStyle = FlatStyle.Popup;
            btnsair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsair.Location = new Point(595, 363);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(89, 32);
            btnsair.TabIndex = 16;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            // 
            // cmbsexo
            // 
            cmbsexo.FormattingEnabled = true;
            cmbsexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbsexo.Location = new Point(595, 272);
            cmbsexo.Name = "cmbsexo";
            cmbsexo.Size = new Size(126, 23);
            cmbsexo.TabIndex = 17;
            // 
            // Cadfuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbsexo);
            Controls.Add(btnsair);
            Controls.Add(btnlimparfunc);
            Controls.Add(btninserirfunc);
            Controls.Add(btnnovofunc);
            Controls.Add(txtcpffunc);
            Controls.Add(txtsal);
            Controls.Add(txttelfunc);
            Controls.Add(txtemail);
            Controls.Add(txtnomefunc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Cadfuncionario";
            Text = "Cadfuncionario";
            Load += Cadfuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtnomefunc;
        private TextBox txtemail;
        private TextBox txttelfunc;
        private TextBox txtsal;
        private TextBox txtcpffunc;
        private Button btnnovofunc;
        private Button btninserirfunc;
        private Button btnlimparfunc;
        private Button btnsair;
        private ComboBox cmbsexo;
    }
}