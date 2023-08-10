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
            this.DtgData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anrede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon_Mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon_Privat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon_Arbeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CmdWerteSpeichern = new System.Windows.Forms.Button();
            this.CmdMitarbeiterSpeichern = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPostleitzahl = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtWohnort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.NumKaderstufe = new System.Windows.Forms.NumericUpDown();
            this.NumArbeitspensum = new System.Windows.Forms.NumericUpDown();
            this.DtpStartdatum = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtAbteilung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAhvNum = new System.Windows.Forms.TextBox();
            this.CmbNationalitaet = new System.Windows.Forms.ComboBox();
            this.LblId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.CmdMitarbeiterErstellen = new System.Windows.Forms.Button();
            this.CmdMitarbeiterBearbeiten = new System.Windows.Forms.Button();
            this.Kill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumKaderstufe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumArbeitspensum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgData
            // 
            this.DtgData.AllowUserToAddRows = false;
            this.DtgData.AllowUserToDeleteRows = false;
            this.DtgData.AllowUserToOrderColumns = true;
            this.DtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Anrede,
            this.Nachname,
            this.Vorname,
            this.Geburtsdatum,
            this.EMail,
            this.Telefon_Mobil,
            this.Telefon_Privat,
            this.Telefon_Arbeit});
            this.DtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgData.Location = new System.Drawing.Point(0, 0);
            this.DtgData.Name = "DtgData";
            this.DtgData.RowHeadersWidth = 51;
            this.DtgData.Size = new System.Drawing.Size(934, 366);
            this.DtgData.TabIndex = 0;
            this.DtgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Anrede
            // 
            this.Anrede.HeaderText = "Anrede";
            this.Anrede.MinimumWidth = 6;
            this.Anrede.Name = "Anrede";
            this.Anrede.ReadOnly = true;
            this.Anrede.Width = 125;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.MinimumWidth = 6;
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 125;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 6;
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 125;
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.HeaderText = "Geburtsdatum";
            this.Geburtsdatum.MinimumWidth = 6;
            this.Geburtsdatum.Name = "Geburtsdatum";
            this.Geburtsdatum.ReadOnly = true;
            this.Geburtsdatum.Width = 125;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "EMail";
            this.EMail.MinimumWidth = 6;
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Width = 125;
            // 
            // Telefon_Mobil
            // 
            this.Telefon_Mobil.HeaderText = "Telefon Mobil";
            this.Telefon_Mobil.MinimumWidth = 6;
            this.Telefon_Mobil.Name = "Telefon_Mobil";
            this.Telefon_Mobil.ReadOnly = true;
            this.Telefon_Mobil.Width = 125;
            // 
            // Telefon_Privat
            // 
            this.Telefon_Privat.HeaderText = "Telefon Privat";
            this.Telefon_Privat.MinimumWidth = 6;
            this.Telefon_Privat.Name = "Telefon_Privat";
            this.Telefon_Privat.ReadOnly = true;
            this.Telefon_Privat.Width = 125;
            // 
            // Telefon_Arbeit
            // 
            this.Telefon_Arbeit.HeaderText = "Telefon Arbeit";
            this.Telefon_Arbeit.MinimumWidth = 6;
            this.Telefon_Arbeit.Name = "Telefon_Arbeit";
            this.Telefon_Arbeit.ReadOnly = true;
            this.Telefon_Arbeit.Width = 125;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.Kill);
            this.splitContainer1.Panel1.Controls.Add(this.CmdWerteSpeichern);
            this.splitContainer1.Panel1.Controls.Add(this.CmdMitarbeiterSpeichern);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.CmdMitarbeiterErstellen);
            this.splitContainer1.Panel1.Controls.Add(this.CmdMitarbeiterBearbeiten);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DtgData);
            this.splitContainer1.Size = new System.Drawing.Size(934, 791);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // CmdWerteSpeichern
            // 
            this.CmdWerteSpeichern.Location = new System.Drawing.Point(9, 6);
            this.CmdWerteSpeichern.Name = "CmdWerteSpeichern";
            this.CmdWerteSpeichern.Size = new System.Drawing.Size(64, 42);
            this.CmdWerteSpeichern.TabIndex = 57;
            this.CmdWerteSpeichern.Text = "Speichern";
            this.CmdWerteSpeichern.UseVisualStyleBackColor = true;
            this.CmdWerteSpeichern.Visible = false;
            this.CmdWerteSpeichern.Click += new System.EventHandler(this.CmdWerteSpeichern_Click);
            // 
            // CmdMitarbeiterSpeichern
            // 
            this.CmdMitarbeiterSpeichern.Location = new System.Drawing.Point(9, 6);
            this.CmdMitarbeiterSpeichern.Name = "CmdMitarbeiterSpeichern";
            this.CmdMitarbeiterSpeichern.Size = new System.Drawing.Size(64, 42);
            this.CmdMitarbeiterSpeichern.TabIndex = 56;
            this.CmdMitarbeiterSpeichern.Text = "Speichern";
            this.CmdMitarbeiterSpeichern.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterSpeichern.Visible = false;
            this.CmdMitarbeiterSpeichern.Click += new System.EventHandler(this.CmdMitarbeiterSpeichern_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(619, 310);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 71);
            this.textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 254);
            this.textBox1.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.TxtPostleitzahl);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.TxtWohnort);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.TxtStrasse);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(9, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 104);
            this.panel3.TabIndex = 52;
            // 
            // TxtPostleitzahl
            // 
            this.TxtPostleitzahl.Location = new System.Drawing.Point(153, 76);
            this.TxtPostleitzahl.Name = "TxtPostleitzahl";
            this.TxtPostleitzahl.ReadOnly = true;
            this.TxtPostleitzahl.Size = new System.Drawing.Size(121, 20);
            this.TxtPostleitzahl.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Postleitzahl:";
            // 
            // TxtWohnort
            // 
            this.TxtWohnort.Location = new System.Drawing.Point(153, 50);
            this.TxtWohnort.Name = "TxtWohnort";
            this.TxtWohnort.ReadOnly = true;
            this.TxtWohnort.Size = new System.Drawing.Size(121, 20);
            this.TxtWohnort.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Wohnort:";
            // 
            // TxtStrasse
            // 
            this.TxtStrasse.Location = new System.Drawing.Point(153, 24);
            this.TxtStrasse.Name = "TxtStrasse";
            this.TxtStrasse.ReadOnly = true;
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
            this.panel4.Location = new System.Drawing.Point(320, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 140);
            this.panel4.TabIndex = 51;
            // 
            // TxtTelGesch
            // 
            this.TxtTelGesch.Location = new System.Drawing.Point(134, 101);
            this.TxtTelGesch.Name = "TxtTelGesch";
            this.TxtTelGesch.ReadOnly = true;
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
            this.TxtTelPriv.ReadOnly = true;
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
            this.TxtTelMobil.ReadOnly = true;
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
            this.TxtEmail.ReadOnly = true;
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
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Kontaktdaten";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.NumKaderstufe);
            this.panel2.Controls.Add(this.NumArbeitspensum);
            this.panel2.Controls.Add(this.DtpStartdatum);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.TxtAbteilung);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(320, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 221);
            this.panel2.TabIndex = 50;
            // 
            // NumKaderstufe
            // 
            this.NumKaderstufe.Location = new System.Drawing.Point(134, 25);
            this.NumKaderstufe.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumKaderstufe.Name = "NumKaderstufe";
            this.NumKaderstufe.Size = new System.Drawing.Size(120, 20);
            this.NumKaderstufe.TabIndex = 32;
            // 
            // NumArbeitspensum
            // 
            this.NumArbeitspensum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumArbeitspensum.Location = new System.Drawing.Point(134, 76);
            this.NumArbeitspensum.Name = "NumArbeitspensum";
            this.NumArbeitspensum.Size = new System.Drawing.Size(120, 20);
            this.NumArbeitspensum.TabIndex = 31;
            // 
            // DtpStartdatum
            // 
            this.DtpStartdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStartdatum.Location = new System.Drawing.Point(134, 102);
            this.DtpStartdatum.Name = "DtpStartdatum";
            this.DtpStartdatum.Size = new System.Drawing.Size(121, 20);
            this.DtpStartdatum.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Startdatum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Arbeitspensum";
            // 
            // TxtAbteilung
            // 
            this.TxtAbteilung.Location = new System.Drawing.Point(134, 50);
            this.TxtAbteilung.Name = "TxtAbteilung";
            this.TxtAbteilung.ReadOnly = true;
            this.TxtAbteilung.Size = new System.Drawing.Size(121, 20);
            this.TxtAbteilung.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Abteilung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kaderstufe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mitarbeiter";
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
            this.panel1.Location = new System.Drawing.Point(9, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 254);
            this.panel1.TabIndex = 49;
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Enabled = false;
            this.ChkStatus.Location = new System.Drawing.Point(153, 44);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(92, 17);
            this.ChkStatus.TabIndex = 48;
            this.ChkStatus.Text = "Status ändern";
            this.ChkStatus.UseVisualStyleBackColor = true;
            this.ChkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);
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
            // TxtAhvNum
            // 
            this.TxtAhvNum.Location = new System.Drawing.Point(153, 228);
            this.TxtAhvNum.Name = "TxtAhvNum";
            this.TxtAhvNum.ReadOnly = true;
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
            this.TxtNachname.ReadOnly = true;
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
            this.TxtVorname.ReadOnly = true;
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
            // CmdMitarbeiterErstellen
            // 
            this.CmdMitarbeiterErstellen.Location = new System.Drawing.Point(9, 6);
            this.CmdMitarbeiterErstellen.Name = "CmdMitarbeiterErstellen";
            this.CmdMitarbeiterErstellen.Size = new System.Drawing.Size(58, 42);
            this.CmdMitarbeiterErstellen.TabIndex = 48;
            this.CmdMitarbeiterErstellen.Text = "Erstellen";
            this.CmdMitarbeiterErstellen.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterErstellen.Click += new System.EventHandler(this.CmdMitarbeiterErstellen_Click);
            // 
            // CmdMitarbeiterBearbeiten
            // 
            this.CmdMitarbeiterBearbeiten.Location = new System.Drawing.Point(80, 6);
            this.CmdMitarbeiterBearbeiten.Name = "CmdMitarbeiterBearbeiten";
            this.CmdMitarbeiterBearbeiten.Size = new System.Drawing.Size(68, 42);
            this.CmdMitarbeiterBearbeiten.TabIndex = 47;
            this.CmdMitarbeiterBearbeiten.Text = "Bearbeiten";
            this.CmdMitarbeiterBearbeiten.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterBearbeiten.Visible = false;
            this.CmdMitarbeiterBearbeiten.Click += new System.EventHandler(this.CmdMitarbeiterBearbeiten_Click);
            // 
            // Kill
            // 
            this.Kill.Location = new System.Drawing.Point(208, 16);
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(75, 23);
            this.Kill.TabIndex = 70;
            this.Kill.Text = "Killswitch";
            this.Kill.UseVisualStyleBackColor = true;
            this.Kill.Click += new System.EventHandler(this.Kill_Click);
            // 
            // UcMitarbeiterStamm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcMitarbeiterStamm";
            this.Size = new System.Drawing.Size(934, 791);
            this.Load += new System.EventHandler(this.UcMitarbeiterStamm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumKaderstufe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumArbeitspensum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtPostleitzahl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtWohnort;
        private System.Windows.Forms.Label label18;
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
        private System.Windows.Forms.NumericUpDown NumKaderstufe;
        private System.Windows.Forms.NumericUpDown NumArbeitspensum;
        private System.Windows.Forms.DateTimePicker DtpStartdatum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtAbteilung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtAhvNum;
        private System.Windows.Forms.ComboBox CmbNationalitaet;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Button CmdMitarbeiterErstellen;
        private System.Windows.Forms.Button CmdMitarbeiterBearbeiten;
        private System.Windows.Forms.Button CmdMitarbeiterSpeichern;
        private System.Windows.Forms.Button CmdWerteSpeichern;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anrede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon_Mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon_Privat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon_Arbeit;
        private System.Windows.Forms.Button Kill;
    }
}
