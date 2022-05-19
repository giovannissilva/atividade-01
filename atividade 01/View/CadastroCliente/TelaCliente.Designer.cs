
namespace atividade_01.View.CadastroCliente
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxCelular = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblGiovanni = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(134, 107);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(397, 23);
            this.tbxNome.TabIndex = 0;
            // 
            // tbxCelular
            // 
            this.tbxCelular.Location = new System.Drawing.Point(134, 140);
            this.tbxCelular.Name = "tbxCelular";
            this.tbxCelular.Size = new System.Drawing.Size(397, 23);
            this.tbxCelular.TabIndex = 1;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(134, 173);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(397, 23);
            this.tbxEmail.TabIndex = 2;
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(134, 206);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(397, 23);
            this.tbxCPF.TabIndex = 3;
            this.tbxCPF.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(67, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Location = new System.Drawing.Point(67, 149);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(67, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Location = new System.Drawing.Point(67, 216);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 15);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF";
            // 
            // lblGiovanni
            // 
            this.lblGiovanni.AutoSize = true;
            this.lblGiovanni.BackColor = System.Drawing.Color.Transparent;
            this.lblGiovanni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGiovanni.Location = new System.Drawing.Point(578, 399);
            this.lblGiovanni.Name = "lblGiovanni";
            this.lblGiovanni.Size = new System.Drawing.Size(54, 15);
            this.lblGiovanni.TabIndex = 9;
            this.lblGiovanni.Text = "Giovanni";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(533, 271);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(99, 30);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Confirmar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prenecha com suas informaçõe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResul
            // 
            this.lblResul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblResul.Location = new System.Drawing.Point(134, 245);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(397, 27);
            this.lblResul.TabIndex = 12;
            this.lblResul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResul.Click += new System.EventHandler(this.lblResul_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 423);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblGiovanni);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxCelular);
            this.Controls.Add(this.tbxNome);
            this.Name = "TelaCliente";
            this.Text = "TelaCliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxCelular;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblGiovanni;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResul;
    }
}