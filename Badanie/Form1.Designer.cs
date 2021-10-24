
namespace Badanie
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lImie = new System.Windows.Forms.Label();
            this.lBadania = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbBadania = new System.Windows.Forms.TextBox();
            this.tpData_Badania = new System.Windows.Forms.DateTimePicker();
            this.tpAktualna_Data = new System.Windows.Forms.DateTimePicker();
            this.tpAktualna_Godzina = new System.Windows.Forms.DateTimePicker();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Imie_label = new System.Windows.Forms.Label();
            this.Badanie_label = new System.Windows.Forms.Label();
            this.tp_Badania = new System.Windows.Forms.DateTimePicker();
            this.Dane_pacjeta = new System.Windows.Forms.Label();
            this.lKolejka = new System.Windows.Forms.Label();
            this.btn_wypisz = new System.Windows.Forms.Button();
            this.WypKol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lImie
            // 
            this.lImie.AutoSize = true;
            this.lImie.Location = new System.Drawing.Point(37, 135);
            this.lImie.Name = "lImie";
            this.lImie.Size = new System.Drawing.Size(63, 15);
            this.lImie.TabIndex = 0;
            this.lImie.Text = "Podaj Imie";
            this.lImie.Click += new System.EventHandler(this.lImie_Click);
            // 
            // lBadania
            // 
            this.lBadania.AutoSize = true;
            this.lBadania.Location = new System.Drawing.Point(37, 168);
            this.lBadania.Name = "lBadania";
            this.lBadania.Size = new System.Drawing.Size(87, 15);
            this.lBadania.TabIndex = 1;
            this.lBadania.Text = "Nazwa badania";
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(37, 201);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(108, 15);
            this.lData.TabIndex = 2;
            this.lData.Text = "Podaj date badania";
            this.lData.Click += new System.EventHandler(this.lData_Click);
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(196, 127);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 23);
            this.tbImie.TabIndex = 3;
            // 
            // tbBadania
            // 
            this.tbBadania.Location = new System.Drawing.Point(196, 160);
            this.tbBadania.Name = "tbBadania";
            this.tbBadania.Size = new System.Drawing.Size(100, 23);
            this.tbBadania.TabIndex = 4;
            // 
            // tpData_Badania
            // 
            this.tpData_Badania.Location = new System.Drawing.Point(196, 193);
            this.tpData_Badania.Name = "tpData_Badania";
            this.tpData_Badania.Size = new System.Drawing.Size(200, 23);
            this.tpData_Badania.TabIndex = 5;
            // 
            // tpAktualna_Data
            // 
            this.tpAktualna_Data.Enabled = false;
            this.tpAktualna_Data.Location = new System.Drawing.Point(251, 23);
            this.tpAktualna_Data.Name = "tpAktualna_Data";
            this.tpAktualna_Data.Size = new System.Drawing.Size(200, 23);
            this.tpAktualna_Data.TabIndex = 6;
            this.tpAktualna_Data.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.tpAktualna_Data.ValueChanged += new System.EventHandler(this.tpAktualna_Data_ValueChanged);
            // 
            // tpAktualna_Godzina
            // 
            this.tpAktualna_Godzina.Enabled = false;
            this.tpAktualna_Godzina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpAktualna_Godzina.Location = new System.Drawing.Point(303, 52);
            this.tpAktualna_Godzina.Name = "tpAktualna_Godzina";
            this.tpAktualna_Godzina.Size = new System.Drawing.Size(76, 23);
            this.tpAktualna_Godzina.TabIndex = 7;
            this.tpAktualna_Godzina.Value = new System.DateTime(2021, 10, 6, 12, 19, 0, 0);
            this.tpAktualna_Godzina.ValueChanged += new System.EventHandler(this.tpAktualna_Godzina_ValueChanged);
            // 
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Interval = 10000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(229, 261);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(122, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj wizyte";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Imie_label
            // 
            this.Imie_label.AutoSize = true;
            this.Imie_label.Location = new System.Drawing.Point(573, 127);
            this.Imie_label.Name = "Imie_label";
            this.Imie_label.Size = new System.Drawing.Size(68, 15);
            this.Imie_label.TabIndex = 9;
            this.Imie_label.Text = "Imie klienta";
            // 
            // Badanie_label
            // 
            this.Badanie_label.AutoSize = true;
            this.Badanie_label.Location = new System.Drawing.Point(573, 160);
            this.Badanie_label.Name = "Badanie_label";
            this.Badanie_label.Size = new System.Drawing.Size(87, 15);
            this.Badanie_label.TabIndex = 10;
            this.Badanie_label.Text = "Nazwa badania";
            // 
            // tp_Badania
            // 
            this.tp_Badania.Enabled = false;
            this.tp_Badania.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tp_Badania.Location = new System.Drawing.Point(573, 193);
            this.tp_Badania.Name = "tp_Badania";
            this.tp_Badania.Size = new System.Drawing.Size(67, 23);
            this.tp_Badania.TabIndex = 11;
            // 
            // Dane_pacjeta
            // 
            this.Dane_pacjeta.AutoSize = true;
            this.Dane_pacjeta.Location = new System.Drawing.Point(573, 91);
            this.Dane_pacjeta.Name = "Dane_pacjeta";
            this.Dane_pacjeta.Size = new System.Drawing.Size(186, 15);
            this.Dane_pacjeta.TabIndex = 12;
            this.Dane_pacjeta.Text = "Dane pacjeta dodanego do kolejki";
            this.Dane_pacjeta.Click += new System.EventHandler(this.Dane_pacjeta_Click);
            // 
            // lKolejka
            // 
            this.lKolejka.AutoSize = true;
            this.lKolejka.Location = new System.Drawing.Point(267, 307);
            this.lKolejka.Name = "lKolejka";
            this.lKolejka.Size = new System.Drawing.Size(45, 15);
            this.lKolejka.TabIndex = 22;
            this.lKolejka.Text = "Kolejka";
            // 
            // btn_wypisz
            // 
            this.btn_wypisz.Location = new System.Drawing.Point(532, 261);
            this.btn_wypisz.Name = "btn_wypisz";
            this.btn_wypisz.Size = new System.Drawing.Size(170, 23);
            this.btn_wypisz.TabIndex = 23;
            this.btn_wypisz.Text = "Wypisz w kolejce";
            this.btn_wypisz.UseVisualStyleBackColor = true;
            // 
            // WypKol
            // 
            this.WypKol.AutoSize = true;
            this.WypKol.Location = new System.Drawing.Point(267, 360);
            this.WypKol.Name = "WypKol";
            this.WypKol.Size = new System.Drawing.Size(0, 15);
            this.WypKol.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 534);
            this.Controls.Add(this.WypKol);
            this.Controls.Add(this.btn_wypisz);
            this.Controls.Add(this.lKolejka);
            this.Controls.Add(this.Dane_pacjeta);
            this.Controls.Add(this.tp_Badania);
            this.Controls.Add(this.Badanie_label);
            this.Controls.Add(this.Imie_label);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tpAktualna_Godzina);
            this.Controls.Add(this.tpAktualna_Data);
            this.Controls.Add(this.tpData_Badania);
            this.Controls.Add(this.tbBadania);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lBadania);
            this.Controls.Add(this.lImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lImie;
        private System.Windows.Forms.Label lBadania;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbBadania;
        private System.Windows.Forms.DateTimePicker tpData_Badania;
        private System.Windows.Forms.DateTimePicker tpAktualna_Data;
        private System.Windows.Forms.DateTimePicker tpAktualna_Godzina;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label Imie_label;
        private System.Windows.Forms.Label Badanie_label;
        private System.Windows.Forms.DateTimePicker tp_Badania;
        private System.Windows.Forms.Label Dane_pacjeta;
        private System.Windows.Forms.Label lKolejka;
        private System.Windows.Forms.Button btn_wypisz;
        private System.Windows.Forms.Label WypKol;
    }
}

