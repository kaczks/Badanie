
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lKolejka = new System.Windows.Forms.Label();
            this.btn_nastepny = new System.Windows.Forms.Button();
            this.btn_poprzedni = new System.Windows.Forms.Button();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "label9";
            // 
            // lKolejka
            // 
            this.lKolejka.AutoSize = true;
            this.lKolejka.Location = new System.Drawing.Point(303, 309);
            this.lKolejka.Name = "lKolejka";
            this.lKolejka.Size = new System.Drawing.Size(45, 15);
            this.lKolejka.TabIndex = 22;
            this.lKolejka.Text = "Kolejka";
            // 
            // btn_nastepny
            // 
            this.btn_nastepny.Location = new System.Drawing.Point(196, 478);
            this.btn_nastepny.Name = "btn_nastepny";
            this.btn_nastepny.Size = new System.Drawing.Size(75, 23);
            this.btn_nastepny.TabIndex = 23;
            this.btn_nastepny.Text = "Next";
            this.btn_nastepny.UseVisualStyleBackColor = true;
            // 
            // btn_poprzedni
            // 
            this.btn_poprzedni.Location = new System.Drawing.Point(376, 478);
            this.btn_poprzedni.Name = "btn_poprzedni";
            this.btn_poprzedni.Size = new System.Drawing.Size(75, 23);
            this.btn_poprzedni.TabIndex = 24;
            this.btn_poprzedni.Text = "Previous";
            this.btn_poprzedni.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 534);
            this.Controls.Add(this.btn_poprzedni);
            this.Controls.Add(this.btn_nastepny);
            this.Controls.Add(this.lKolejka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lKolejka;
        private System.Windows.Forms.Button btn_nastepny;
        private System.Windows.Forms.Button btn_poprzedni;
    }
}

