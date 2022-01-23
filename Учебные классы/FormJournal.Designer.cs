namespace Учебные_классы {
    partial class FormJournal {
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
            this.lblSeatTabJournal = new System.Windows.Forms.Label();
            this.cbxSeatsJournal = new System.Windows.Forms.ComboBox();
            this.txtBoxNoteJournal = new System.Windows.Forms.TextBox();
            this.dataJournal = new System.Windows.Forms.DataGridView();
            this.lblClassTabJournal = new System.Windows.Forms.Label();
            this.cbxClassesJournal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeatTabJournal
            // 
            this.lblSeatTabJournal.AutoSize = true;
            this.lblSeatTabJournal.Location = new System.Drawing.Point(361, 9);
            this.lblSeatTabJournal.Name = "lblSeatTabJournal";
            this.lblSeatTabJournal.Size = new System.Drawing.Size(39, 13);
            this.lblSeatTabJournal.TabIndex = 18;
            this.lblSeatTabJournal.Text = "Место";
            // 
            // cbxSeatsJournal
            // 
            this.cbxSeatsJournal.FormattingEnabled = true;
            this.cbxSeatsJournal.Location = new System.Drawing.Point(406, 6);
            this.cbxSeatsJournal.Name = "cbxSeatsJournal";
            this.cbxSeatsJournal.Size = new System.Drawing.Size(183, 21);
            this.cbxSeatsJournal.TabIndex = 17;
            this.cbxSeatsJournal.SelectedIndexChanged += new System.EventHandler(this.cbxSeatsJournal_SelectedIndexChanged);
            // 
            // txtBoxNoteJournal
            // 
            this.txtBoxNoteJournal.Location = new System.Drawing.Point(12, 276);
            this.txtBoxNoteJournal.Multiline = true;
            this.txtBoxNoteJournal.Name = "txtBoxNoteJournal";
            this.txtBoxNoteJournal.ReadOnly = true;
            this.txtBoxNoteJournal.Size = new System.Drawing.Size(577, 63);
            this.txtBoxNoteJournal.TabIndex = 16;
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
            this.dataJournal.Location = new System.Drawing.Point(12, 33);
            this.dataJournal.Name = "dataJournal";
            this.dataJournal.ReadOnly = true;
            this.dataJournal.RowHeadersVisible = false;
            this.dataJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataJournal.ShowEditingIcon = false;
            this.dataJournal.Size = new System.Drawing.Size(577, 237);
            this.dataJournal.TabIndex = 15;
            this.dataJournal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJournal_CellClick);
            this.dataJournal.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJournal_CellClick);
            // 
            // lblClassTabJournal
            // 
            this.lblClassTabJournal.AutoSize = true;
            this.lblClassTabJournal.Location = new System.Drawing.Point(9, 9);
            this.lblClassTabJournal.Name = "lblClassTabJournal";
            this.lblClassTabJournal.Size = new System.Drawing.Size(39, 13);
            this.lblClassTabJournal.TabIndex = 14;
            this.lblClassTabJournal.Text = "Label1";
            // 
            // cbxClassesJournal
            // 
            this.cbxClassesJournal.FormattingEnabled = true;
            this.cbxClassesJournal.Location = new System.Drawing.Point(54, 6);
            this.cbxClassesJournal.Name = "cbxClassesJournal";
            this.cbxClassesJournal.Size = new System.Drawing.Size(299, 21);
            this.cbxClassesJournal.TabIndex = 13;
            this.cbxClassesJournal.SelectedIndexChanged += new System.EventHandler(this.cbxClassesJournal_SelectedIndexChanged);
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 351);
            this.Controls.Add(this.lblSeatTabJournal);
            this.Controls.Add(this.cbxSeatsJournal);
            this.Controls.Add(this.txtBoxNoteJournal);
            this.Controls.Add(this.dataJournal);
            this.Controls.Add(this.lblClassTabJournal);
            this.Controls.Add(this.cbxClassesJournal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormJournal";
            this.Text = "Журнал технического обслуживания";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataJournal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeatTabJournal;
        private System.Windows.Forms.ComboBox cbxSeatsJournal;
        private System.Windows.Forms.TextBox txtBoxNoteJournal;
        private System.Windows.Forms.DataGridView dataJournal;
        private System.Windows.Forms.Label lblClassTabJournal;
        private System.Windows.Forms.ComboBox cbxClassesJournal;
    }
}