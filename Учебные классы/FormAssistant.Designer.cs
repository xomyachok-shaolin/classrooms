namespace Учебные_классы {
    partial class FormAssistant {
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
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnTransferEquip = new System.Windows.Forms.Button();
            this.btnTakeOffEquip = new System.Windows.Forms.Button();
            this.btnSetEquip = new System.Windows.Forms.Button();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lblNameWorkstation = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.cbxSeats = new System.Windows.Forms.ComboBox();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.dataEquip = new System.Windows.Forms.DataGridView();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxClasses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(496, 305);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(93, 39);
            this.btnJournal.TabIndex = 36;
            this.btnJournal.Text = "Журнал обслуживания";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // btnTransferEquip
            // 
            this.btnTransferEquip.Location = new System.Drawing.Point(216, 313);
            this.btnTransferEquip.Name = "btnTransferEquip";
            this.btnTransferEquip.Size = new System.Drawing.Size(96, 23);
            this.btnTransferEquip.TabIndex = 35;
            this.btnTransferEquip.Text = "Переместить";
            this.btnTransferEquip.UseVisualStyleBackColor = true;
            this.btnTransferEquip.Click += new System.EventHandler(this.btnTransferEquip_Click);
            // 
            // btnTakeOffEquip
            // 
            this.btnTakeOffEquip.Location = new System.Drawing.Point(114, 313);
            this.btnTakeOffEquip.Name = "btnTakeOffEquip";
            this.btnTakeOffEquip.Size = new System.Drawing.Size(96, 23);
            this.btnTakeOffEquip.TabIndex = 34;
            this.btnTakeOffEquip.Text = "Снять";
            this.btnTakeOffEquip.UseVisualStyleBackColor = true;
            this.btnTakeOffEquip.Click += new System.EventHandler(this.btnTakeOffEquip_Click);
            // 
            // btnSetEquip
            // 
            this.btnSetEquip.Location = new System.Drawing.Point(12, 313);
            this.btnSetEquip.Name = "btnSetEquip";
            this.btnSetEquip.Size = new System.Drawing.Size(96, 23);
            this.btnSetEquip.TabIndex = 33;
            this.btnSetEquip.Text = "Установить";
            this.btnSetEquip.UseVisualStyleBackColor = true;
            this.btnSetEquip.Click += new System.EventHandler(this.btnSetEquip_Click);
            // 
            // lbl_IP
            // 
            this.lbl_IP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_IP.Location = new System.Drawing.Point(332, 27);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(258, 18);
            this.lbl_IP.TabIndex = 32;
            this.lbl_IP.Text = "Label1";
            // 
            // lblNameWorkstation
            // 
            this.lblNameWorkstation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNameWorkstation.Location = new System.Drawing.Point(12, 27);
            this.lblNameWorkstation.Name = "lblNameWorkstation";
            this.lblNameWorkstation.Size = new System.Drawing.Size(313, 18);
            this.lblNameWorkstation.TabIndex = 31;
            this.lblNameWorkstation.Text = "Label1";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(362, 6);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(39, 13);
            this.lblSeat.TabIndex = 30;
            this.lblSeat.Text = "Место";
            // 
            // cbxSeats
            // 
            this.cbxSeats.FormattingEnabled = true;
            this.cbxSeats.Location = new System.Drawing.Point(407, 3);
            this.cbxSeats.Name = "cbxSeats";
            this.cbxSeats.Size = new System.Drawing.Size(183, 21);
            this.cbxSeats.TabIndex = 29;
            this.cbxSeats.SelectedIndexChanged += new System.EventHandler(this.cbxSeats_SelectedIndexChanged);
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(12, 247);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.ReadOnly = true;
            this.txtBoxNote.Size = new System.Drawing.Size(577, 52);
            this.txtBoxNote.TabIndex = 28;
            this.txtBoxNote.TabStop = false;
            // 
            // dataEquip
            // 
            this.dataEquip.AllowUserToAddRows = false;
            this.dataEquip.AllowUserToDeleteRows = false;
            this.dataEquip.AllowUserToResizeColumns = false;
            this.dataEquip.AllowUserToResizeRows = false;
            this.dataEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEquip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataEquip.Location = new System.Drawing.Point(12, 48);
            this.dataEquip.Name = "dataEquip";
            this.dataEquip.ReadOnly = true;
            this.dataEquip.RowHeadersVisible = false;
            this.dataEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEquip.ShowEditingIcon = false;
            this.dataEquip.Size = new System.Drawing.Size(577, 193);
            this.dataEquip.TabIndex = 27;
            this.dataEquip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquip_CellClick);
            this.dataEquip.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquip_CellClick);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(9, 6);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 13);
            this.lblClass.TabIndex = 26;
            this.lblClass.Text = "Label1";
            // 
            // cbxClasses
            // 
            this.cbxClasses.FormattingEnabled = true;
            this.cbxClasses.Location = new System.Drawing.Point(54, 3);
            this.cbxClasses.Name = "cbxClasses";
            this.cbxClasses.Size = new System.Drawing.Size(299, 21);
            this.cbxClasses.TabIndex = 25;
            this.cbxClasses.SelectedIndexChanged += new System.EventHandler(this.cbxClasses_SelectedIndexChanged);
            // 
            // FormAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 351);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.btnTransferEquip);
            this.Controls.Add(this.btnTakeOffEquip);
            this.Controls.Add(this.btnSetEquip);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lblNameWorkstation);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.cbxSeats);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.dataEquip);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbxClasses);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAssistant";
            this.Text = "Обслуживание классов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAssistant_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnTransferEquip;
        private System.Windows.Forms.Button btnTakeOffEquip;
        private System.Windows.Forms.Button btnSetEquip;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lblNameWorkstation;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.ComboBox cbxSeats;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.DataGridView dataEquip;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxClasses;
    }
}