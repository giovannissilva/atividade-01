
namespace atividade_01.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblGiovanni = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTic = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCli = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGiovanni
            // 
            this.lblGiovanni.AutoSize = true;
            this.lblGiovanni.BackColor = System.Drawing.Color.Transparent;
            this.lblGiovanni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGiovanni.Location = new System.Drawing.Point(731, 439);
            this.lblGiovanni.Name = "lblGiovanni";
            this.lblGiovanni.Size = new System.Drawing.Size(54, 15);
            this.lblGiovanni.TabIndex = 3;
            this.lblGiovanni.Text = "Giovanni";
            this.lblGiovanni.Click += new System.EventHandler(this.lblGiovanni_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(187, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(428, 47);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Escolha uma das 3 opções";
            // 
            // btnTic
            // 
            this.btnTic.BackColor = System.Drawing.Color.Transparent;
            this.btnTic.Location = new System.Drawing.Point(242, 300);
            this.btnTic.Name = "btnTic";
            this.btnTic.Size = new System.Drawing.Size(247, 51);
            this.btnTic.TabIndex = 6;
            this.btnTic.Text = "Ticket do Estacionamento";
            this.btnTic.UseVisualStyleBackColor = false;
            this.btnTic.Click += new System.EventHandler(this.btnTic_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.Location = new System.Drawing.Point(242, 227);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(247, 51);
            this.btnCar.TabIndex = 5;
            this.btnCar.Text = "Cadastro do Carro";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCli
            // 
            this.btnCli.BackColor = System.Drawing.Color.Transparent;
            this.btnCli.Location = new System.Drawing.Point(242, 158);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(247, 51);
            this.btnCli.TabIndex = 1;
            this.btnCli.Text = "Cadastro do Cliente";
            this.btnCli.UseVisualStyleBackColor = false;
            this.btnCli.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(12, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 463);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTic);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblGiovanni);
            this.Controls.Add(this.btnCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal Para Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiovanni;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTic;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnCli;
        private System.Windows.Forms.Button btnSair;
    }
}