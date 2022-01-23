namespace Учебные_классы {
    partial class Form2_Edit {
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxNameWorkstation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTxtBoxIP = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNumberSeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 244);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер учебного места:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя рабочей станции:";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(174, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtBoxNameWorkstation
            // 
            this.txtBoxNameWorkstation.Location = new System.Drawing.Point(138, 34);
            this.txtBoxNameWorkstation.Multiline = true;
            this.txtBoxNameWorkstation.Name = "txtBoxNameWorkstation";
            this.txtBoxNameWorkstation.Size = new System.Drawing.Size(192, 18);
            this.txtBoxNameWorkstation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "IP-адрес:";
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(16, 104);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(314, 120);
            this.txtBoxNote.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Оставьте примечание (не обязательно):";
            // 
            // maskedTxtBoxIP
            // 
            this.maskedTxtBoxIP.Location = new System.Drawing.Point(72, 56);
            this.maskedTxtBoxIP.Mask = "###\\\\.###\\\\.###\\\\.###";
            this.maskedTxtBoxIP.Name = "maskedTxtBoxIP";
            this.maskedTxtBoxIP.Size = new System.Drawing.Size(112, 20);
            this.maskedTxtBoxIP.TabIndex = 3;
            // 
            // txtBoxNumberSeat
            // 
            this.txtBoxNumberSeat.Location = new System.Drawing.Point(145, 10);
            this.txtBoxNumberSeat.Multiline = true;
            this.txtBoxNumberSeat.Name = "txtBoxNumberSeat";
            this.txtBoxNumberSeat.Size = new System.Drawing.Size(185, 18);
            this.txtBoxNumberSeat.TabIndex = 1;
            // 
            // Form2_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(342, 279);
            this.Controls.Add(this.txtBoxNumberSeat);
            this.Controls.Add(this.maskedTxtBoxIP);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNameWorkstation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2_Edit";
            this.ShowIcon = false;
            this.Text = "Изменить учебное место";
            this.Load += new System.EventHandler(this.Form2_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxNameWorkstation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxIP;
        private System.Windows.Forms.TextBox txtBoxNumberSeat;
    }
}