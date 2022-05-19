
namespace atividade_01.View.Ticket
{
    partial class TelaTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTicket));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGiovanni = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket do Cliente";
            // 
            // lblGiovanni
            // 
            this.lblGiovanni.AutoSize = true;
            this.lblGiovanni.BackColor = System.Drawing.Color.Transparent;
            this.lblGiovanni.Location = new System.Drawing.Point(502, 238);
            this.lblGiovanni.Name = "lblGiovanni";
            this.lblGiovanni.Size = new System.Drawing.Size(54, 15);
            this.lblGiovanni.TabIndex = 2;
            this.lblGiovanni.Text = "Giovanni";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(60, 112);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(60, 188);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 15);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor";
            // 
            // cbxCor
            // 
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Items.AddRange(new object[] {
            "Azul",
            "Preto",
            "Amarelo",
            "Branco",
            "Vermelho",
            "Laranja",
            "Cinza",
            "Verde",
            "Marrom"});
            this.cbxCor.Location = new System.Drawing.Point(113, 185);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(181, 23);
            this.cbxCor.TabIndex = 6;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(113, 109);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(181, 23);
            this.tbxPlaca.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(351, 185);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 262);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblGiovanni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TelaTicket";
            this.Text = "TelaTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGiovanni;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button btnConfirmar;
    }
}