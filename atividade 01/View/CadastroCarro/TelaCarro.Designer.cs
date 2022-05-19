
namespace atividade_01.View.CadastroCarro
{
    partial class TelaCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarro));
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblGiovanni = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.cbxCarro = new System.Windows.Forms.ComboBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblCarro.Location = new System.Drawing.Point(97, 127);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(36, 15);
            this.lblCarro.TabIndex = 0;
            this.lblCarro.Text = "Carro";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Location = new System.Drawing.Point(98, 180);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 15);
            this.lblCor.TabIndex = 1;
            this.lblCor.Text = "Cor";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Location = new System.Drawing.Point(98, 74);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Location = new System.Drawing.Point(98, 233);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // lblGiovanni
            // 
            this.lblGiovanni.AutoSize = true;
            this.lblGiovanni.BackColor = System.Drawing.Color.Transparent;
            this.lblGiovanni.Location = new System.Drawing.Point(548, 345);
            this.lblGiovanni.Name = "lblGiovanni";
            this.lblGiovanni.Size = new System.Drawing.Size(54, 15);
            this.lblGiovanni.TabIndex = 4;
            this.lblGiovanni.Text = "Giovanni";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(557, 45);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Coloque as informações de seu carro";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "AGRALE",
            "ALFA ROMEO",
            "ASIA MOTORS",
            "ASTON MARTIN",
            "AUDI",
            "BENTLEY",
            "BMW",
            "BYD",
            "CAOA CHERY",
            "CHANA",
            "CHANGAN",
            "CHERY",
            "CHEVROLET",
            "CHRYSLER",
            "CITROEN",
            "DAEWOO",
            "DAIHATSU",
            "DODGE",
            "DS",
            "EFFA",
            "FERRARI",
            "FIAT",
            "FORD",
            "FOTON",
            "GEELY",
            "HONDA",
            "HYUNDAI",
            "IVECO",
            "JAC",
            "JAGUAR",
            "JEEP",
            "JINBEI",
            "KIA",
            "LAMBORGHINI",
            "LAND ROVER",
            "LEXUS",
            "LIFAN",
            "MAHINDRA-BRAMONT",
            "MASERATI",
            "MAZDA",
            "MCLAREN",
            "MERCEDES-BENZ",
            "MINI",
            "MITSUBISHI",
            "MORRIS GARAGES",
            "NISSAN",
            "PEUGEOT",
            "PORSCHE",
            "RAM",
            "RELY",
            "RENAULT",
            "ROLLS ROYCE",
            "SEAT",
            "SHINERAY",
            "SMART",
            "SSANGYONG",
            "SUBARU",
            "SUZUKI",
            "TAC",
            "TOYOTA",
            "TROLLER",
            "VOLKSWAGEN",
            "VOLVO"});
            this.cbxMarca.Location = new System.Drawing.Point(185, 71);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(179, 23);
            this.cbxMarca.TabIndex = 6;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
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
            this.cbxCor.Location = new System.Drawing.Point(185, 177);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(179, 23);
            this.cbxCor.TabIndex = 8;
            // 
            // cbxCarro
            // 
            this.cbxCarro.FormattingEnabled = true;
            this.cbxCarro.Items.AddRange(new object[] {
            "AUDI 80",
            "AUDI A1",
            "AUDI A3",
            "AUDI A4 ",
            "AUDI A5\t\t",
            "AUDI A6",
            "AUDI A7\t",
            "AUDI A8",
            "AUDI AVANT ALLROAD\t\t",
            "AUDI E-TRON",
            "AUDI E-TRON GT\t",
            "AUDI Q3",
            "AUDI Q5\t\t",
            "AUDI Q7",
            "AUDI Q8\t\t",
            "AUDI R8",
            "AUDI RS Q3\t\t",
            "AUDI RS Q8",
            "AUDI RS3\t",
            "AUDI RS4 ",
            "AUDI RS5\t\t",
            "AUDI RS6",
            "AUDI RS7\t\t",
            "AUDI S3",
            "AUDI S4\t\t",
            "AUDI S5 ",
            "AUDI S6\t",
            "AUDI S7",
            "AUDI S8\t",
            "AUDI SQ5",
            "AUDI TT\t\t",
            "AUDI TTS",
            "BMW 1M",
            "BMW i3\t\t",
            "BMW i8 ",
            "BMW IX\t\t",
            "BMW M2 ",
            "BMW M3\t\t",
            "BMW M340I",
            "BMW M4\t\t",
            "BMW M440I",
            "BMW M5\t\t",
            "BMW M6",
            "BMW SÉRIE 1\t\t",
            "BMW SÉRIE 2",
            "BMW SÉRIE 2 ACTIVE TOURER\t\t",
            "BMW SÉRIE 3 ",
            "BMW SÉRIE 4\t\t",
            "BMW SÉRIE 5",
            "BMW SÉRIE 7\t\t",
            "BMW SÉRIE 8 ",
            "BMW X1\t\t",
            "BMW X2",
            "BMW X3\t\t",
            "BMW X4",
            "BMW X5\t",
            "BMW X6\t",
            "BMW X7\t",
            "BMW Z3\t\t",
            "BMW Z4 ",
            "BMW Z8\t",
            "CHEVROLET AGILE ",
            "CHEVROLET ASTRA",
            "CHEVROLET BLAZER\t",
            "CHEVROLET BOLT",
            "CHEVROLET CAMARO\t\t",
            "CHEVROLET CAPTIVA",
            "CHEVROLET CELTA\t",
            "CHEVROLET COBALT",
            "CHEVROLET CORSA\t",
            "CHEVROLET CORSA CLASSIC ",
            "CHEVROLET CORSA HATCH\t",
            "CHEVROLET CORSA PICAPE",
            "CHEVROLET CORSA SEDÃ\t",
            "CHEVROLET CORSA WAGON",
            "CHEVROLET CRUZE\t",
            "CHEVROLET CRUZE SPORT6",
            "CHEVROLET EQUINOX\t\t",
            "CHEVROLET IPANEMA",
            "CHEVROLET JOY\t\t",
            "CHEVROLET JOY PLUS ",
            "CHEVROLET KADETT\t",
            "CHEVROLET MALIBU ",
            "CHEVROLET MERIVA\t\t",
            "CHEVROLET MONTANA ",
            "CHEVROLET MONZA\t",
            "CHEVROLET OMEGA",
            "CHEVROLET ONIX\t\t",
            "CHEVROLET ONIX PLUS",
            "CHEVROLET PRISMA\t\t",
            "CHEVROLET S10",
            "CHEVROLET S-10\t\t",
            "CHEVROLET SILVERADO",
            "CHEVROLET SONIC\t\t",
            "CHEVROLET SPACE VAN",
            "CHEVROLET SPIN\t\t",
            "CHEVROLET SUPREMA",
            "CHEVROLET TIGRA\t\t",
            "CHEVROLET TRACKER",
            "CHEVROLET TRAILBLAZER\t",
            "CHEVROLET VECTRA",
            "CHEVROLET ZAFIRA\t",
            "CHRYSLER 300C\t",
            "CHRYSLER 300M\t",
            "CHRYSLER CARAVAN",
            "CHRYSLER GRAND CARAVAN\t",
            "CHRYSLER NEON\t",
            "CHRYSLER PT CRUISER\t",
            "CHRYSLER SEBRING\t",
            "CHRYSLER STRATUS\t",
            "CHRYSLER TOWN&COUNTRY\t",
            "FIAT 500",
            "FIAT ARGO\t",
            "FIAT BRAVA\t ",
            "FIAT BRAVO\t ",
            "FIAT COUPE\t",
            "FIAT CRONOS\t",
            "FIAT DOBLO\t",
            "FIAT DUCATO\t",
            "FIAT DUCATO MINIBUS\t",
            "FIAT ELBA\t ",
            "FIAT FIORINO\t",
            "FIAT FREEMONT\t",
            "FIAT GRAND SIENA\t",
            "FIAT IDEA\t",
            "FIAT LINEA\t ",
            "FIAT MAREA\t",
            "FIAT MAREA WEEKEND\t",
            "FIAT MOBI\t",
            "FIAT PALIO\t",
            "FIAT PALIO WEEKEND\t",
            "FIAT PULSE\t",
            "FIAT PUNTO\t ",
            "FIAT SIENA\t ",
            "FIAT STILO\t",
            "FIAT STRADA\t",
            "FIAT TEMPRA\t ",
            "FIAT TIPO\t\t",
            "FIAT TORO\t",
            "FIAT UNO\t",
            "FIAT WEEKEND",
            "FORD BRONCO\t",
            "FORD COURIER\t",
            "FORD ECOSPORT\t",
            "FORD EDGE\t",
            "FORD ESCORT\t",
            "FORD EXPLORER\t",
            "FORD F-1000\t",
            "FORD F-250\t",
            "FORD FIESTA\t",
            "FORD FOCUS\t",
            "FORD FUSION",
            "FORD KA\t",
            "FORD KA SEDAN\t",
            "FORD MAVERICK\t",
            "FORD MONDEO\t",
            "FORD MUSTANG\t",
            "FORD PAMPA\t",
            "FORD RANGER\t",
            "FORD TAURUS",
            "FORD TERRITORY\t",
            "FORD TRANSIT\t",
            "FORD VERONA",
            "FORD VERSAILLES",
            "JAGUAR E-PACE",
            "JAGUAR F-PACE\t\t ",
            "JAGUAR I-PACE\t",
            "JAGUAR S-TYPE\t",
            "JAGUAR XE\t",
            "JAGUAR XF\t",
            "JAGUAR XJ\t\t",
            "JAGUAR XK\t",
            "JAGUAR X-TYPE",
            "LAMBORGHINI AVENTADOR\t",
            "LAMBORGHINI GALLARDO\t",
            "LAMBORGHINI HURACAN",
            "VOLKSWAGEN AMAROK ",
            "VOLKSWAGEN BORA\t",
            "VOLKSWAGEN CARAVELLE\t",
            "VOLKSWAGEN CROSSFOX\t",
            "VOLKSWAGEN DELIVERY EXPRESS\t",
            "VOLKSWAGEN EOS\t",
            "VOLKSWAGEN EUROVAN\t ",
            "VOLKSWAGEN FOX\t ",
            "VOLKSWAGEN FUSCA\t ",
            "VOLKSWAGEN GOL\t ",
            "VOLKSWAGEN GOLF\t",
            "VOLKSWAGEN GOLF CABRIOLET\t",
            "VOLKSWAGEN GOLF VARIANT\t",
            "VOLKSWAGEN JETTA\t",
            "VOLKSWAGEN JETTA VARIANT\t",
            "VOLKSWAGEN KOMBI\t",
            "VOLKSWAGEN LOGUS\t",
            "VOLKSWAGEN NEW BEETLE\t",
            "VOLKSWAGEN NIVUS\t",
            "VOLKSWAGEN PARATI\t",
            "VOLKSWAGEN PASSAT\t",
            "VOLKSWAGEN PASSAT CC\t ",
            "VOLKSWAGEN PASSAT VARIANT\t ",
            "VOLKSWAGEN POINTER\t",
            "VOLKSWAGEN POLO\t",
            "VOLKSWAGEN SANTANA\t\t",
            "VOLKSWAGEN SANTANA QUANTUM\t",
            "VOLKSWAGEN SAVEIRO\t",
            "VOLKSWAGEN SPACE CROSS\t",
            "VOLKSWAGEN SPACEFOX\t",
            "VOLKSWAGEN TAOS\t",
            "VOLKSWAGEN T-CROSS\t",
            "VOLKSWAGEN TIGUAN\t",
            "VOLKSWAGEN TIGUAN ALLSPACE\t",
            "VOLKSWAGEN TOUAREG\t",
            "VOLKSWAGEN UP!\t",
            "VOLKSWAGEN VAN\t",
            "VOLKSWAGEN VIRTUS\t",
            "VOLKSWAGEN VOYAGE"});
            this.cbxCarro.Location = new System.Drawing.Point(185, 124);
            this.cbxCarro.Name = "cbxCarro";
            this.cbxCarro.Size = new System.Drawing.Size(179, 23);
            this.cbxCarro.TabIndex = 9;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(185, 230);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(179, 23);
            this.tbxPlaca.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(363, 259);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 27);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 369);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.cbxCarro);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblGiovanni);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCarro);
            this.Name = "TelaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblGiovanni;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.ComboBox cbxCarro;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button btnConfirmar;
    }
}