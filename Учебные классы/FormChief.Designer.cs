namespace Учебные_классы {
    partial class FormChief {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblSeatTabJournal = new System.Windows.Forms.Label();
            this.cbxSeatsJournal = new System.Windows.Forms.ComboBox();
            this.txtBoxNoteJournal = new System.Windows.Forms.TextBox();
            this.dataJournal = new System.Windows.Forms.DataGridView();
            this.lblClassTabJournal = new System.Windows.Forms.Label();
            this.cbxClassesJournal = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFilterEquip = new System.Windows.Forms.CheckBox();
            this.btnDeregister = new System.Windows.Forms.Button();
            this.txtBoxNoteEquipTab3 = new System.Windows.Forms.TextBox();
            this.dataEquipTab3 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.dataEquipTab2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNoteSeat = new System.Windows.Forms.TextBox();
            this.dataSeats = new System.Windows.Forms.DataGridView();
            this.lblClassTab2 = new System.Windows.Forms.Label();
            this.cbxClasses = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.btnFilter2 = new System.Windows.Forms.Button();
            this.btnFilter1 = new System.Windows.Forms.Button();
            this.cbxDivisions = new System.Windows.Forms.ComboBox();
            this.dataClasses = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBoxNoteClass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJournal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipTab3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeats)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblSeatTabJournal);
            this.tabPage4.Controls.Add(this.cbxSeatsJournal);
            this.tabPage4.Controls.Add(this.txtBoxNoteJournal);
            this.tabPage4.Controls.Add(this.dataJournal);
            this.tabPage4.Controls.Add(this.lblClassTabJournal);
            this.tabPage4.Controls.Add(this.cbxClassesJournal);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(598, 325);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Журнал тех.обслуживания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblSeatTabJournal
            // 
            this.lblSeatTabJournal.AutoSize = true;
            this.lblSeatTabJournal.Location = new System.Drawing.Point(358, 14);
            this.lblSeatTabJournal.Name = "lblSeatTabJournal";
            this.lblSeatTabJournal.Size = new System.Drawing.Size(39, 13);
            this.lblSeatTabJournal.TabIndex = 12;
            this.lblSeatTabJournal.Text = "Место";
            // 
            // cbxSeatsJournal
            // 
            this.cbxSeatsJournal.FormattingEnabled = true;
            this.cbxSeatsJournal.Location = new System.Drawing.Point(403, 11);
            this.cbxSeatsJournal.Name = "cbxSeatsJournal";
            this.cbxSeatsJournal.Size = new System.Drawing.Size(183, 21);
            this.cbxSeatsJournal.TabIndex = 11;
            this.cbxSeatsJournal.SelectedIndexChanged += new System.EventHandler(this.cbxSeatsJournal_SelectedIndexChanged);
            // 
            // txtBoxNoteJournal
            // 
            this.txtBoxNoteJournal.Location = new System.Drawing.Point(9, 251);
            this.txtBoxNoteJournal.Multiline = true;
            this.txtBoxNoteJournal.Name = "txtBoxNoteJournal";
            this.txtBoxNoteJournal.ReadOnly = true;
            this.txtBoxNoteJournal.Size = new System.Drawing.Size(577, 63);
            this.txtBoxNoteJournal.TabIndex = 10;
            this.txtBoxNoteJournal.TabStop = false;
            // 
            // dataJournal
            // 
            this.dataJournal.AllowUserToAddRows = false;
            this.dataJournal.AllowUserToDeleteRows = false;
            this.dataJournal.AllowUserToResizeColumns = false;
            this.dataJournal.AllowUserToResizeRows = false;
            this.dataJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataJournal.Location = new System.Drawing.Point(9, 38);
            this.dataJournal.Name = "dataJournal";
            this.dataJournal.ReadOnly = true;
            this.dataJournal.RowHeadersVisible = false;
            this.dataJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataJournal.ShowEditingIcon = false;
            this.dataJournal.Size = new System.Drawing.Size(577, 207);
            this.dataJournal.TabIndex = 9;
            this.dataJournal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJournal_CellClick);
            this.dataJournal.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJournal_CellClick);
            // 
            // lblClassTabJournal
            // 
            this.lblClassTabJournal.AutoSize = true;
            this.lblClassTabJournal.Location = new System.Drawing.Point(6, 14);
            this.lblClassTabJournal.Name = "lblClassTabJournal";
            this.lblClassTabJournal.Size = new System.Drawing.Size(39, 13);
            this.lblClassTabJournal.TabIndex = 8;
            this.lblClassTabJournal.Text = "Label1";
            // 
            // cbxClassesJournal
            // 
            this.cbxClassesJournal.FormattingEnabled = true;
            this.cbxClassesJournal.Location = new System.Drawing.Point(51, 11);
            this.cbxClassesJournal.Name = "cbxClassesJournal";
            this.cbxClassesJournal.Size = new System.Drawing.Size(299, 21);
            this.cbxClassesJournal.TabIndex = 7;
            this.cbxClassesJournal.SelectedIndexChanged += new System.EventHandler(this.cbxClassesJournal_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFilterEquip);
            this.tabPage3.Controls.Add(this.btnDeregister);
            this.tabPage3.Controls.Add(this.txtBoxNoteEquipTab3);
            this.tabPage3.Controls.Add(this.dataEquipTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(598, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оборудование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFilterEquip
            // 
            this.btnFilterEquip.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFilterEquip.AutoSize = true;
            this.btnFilterEquip.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilterEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterEquip.Location = new System.Drawing.Point(426, 291);
            this.btnFilterEquip.Name = "btnFilterEquip";
            this.btnFilterEquip.Size = new System.Drawing.Size(159, 23);
            this.btnFilterEquip.TabIndex = 10;
            this.btnFilterEquip.Text = "Неисправное оборудование";
            this.btnFilterEquip.UseVisualStyleBackColor = false;
            this.btnFilterEquip.CheckedChanged += new System.EventHandler(this.btnFilterEquip_CheckedChanged);
            // 
            // btnDeregister
            // 
            this.btnDeregister.Location = new System.Drawing.Point(9, 291);
            this.btnDeregister.Name = "btnDeregister";
            this.btnDeregister.Size = new System.Drawing.Size(108, 23);
            this.btnDeregister.TabIndex = 8;
            this.btnDeregister.Text = "Снять с учета";
            this.btnDeregister.UseVisualStyleBackColor = true;
            this.btnDeregister.Click += new System.EventHandler(this.btnDeregister_Click);
            // 
            // txtBoxNoteEquipTab3
            // 
            this.txtBoxNoteEquipTab3.Location = new System.Drawing.Point(8, 222);
            this.txtBoxNoteEquipTab3.Multiline = true;
            this.txtBoxNoteEquipTab3.Name = "txtBoxNoteEquipTab3";
            this.txtBoxNoteEquipTab3.ReadOnly = true;
            this.txtBoxNoteEquipTab3.Size = new System.Drawing.Size(577, 53);
            this.txtBoxNoteEquipTab3.TabIndex = 7;
            this.txtBoxNoteEquipTab3.TabStop = false;
            // 
            // dataEquipTab3
            // 
            this.dataEquipTab3.AllowUserToAddRows = false;
            this.dataEquipTab3.AllowUserToDeleteRows = false;
            this.dataEquipTab3.AllowUserToResizeColumns = false;
            this.dataEquipTab3.AllowUserToResizeRows = false;
            this.dataEquipTab3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEquipTab3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEquipTab3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataEquipTab3.Location = new System.Drawing.Point(9, 15);
            this.dataEquipTab3.Name = "dataEquipTab3";
            this.dataEquipTab3.ReadOnly = true;
            this.dataEquipTab3.RowHeadersVisible = false;
            this.dataEquipTab3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEquipTab3.ShowEditingIcon = false;
            this.dataEquipTab3.Size = new System.Drawing.Size(577, 201);
            this.dataEquipTab3.TabIndex = 5;
            this.dataEquipTab3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipTab3_CellClick);
            this.dataEquipTab3.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipTab3_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete2);
            this.tabPage2.Controls.Add(this.btnEdit2);
            this.tabPage2.Controls.Add(this.btnAdd2);
            this.tabPage2.Controls.Add(this.dataEquipTab2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtBoxNoteSeat);
            this.tabPage2.Controls.Add(this.dataSeats);
            this.tabPage2.Controls.Add(this.lblClassTab2);
            this.tabPage2.Controls.Add(this.cbxClasses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учебные места";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Enabled = false;
            this.btnDelete2.Location = new System.Drawing.Point(227, 296);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(102, 23);
            this.btnDelete2.TabIndex = 11;
            this.btnDelete2.Text = "Удалить место";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnEdit2
            // 
            this.btnEdit2.Enabled = false;
            this.btnEdit2.Location = new System.Drawing.Point(119, 296);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(102, 23);
            this.btnEdit2.TabIndex = 10;
            this.btnEdit2.Text = "Изменить место";
            this.btnEdit2.UseVisualStyleBackColor = true;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Enabled = false;
            this.btnAdd2.Location = new System.Drawing.Point(11, 296);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(102, 23);
            this.btnAdd2.TabIndex = 9;
            this.btnAdd2.Text = "Добавить место";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // dataEquipTab2
            // 
            this.dataEquipTab2.AllowUserToAddRows = false;
            this.dataEquipTab2.AllowUserToDeleteRows = false;
            this.dataEquipTab2.AllowUserToResizeColumns = false;
            this.dataEquipTab2.AllowUserToResizeRows = false;
            this.dataEquipTab2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEquipTab2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEquipTab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataEquipTab2.Location = new System.Drawing.Point(16, 200);
            this.dataEquipTab2.Name = "dataEquipTab2";
            this.dataEquipTab2.ReadOnly = true;
            this.dataEquipTab2.RowHeadersVisible = false;
            this.dataEquipTab2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEquipTab2.ShowEditingIcon = false;
            this.dataEquipTab2.Size = new System.Drawing.Size(567, 84);
            this.dataEquipTab2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 105);
            this.label3.TabIndex = 8;
            this.label3.Text = "         Оборудование";
            // 
            // txtBoxNoteSeat
            // 
            this.txtBoxNoteSeat.Location = new System.Drawing.Point(11, 136);
            this.txtBoxNoteSeat.Multiline = true;
            this.txtBoxNoteSeat.Name = "txtBoxNoteSeat";
            this.txtBoxNoteSeat.ReadOnly = true;
            this.txtBoxNoteSeat.Size = new System.Drawing.Size(577, 34);
            this.txtBoxNoteSeat.TabIndex = 6;
            this.txtBoxNoteSeat.TabStop = false;
            // 
            // dataSeats
            // 
            this.dataSeats.AllowUserToAddRows = false;
            this.dataSeats.AllowUserToDeleteRows = false;
            this.dataSeats.AllowUserToResizeColumns = false;
            this.dataSeats.AllowUserToResizeRows = false;
            this.dataSeats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSeats.Location = new System.Drawing.Point(11, 35);
            this.dataSeats.Name = "dataSeats";
            this.dataSeats.ReadOnly = true;
            this.dataSeats.RowHeadersVisible = false;
            this.dataSeats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSeats.ShowEditingIcon = false;
            this.dataSeats.Size = new System.Drawing.Size(577, 95);
            this.dataSeats.TabIndex = 4;
            this.dataSeats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSeats_CellClick);
            this.dataSeats.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSeats_CellClick);
            // 
            // lblClassTab2
            // 
            this.lblClassTab2.AutoSize = true;
            this.lblClassTab2.Location = new System.Drawing.Point(8, 11);
            this.lblClassTab2.Name = "lblClassTab2";
            this.lblClassTab2.Size = new System.Drawing.Size(39, 13);
            this.lblClassTab2.TabIndex = 3;
            this.lblClassTab2.Text = "Label1";
            // 
            // cbxClasses
            // 
            this.cbxClasses.FormattingEnabled = true;
            this.cbxClasses.Location = new System.Drawing.Point(53, 8);
            this.cbxClasses.Name = "cbxClasses";
            this.cbxClasses.Size = new System.Drawing.Size(535, 21);
            this.cbxClasses.TabIndex = 2;
            this.cbxClasses.SelectedIndexChanged += new System.EventHandler(this.CbxClasses_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblDivision);
            this.tabPage1.Controls.Add(this.btnFilter2);
            this.tabPage1.Controls.Add(this.btnFilter1);
            this.tabPage1.Controls.Add(this.cbxDivisions);
            this.tabPage1.Controls.Add(this.dataClasses);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.txtBoxNoteClass);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учебные классы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 2);
            this.label2.TabIndex = 7;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 12);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(39, 13);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "Label1";
            // 
            // btnFilter2
            // 
            this.btnFilter2.Location = new System.Drawing.Point(497, 296);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(89, 23);
            this.btnFilter2.TabIndex = 6;
            this.btnFilter2.Text = "Оборуд. места";
            this.btnFilter2.UseVisualStyleBackColor = true;
            this.btnFilter2.Click += new System.EventHandler(this.BtnFilter2_Click);
            // 
            // btnFilter1
            // 
            this.btnFilter1.Location = new System.Drawing.Point(390, 296);
            this.btnFilter1.Name = "btnFilter1";
            this.btnFilter1.Size = new System.Drawing.Size(101, 23);
            this.btnFilter1.TabIndex = 5;
            this.btnFilter1.Text = "Необоруд. места";
            this.btnFilter1.UseVisualStyleBackColor = true;
            this.btnFilter1.Click += new System.EventHandler(this.BtnFilter1_Click);
            // 
            // cbxDivisions
            // 
            this.cbxDivisions.FormattingEnabled = true;
            this.cbxDivisions.Location = new System.Drawing.Point(120, 6);
            this.cbxDivisions.Name = "cbxDivisions";
            this.cbxDivisions.Size = new System.Drawing.Size(466, 21);
            this.cbxDivisions.TabIndex = 0;
            this.cbxDivisions.SelectedIndexChanged += new System.EventHandler(this.CbxDivisions_SelectedIndexChanged);
            // 
            // dataClasses
            // 
            this.dataClasses.AllowUserToAddRows = false;
            this.dataClasses.AllowUserToDeleteRows = false;
            this.dataClasses.AllowUserToResizeColumns = false;
            this.dataClasses.AllowUserToResizeRows = false;
            this.dataClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataClasses.Location = new System.Drawing.Point(9, 36);
            this.dataClasses.Name = "dataClasses";
            this.dataClasses.ReadOnly = true;
            this.dataClasses.RowHeadersVisible = false;
            this.dataClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClasses.ShowEditingIcon = false;
            this.dataClasses.Size = new System.Drawing.Size(577, 173);
            this.dataClasses.TabIndex = 1;
            this.dataClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClasses_CellClick);
            this.dataClasses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClasses_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(90, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtBoxNoteClass
            // 
            this.txtBoxNoteClass.Location = new System.Drawing.Point(9, 215);
            this.txtBoxNoteClass.Multiline = true;
            this.txtBoxNoteClass.Name = "txtBoxNoteClass";
            this.txtBoxNoteClass.ReadOnly = true;
            this.txtBoxNoteClass.Size = new System.Drawing.Size(577, 69);
            this.txtBoxNoteClass.TabIndex = 2;
            this.txtBoxNoteClass.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(606, 354);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 9;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // FormChief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 351);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChief";
            this.Text = "Обслуживание классов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJournal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipTab3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeats)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblSeatTabJournal;
        private System.Windows.Forms.ComboBox cbxSeatsJournal;
        private System.Windows.Forms.TextBox txtBoxNoteJournal;
        private System.Windows.Forms.DataGridView dataJournal;
        private System.Windows.Forms.Label lblClassTabJournal;
        private System.Windows.Forms.ComboBox cbxClassesJournal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox btnFilterEquip;
        private System.Windows.Forms.Button btnDeregister;
        private System.Windows.Forms.TextBox txtBoxNoteEquipTab3;
        private System.Windows.Forms.DataGridView dataEquipTab3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.DataGridView dataEquipTab2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNoteSeat;
        private System.Windows.Forms.DataGridView dataSeats;
        private System.Windows.Forms.Label lblClassTab2;
        private System.Windows.Forms.ComboBox cbxClasses;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Button btnFilter2;
        private System.Windows.Forms.Button btnFilter1;
        private System.Windows.Forms.ComboBox cbxDivisions;
        private System.Windows.Forms.DataGridView dataClasses;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtBoxNoteClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl;
    }
}