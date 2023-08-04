namespace ContactManager
{
    partial class UcMitarbeiterStamm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdMitarbeiterBearbeiten = new System.Windows.Forms.Button();
            this.CmdMitarbeiterErstellen = new System.Windows.Forms.Button();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPostleitzahl = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtWohnort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtHausnummer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtStrasse = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtTelGesch = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtTelPriv = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtTelMobil = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtFirmenname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAhvNum = new System.Windows.Forms.TextBox();
            this.CmbNationalitaet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTitel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbAnrede = new System.Windows.Forms.ComboBox();
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdWerteSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(925, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CmdMitarbeiterBearbeiten
            // 
            this.CmdMitarbeiterBearbeiten.Location = new System.Drawing.Point(86, 3);
            this.CmdMitarbeiterBearbeiten.Name = "CmdMitarbeiterBearbeiten";
            this.CmdMitarbeiterBearbeiten.Size = new System.Drawing.Size(68, 38);
            this.CmdMitarbeiterBearbeiten.TabIndex = 2;
            this.CmdMitarbeiterBearbeiten.Text = "Bearbeiten";
            this.CmdMitarbeiterBearbeiten.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterBearbeiten.Click += new System.EventHandler(this.CmdMitarbeiterBearbeiten_Click);
            // 
            // CmdMitarbeiterErstellen
            // 
            this.CmdMitarbeiterErstellen.Location = new System.Drawing.Point(3, 3);
            this.CmdMitarbeiterErstellen.Name = "CmdMitarbeiterErstellen";
            this.CmdMitarbeiterErstellen.Size = new System.Drawing.Size(77, 38);
            this.CmdMitarbeiterErstellen.TabIndex = 3;
            this.CmdMitarbeiterErstellen.Text = "Erstellen";
            this.CmdMitarbeiterErstellen.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterErstellen.Click += new System.EventHandler(this.CmdMitarbeiterErstellen_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(153, 44);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(92, 17);
            this.ChkStatus.TabIndex = 48;
            this.ChkStatus.Text = "Status ändern";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(50, 44);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(31, 13);
            this.LblStatus.TabIndex = 47;
            this.LblStatus.Text = "Aktiv";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Status:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(26, 24);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 45;
            this.LblId.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.TxtPostleitzahl);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.TxtWohnort);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.TxtHausnummer);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.TxtStrasse);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(324, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 136);
            this.panel3.TabIndex = 43;
            // 
            // TxtPostleitzahl
            // 
            this.TxtPostleitzahl.Location = new System.Drawing.Point(134, 102);
            this.TxtPostleitzahl.Name = "TxtPostleitzahl";
            this.TxtPostleitzahl.Size = new System.Drawing.Size(121, 20);
            this.TxtPostleitzahl.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Postleitzahl:";
            // 
            // TxtWohnort
            // 
            this.TxtWohnort.Location = new System.Drawing.Point(134, 76);
            this.TxtWohnort.Name = "TxtWohnort";
            this.TxtWohnort.Size = new System.Drawing.Size(121, 20);
            this.TxtWohnort.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Wohnort:";
            // 
            // TxtHausnummer
            // 
            this.TxtHausnummer.Location = new System.Drawing.Point(134, 50);
            this.TxtHausnummer.Name = "TxtHausnummer";
            this.TxtHausnummer.Size = new System.Drawing.Size(121, 20);
            this.TxtHausnummer.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Hausnummer:";
            // 
            // TxtStrasse
            // 
            this.TxtStrasse.Location = new System.Drawing.Point(134, 24);
            this.TxtStrasse.Name = "TxtStrasse";
            this.TxtStrasse.Size = new System.Drawing.Size(121, 20);
            this.TxtStrasse.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Strasse:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Adresse";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.TxtTelGesch);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.TxtTelPriv);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.TxtTelMobil);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.TxtEmail);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(324, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 140);
            this.panel4.TabIndex = 42;
            // 
            // TxtTelGesch
            // 
            this.TxtTelGesch.Location = new System.Drawing.Point(134, 101);
            this.TxtTelGesch.Name = "TxtTelGesch";
            this.TxtTelGesch.Size = new System.Drawing.Size(121, 20);
            this.TxtTelGesch.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Telefon Geschäft:";
            // 
            // TxtTelPriv
            // 
            this.TxtTelPriv.Location = new System.Drawing.Point(134, 75);
            this.TxtTelPriv.Name = "TxtTelPriv";
            this.TxtTelPriv.Size = new System.Drawing.Size(121, 20);
            this.TxtTelPriv.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Telefon Privat:";
            // 
            // TxtTelMobil
            // 
            this.TxtTelMobil.Location = new System.Drawing.Point(134, 49);
            this.TxtTelMobil.Name = "TxtTelMobil";
            this.TxtTelMobil.Size = new System.Drawing.Size(121, 20);
            this.TxtTelMobil.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "Telefon Mobil:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(134, 23);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 20);
            this.TxtEmail.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "E-Mail:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Kunden Kontakt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.TxtFirmenname);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(624, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 136);
            this.panel2.TabIndex = 41;
            // 
            // TxtFirmenname
            // 
            this.TxtFirmenname.Location = new System.Drawing.Point(134, 37);
            this.TxtFirmenname.Name = "TxtFirmenname";
            this.TxtFirmenname.Size = new System.Drawing.Size(121, 20);
            this.TxtFirmenname.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kundentyp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Firmenname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Firma";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ChkStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtAhvNum);
            this.panel1.Controls.Add(this.CmbNationalitaet);
            this.panel1.Controls.Add(this.LblId);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DtpGeburtsdatum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtNachname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CmbTitel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CmbAnrede);
            this.panel1.Controls.Add(this.TxtVorname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 283);
            this.panel1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "AHV-Nummer";
            // 
            // TxtAhvNum
            // 
            this.TxtAhvNum.Location = new System.Drawing.Point(153, 228);
            this.TxtAhvNum.Name = "TxtAhvNum";
            this.TxtAhvNum.Size = new System.Drawing.Size(121, 20);
            this.TxtAhvNum.TabIndex = 14;
            // 
            // CmbNationalitaet
            // 
            this.CmbNationalitaet.FormattingEnabled = true;
            this.CmbNationalitaet.Location = new System.Drawing.Point(153, 201);
            this.CmbNationalitaet.Name = "CmbNationalitaet";
            this.CmbNationalitaet.Size = new System.Drawing.Size(121, 21);
            this.CmbNationalitaet.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nationalität";
            // 
            // DtpGeburtsdatum
            // 
            this.DtpGeburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpGeburtsdatum.Location = new System.Drawing.Point(153, 175);
            this.DtpGeburtsdatum.Name = "DtpGeburtsdatum";
            this.DtpGeburtsdatum.Size = new System.Drawing.Size(121, 20);
            this.DtpGeburtsdatum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geburtsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nachname";
            // 
            // TxtNachname
            // 
            this.TxtNachname.Location = new System.Drawing.Point(153, 149);
            this.TxtNachname.Name = "TxtNachname";
            this.TxtNachname.Size = new System.Drawing.Size(121, 20);
            this.TxtNachname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vorname";
            // 
            // CmbTitel
            // 
            this.CmbTitel.FormattingEnabled = true;
            this.CmbTitel.Location = new System.Drawing.Point(153, 96);
            this.CmbTitel.Name = "CmbTitel";
            this.CmbTitel.Size = new System.Drawing.Size(121, 21);
            this.CmbTitel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Titel";
            // 
            // CmbAnrede
            // 
            this.CmbAnrede.FormattingEnabled = true;
            this.CmbAnrede.Location = new System.Drawing.Point(153, 69);
            this.CmbAnrede.Name = "CmbAnrede";
            this.CmbAnrede.Size = new System.Drawing.Size(121, 21);
            this.CmbAnrede.TabIndex = 4;
            // 
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(153, 123);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(121, 20);
            this.TxtVorname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anrede";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persönliche Daten";
            // 
            // CmdWerteSpeichern
            // 
            this.CmdWerteSpeichern.Location = new System.Drawing.Point(758, 308);
            this.CmdWerteSpeichern.Name = "CmdWerteSpeichern";
            this.CmdWerteSpeichern.Size = new System.Drawing.Size(160, 23);
            this.CmdWerteSpeichern.TabIndex = 44;
            this.CmdWerteSpeichern.Text = "Änderungen Speichern";
            this.CmdWerteSpeichern.UseVisualStyleBackColor = true;
            this.CmdWerteSpeichern.Click += new System.EventHandler(this.CmdWerteSpeichern_Click);
            // 
            // UcMitarbeiterStamm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdWerteSpeichern);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmdMitarbeiterErstellen);
            this.Controls.Add(this.CmdMitarbeiterBearbeiten);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcMitarbeiterStamm";
            this.Size = new System.Drawing.Size(931, 651);
            this.Load += new System.EventHandler(this.UcMitarbeiterStamm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdMitarbeiterBearbeiten;
        private System.Windows.Forms.Button CmdMitarbeiterErstellen;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtPostleitzahl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtWohnort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtHausnummer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtStrasse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtTelGesch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtTelPriv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtTelMobil;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtFirmenname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAhvNum;
        private System.Windows.Forms.ComboBox CmbNationalitaet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpGeburtsdatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTitel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAnrede;
        private System.Windows.Forms.TextBox TxtVorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdWerteSpeichern;
    }
}
